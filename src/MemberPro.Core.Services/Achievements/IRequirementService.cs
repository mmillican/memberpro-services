using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MemberPro.Core.Data;
using MemberPro.Core.Entities.Achievements;
using MemberPro.Core.Exceptions;
using MemberPro.Core.Models.Achievements;
using MemberPro.Core.Services.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace MemberPro.Core.Services.Achievements
{
    public interface IRequirementService
    {
        Task<RequirementModel> FindByIdAsync(int id);

        Task<IEnumerable<RequirementModel>> GetByAchievementIdAsync(int achievementId);
        Task<IEnumerable<RequirementModel>> GetByComponentIdAsync(int componentId);

        Task<RequirementModel> CreateAsync(int componentId, RequirementModel model);
        Task UpdateAsync(RequirementModel model);
    }

    public class RequirementService : IRequirementService
    {
        private readonly IRepository<Requirement> _requirementRepository;
        private readonly IAchievementComponentService _componentService;
        private readonly IDateTimeService _dateTimeService;
        private readonly IMapper _mapper;
        private readonly ILogger<RequirementService> _logger;

        public RequirementService(IRepository<Requirement> requirementRepository,
            IAchievementComponentService componentService,
            IDateTimeService dateTimeService,
            IMapper mapper,
            ILogger<RequirementService> logger)
        {
            _requirementRepository = requirementRepository;
            _componentService = componentService;
            _dateTimeService = dateTimeService;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<RequirementModel> FindByIdAsync(int id)
        {
            var Component = await _requirementRepository.GetByIdAsync(id);
            if (Component == null)
                return null;

            var model = _mapper.Map<RequirementModel>(Component);
            return model;
        }

        public async Task<IEnumerable<RequirementModel>> GetByAchievementIdAsync(int achievementId)
        {
            // NOTE: Cannot map to the model as part of the query due to JSON property (Parts)
            var requirements = await _requirementRepository.TableNoTracking
                .Where(x => x.Component.AchievementId == achievementId)
                .OrderBy(x => x.ComponentId)
                .ThenBy(x => x.Name)
                .ToListAsync();

            var models = requirements.Select(x => _mapper.Map<RequirementModel>(x));
            return models;
        }

        public async Task<IEnumerable<RequirementModel>> GetByComponentIdAsync(int componentId)
        {
            // NOTE: Cannot map to the model as part of the query due to JSON property (Parts)
            var requirements = await _requirementRepository.TableNoTracking
                .Where(x => x.ComponentId == componentId)
                .OrderBy(x => x.Name)
                .ToListAsync();

            var models = requirements.Select(x => _mapper.Map<RequirementModel>(x));
            return models;
        }

        public async Task<RequirementModel> CreateAsync(int componentId, RequirementModel model)
        {
            var component = await _componentService.FindByIdAsync(componentId);
            if (component == null)
            {
                throw new ItemNotFoundException($"AchievementComponent ID {componentId} not found");
            }

            try
            {
                var requirement = new Requirement
                {
                    ComponentId = component.Id,
                    Name = model.Name,
                    Description = model.Description,
                    ValidatorTypeName = model.ValidatorTypeName,
                    ValidationParameters = model.ValidationParameters,
                    Type = model.Type,
                    MinCount = model.MinCount,
                    MaxCount = model.MaxCount,
                };

                await _requirementRepository.CreateAsync(requirement);

                var newRequirement = await FindByIdAsync(requirement.Id);
                return newRequirement;
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Error creating requirement");

                throw new ApplicationException("Error creating requirement", ex);
            }
        }

        public async Task UpdateAsync(RequirementModel model)
        {
            var requirement = await _requirementRepository.GetByIdAsync(model.Id);
            if (requirement == null)
            {
                throw new ItemNotFoundException($"Component ID {model.Id} not found.");
            }

            try
            {
                requirement.Name = model.Name;
                requirement.Description = model.Description;
                requirement.ValidatorTypeName = model.ValidatorTypeName;
                requirement.ValidationParameters = model.ValidationParameters;
                requirement.Type = model.Type;
                requirement.MinCount = model.MinCount;
                requirement.MaxCount = model.MaxCount;

                await _requirementRepository.UpdateAsync(requirement);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Error updating requirement");

                throw new ApplicationException("Error updating requirement", ex);
            }
        }
    }
}
