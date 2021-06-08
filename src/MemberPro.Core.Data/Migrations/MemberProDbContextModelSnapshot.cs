﻿// <auto-generated />
using System;
using MemberPro.Core.Data.Implementations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MemberPro.Core.Data.Migrations
{
    [DbContext(typeof(MemberProDbContext))]
    partial class MemberProDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("MemberPro.Core.Entities.Achievements.Achievement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_on");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("ImageFilename")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("image_filename");

                    b.Property<string>("InfoUrl")
                        .HasMaxLength(2000)
                        .HasColumnType("character varying(2000)")
                        .HasColumnName("info_url");

                    b.Property<bool>("IsDisabled")
                        .HasColumnType("boolean")
                        .HasColumnName("is_disabled");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("name");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_on");

                    b.HasKey("Id")
                        .HasName("pk_achievement");

                    b.ToTable("achievement");
                });

            modelBuilder.Entity("MemberPro.Core.Entities.Achievements.AchievementStep", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AchievementId")
                        .HasColumnType("integer")
                        .HasColumnName("achievement_id");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_on");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<bool>("IsDisabled")
                        .HasColumnType("boolean")
                        .HasColumnName("is_disabled");

                    b.Property<bool>("IsRequired")
                        .HasColumnType("boolean")
                        .HasColumnName("is_required");

                    b.Property<int?>("MinimumCount")
                        .HasColumnType("integer")
                        .HasColumnName("minimum_count");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("name");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_on");

                    b.HasKey("Id")
                        .HasName("pk_achievement_step");

                    b.HasIndex("AchievementId")
                        .HasDatabaseName("ix_achievement_step_achievement_id");

                    b.ToTable("achievement_step");
                });

            modelBuilder.Entity("MemberPro.Core.Entities.Geography.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Abbreviation")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("abbreviation");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_country");

                    b.ToTable("country");
                });

            modelBuilder.Entity("MemberPro.Core.Entities.Geography.Division", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Abbreviation")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("abbreviation");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("name");

                    b.Property<int>("RegionId")
                        .HasColumnType("integer")
                        .HasColumnName("region_id");

                    b.HasKey("Id")
                        .HasName("pk_division");

                    b.HasIndex("RegionId")
                        .HasDatabaseName("ix_division_region_id");

                    b.ToTable("division");
                });

            modelBuilder.Entity("MemberPro.Core.Entities.Geography.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Abbreviation")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("abbreviation");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_region");

                    b.ToTable("region");
                });

            modelBuilder.Entity("MemberPro.Core.Entities.Geography.StateProvince", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Abbreviation")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("abbreviation");

                    b.Property<int>("CountryId")
                        .HasColumnType("integer")
                        .HasColumnName("country_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_state_province");

                    b.HasIndex("CountryId")
                        .HasDatabaseName("ix_state_province_country_id");

                    b.ToTable("state_province");
                });

            modelBuilder.Entity("MemberPro.Core.Entities.Members.CustomField", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("description");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("integer")
                        .HasColumnName("display_order");

                    b.Property<int>("FieldType")
                        .HasColumnType("integer")
                        .HasColumnName("field_type");

                    b.Property<bool>("IsRequired")
                        .HasColumnType("boolean")
                        .HasColumnName("is_required");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("name");

                    b.Property<string>("ValueOptions")
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)")
                        .HasColumnName("value_options");

                    b.HasKey("Id")
                        .HasName("pk_custom_field");

                    b.ToTable("custom_field");
                });

            modelBuilder.Entity("MemberPro.Core.Entities.Members.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("address");

                    b.Property<string>("Address2")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("address2");

                    b.Property<string>("Biography")
                        .HasMaxLength(2000)
                        .HasColumnType("character varying(2000)")
                        .HasColumnName("biography");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("city");

                    b.Property<int>("CountryId")
                        .HasColumnType("integer")
                        .HasColumnName("country_id");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_of_birth");

                    b.Property<int?>("DivisionId")
                        .HasColumnType("integer")
                        .HasColumnName("division_id");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("email_address");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("first_name");

                    b.Property<string>("Interests")
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)")
                        .HasColumnName("interests");

                    b.Property<DateTime>("JoinedOn")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("joined_on");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("last_name");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("phone_number");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("postal_code");

                    b.Property<int?>("RegionId")
                        .HasColumnType("integer")
                        .HasColumnName("region_id");

                    b.Property<bool>("ShowInDirectory")
                        .HasColumnType("boolean")
                        .HasColumnName("show_in_directory");

                    b.Property<int>("StateProvinceId")
                        .HasColumnType("integer")
                        .HasColumnName("state_province_id");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("subject_id");

                    b.HasKey("Id")
                        .HasName("pk_member");

                    b.HasIndex("CountryId")
                        .HasDatabaseName("ix_member_country_id");

                    b.HasIndex("DivisionId")
                        .HasDatabaseName("ix_member_division_id");

                    b.HasIndex("RegionId")
                        .HasDatabaseName("ix_member_region_id");

                    b.HasIndex("StateProvinceId")
                        .HasDatabaseName("ix_member_state_province_id");

                    b.ToTable("member");
                });

            modelBuilder.Entity("MemberPro.Core.Entities.Members.MemberAchievement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AchievementId")
                        .HasColumnType("integer")
                        .HasColumnName("achievement_id");

                    b.Property<int?>("ApprovedByMemberId")
                        .HasColumnType("integer")
                        .HasColumnName("approved_by_member_id");

                    b.Property<DateTime?>("ApprovedOn")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("approved_on");

                    b.Property<bool>("DisplayPublicly")
                        .HasColumnType("boolean")
                        .HasColumnName("display_publicly");

                    b.Property<int>("MemberId")
                        .HasColumnType("integer")
                        .HasColumnName("member_id");

                    b.Property<DateTime>("SubmittedOn")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("submitted_on");

                    b.HasKey("Id")
                        .HasName("pk_member_achievement");

                    b.HasIndex("AchievementId")
                        .HasDatabaseName("ix_member_achievement_achievement_id");

                    b.HasIndex("ApprovedByMemberId")
                        .HasDatabaseName("ix_member_achievement_approved_by_member_id");

                    b.HasIndex("MemberId")
                        .HasDatabaseName("ix_member_achievement_member_id");

                    b.ToTable("member_achievement");
                });

            modelBuilder.Entity("MemberPro.Core.Entities.Members.MemberAchievementProgress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AchievementId")
                        .HasColumnType("integer")
                        .HasColumnName("achievement_id");

                    b.Property<int>("Amount")
                        .HasColumnType("integer")
                        .HasColumnName("amount");

                    b.Property<string>("Comments")
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)")
                        .HasColumnName("comments");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_on");

                    b.Property<int>("MemberId")
                        .HasColumnType("integer")
                        .HasColumnName("member_id");

                    b.HasKey("Id")
                        .HasName("pk_member_achievement_progress");

                    b.HasIndex("AchievementId")
                        .HasDatabaseName("ix_member_achievement_progress_achievement_id");

                    b.HasIndex("MemberId")
                        .HasDatabaseName("ix_member_achievement_progress_member_id");

                    b.ToTable("member_achievement_progress");
                });

            modelBuilder.Entity("MemberPro.Core.Entities.Members.MemberCustomFieldValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("FieldId")
                        .HasColumnType("integer")
                        .HasColumnName("field_id");

                    b.Property<int>("MemberId")
                        .HasColumnType("integer")
                        .HasColumnName("member_id");

                    b.Property<string>("Value")
                        .HasColumnType("text")
                        .HasColumnName("value");

                    b.HasKey("Id")
                        .HasName("pk_member_custom_field_value");

                    b.HasIndex("FieldId")
                        .HasDatabaseName("ix_member_custom_field_value_field_id");

                    b.HasIndex("MemberId")
                        .HasDatabaseName("ix_member_custom_field_value_member_id");

                    b.ToTable("member_custom_field_value");
                });

            modelBuilder.Entity("MemberPro.Core.Entities.Members.MemberRenewal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Comments")
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)")
                        .HasColumnName("comments");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("end_date");

                    b.Property<int>("MemberId")
                        .HasColumnType("integer")
                        .HasColumnName("member_id");

                    b.Property<decimal?>("PaidAmount")
                        .HasColumnType("numeric")
                        .HasColumnName("paid_amount");

                    b.Property<DateTime?>("PaidDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("paid_date");

                    b.Property<int>("PlanId")
                        .HasColumnType("integer")
                        .HasColumnName("plan_id");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("start_date");

                    b.Property<string>("TransactionId")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("transaction_id");

                    b.HasKey("Id")
                        .HasName("pk_member_renewal");

                    b.HasIndex("MemberId")
                        .HasDatabaseName("ix_member_renewal_member_id");

                    b.HasIndex("PlanId")
                        .HasDatabaseName("ix_member_renewal_plan_id");

                    b.ToTable("member_renewal");
                });

            modelBuilder.Entity("MemberPro.Core.Entities.Plans.MembershipPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("AvailableEndDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("available_end_date");

                    b.Property<DateTime>("AvailableStartDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("available_start_date");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_on");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("description");

                    b.Property<int>("DurationInMonths")
                        .HasColumnType("integer")
                        .HasColumnName("duration_in_months");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric(8,2)")
                        .HasColumnName("price");

                    b.Property<string>("SKU")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("sku");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_on");

                    b.HasKey("Id")
                        .HasName("pk_membership_plan");

                    b.ToTable("membership_plan");
                });

            modelBuilder.Entity("MemberPro.Core.Entities.Achievements.AchievementStep", b =>
                {
                    b.HasOne("MemberPro.Core.Entities.Achievements.Achievement", "Achievement")
                        .WithMany("Steps")
                        .HasForeignKey("AchievementId")
                        .HasConstraintName("fk_achievement_step_achievement_achievement_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Achievement");
                });

            modelBuilder.Entity("MemberPro.Core.Entities.Geography.Division", b =>
                {
                    b.HasOne("MemberPro.Core.Entities.Geography.Region", "Region")
                        .WithMany("Divisions")
                        .HasForeignKey("RegionId")
                        .HasConstraintName("fk_division_region_region_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Region");
                });

            modelBuilder.Entity("MemberPro.Core.Entities.Geography.StateProvince", b =>
                {
                    b.HasOne("MemberPro.Core.Entities.Geography.Country", "Country")
                        .WithMany("StateProvinces")
                        .HasForeignKey("CountryId")
                        .HasConstraintName("fk_state_province_country_country_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("MemberPro.Core.Entities.Members.Member", b =>
                {
                    b.HasOne("MemberPro.Core.Entities.Geography.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .HasConstraintName("fk_member_country_country_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MemberPro.Core.Entities.Geography.Division", "Division")
                        .WithMany()
                        .HasForeignKey("DivisionId")
                        .HasConstraintName("fk_member_division_division_id");

                    b.HasOne("MemberPro.Core.Entities.Geography.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId")
                        .HasConstraintName("fk_member_region_region_id");

                    b.HasOne("MemberPro.Core.Entities.Geography.StateProvince", "StateProvince")
                        .WithMany()
                        .HasForeignKey("StateProvinceId")
                        .HasConstraintName("fk_member_state_province_state_province_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("Division");

                    b.Navigation("Region");

                    b.Navigation("StateProvince");
                });

            modelBuilder.Entity("MemberPro.Core.Entities.Members.MemberAchievement", b =>
                {
                    b.HasOne("MemberPro.Core.Entities.Achievements.Achievement", "Achievement")
                        .WithMany()
                        .HasForeignKey("AchievementId")
                        .HasConstraintName("fk_member_achievement_achievement_achievement_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MemberPro.Core.Entities.Members.Member", "ApprovedByMember")
                        .WithMany()
                        .HasForeignKey("ApprovedByMemberId")
                        .HasConstraintName("fk_member_achievement_member_approved_by_member_id");

                    b.HasOne("MemberPro.Core.Entities.Members.Member", "Member")
                        .WithMany("Achievements")
                        .HasForeignKey("MemberId")
                        .HasConstraintName("fk_member_achievement_member_member_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Achievement");

                    b.Navigation("ApprovedByMember");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("MemberPro.Core.Entities.Members.MemberAchievementProgress", b =>
                {
                    b.HasOne("MemberPro.Core.Entities.Achievements.Achievement", "Achievement")
                        .WithMany()
                        .HasForeignKey("AchievementId")
                        .HasConstraintName("fk_member_achievement_progress_achievement_achievement_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MemberPro.Core.Entities.Members.Member", "Member")
                        .WithMany("AchievementProgressRecords")
                        .HasForeignKey("MemberId")
                        .HasConstraintName("fk_member_achievement_progress_member_member_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Achievement");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("MemberPro.Core.Entities.Members.MemberCustomFieldValue", b =>
                {
                    b.HasOne("MemberPro.Core.Entities.Members.CustomField", "Field")
                        .WithMany()
                        .HasForeignKey("FieldId")
                        .HasConstraintName("fk_member_custom_field_value_custom_field_field_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MemberPro.Core.Entities.Members.Member", "Member")
                        .WithMany("FieldValues")
                        .HasForeignKey("MemberId")
                        .HasConstraintName("fk_member_custom_field_value_member_member_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Field");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("MemberPro.Core.Entities.Members.MemberRenewal", b =>
                {
                    b.HasOne("MemberPro.Core.Entities.Members.Member", "Member")
                        .WithMany("Renewals")
                        .HasForeignKey("MemberId")
                        .HasConstraintName("fk_member_renewal_member_member_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MemberPro.Core.Entities.Plans.MembershipPlan", "Plan")
                        .WithMany()
                        .HasForeignKey("PlanId")
                        .HasConstraintName("fk_member_renewal_membership_plan_plan_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");

                    b.Navigation("Plan");
                });

            modelBuilder.Entity("MemberPro.Core.Entities.Achievements.Achievement", b =>
                {
                    b.Navigation("Steps");
                });

            modelBuilder.Entity("MemberPro.Core.Entities.Geography.Country", b =>
                {
                    b.Navigation("StateProvinces");
                });

            modelBuilder.Entity("MemberPro.Core.Entities.Geography.Region", b =>
                {
                    b.Navigation("Divisions");
                });

            modelBuilder.Entity("MemberPro.Core.Entities.Members.Member", b =>
                {
                    b.Navigation("AchievementProgressRecords");

                    b.Navigation("Achievements");

                    b.Navigation("FieldValues");

                    b.Navigation("Renewals");
                });
#pragma warning restore 612, 618
        }
    }
}
