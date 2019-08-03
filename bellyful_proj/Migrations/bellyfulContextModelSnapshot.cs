﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bellyful_proj.Models;

namespace bellyful_proj.Migrations
{
    [DbContext(typeof(bellyfulContext))]
    partial class bellyfulContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("bellyful_proj.Models.Batch", b =>
                {
                    b.Property<int>("BatchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("batch_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddAmount")
                        .HasColumnName("add_amount");

                    b.Property<byte>("MealTypeId")
                        .HasColumnName("meal_type_id");

                    b.Property<DateTime>("ProductionDate")
                        .HasColumnName("production_date")
                        .HasColumnType("date");

                    b.HasKey("BatchId");

                    b.HasIndex("MealTypeId");

                    b.ToTable("batch");
                });

            modelBuilder.Entity("bellyful_proj.Models.Branch", b =>
                {
                    b.Property<int>("BranchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("branch_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressNumStreet")
                        .HasColumnName("address_num_street")
                        .HasMaxLength(55)
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("PhoneNumber")
                        .HasColumnName("phone_number")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("TownCity")
                        .HasColumnName("town_city")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("BranchId");

                    b.ToTable("branch");
                });

            modelBuilder.Entity("bellyful_proj.Models.DietaryRequirement", b =>
                {
                    b.Property<byte>("DietaryRequirementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("dietary_requirement_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasMaxLength(125)
                        .IsUnicode(false);

                    b.Property<string>("DietaryName")
                        .IsRequired()
                        .HasColumnName("dietary_name")
                        .HasMaxLength(55)
                        .IsUnicode(false);

                    b.Property<string>("MatchedSetMeal")
                        .HasColumnName("matched_set_meal")
                        .HasMaxLength(125)
                        .IsUnicode(false);

                    b.HasKey("DietaryRequirementId");

                    b.ToTable("dietary_requirement");
                });

            modelBuilder.Entity("bellyful_proj.Models.MealInstock", b =>
                {
                    b.Property<byte>("MealTypeId")
                        .HasColumnName("meal_type_id");

                    b.Property<int>("InstockAmount")
                        .HasColumnName("instock_amount");

                    b.HasKey("MealTypeId");

                    b.ToTable("meal_instock");
                });

            modelBuilder.Entity("bellyful_proj.Models.MealType", b =>
                {
                    b.Property<byte>("MealTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("meal_type_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MealTypeName")
                        .IsRequired()
                        .HasColumnName("meal_type_name")
                        .HasMaxLength(35)
                        .IsUnicode(false);

                    b.Property<string>("ShelfLocation")
                        .IsRequired()
                        .HasColumnName("shelf_location")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    b.HasKey("MealTypeId");

                    b.ToTable("meal_type");
                });

            modelBuilder.Entity("bellyful_proj.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("order_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AssignDatetime")
                        .HasColumnName("assign_datetime")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("CreatedDatetime")
                        .HasColumnName("created_datetime")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DeliveredDatetime")
                        .HasColumnName("delivered_datetime")
                        .HasColumnType("datetime");

                    b.Property<int?>("DeliveryMan")
                        .HasColumnName("delivery_man");

                    b.Property<DateTime?>("PickupDatetime")
                        .HasColumnName("pickup_datetime")
                        .HasColumnType("datetime");

                    b.Property<int>("RecipientId")
                        .HasColumnName("recipient_id");

                    b.Property<byte?>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("status_id")
                        .HasDefaultValueSql("((1))");

                    b.HasKey("OrderId");

                    b.HasIndex("DeliveryMan");

                    b.HasIndex("RecipientId");

                    b.HasIndex("StatusId");

                    b.ToTable("order");
                });

            modelBuilder.Entity("bellyful_proj.Models.OrderStatus", b =>
                {
                    b.Property<byte>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("status_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnName("content")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.HasKey("StatusId");

                    b.ToTable("order_status");
                });

            modelBuilder.Entity("bellyful_proj.Models.Recipient", b =>
                {
                    b.Property<int>("RecipientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("recipient_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdditionalInfo")
                        .HasColumnName("additional_info")
                        .HasMaxLength(2555)
                        .IsUnicode(false);

                    b.Property<string>("AddressNumStreet")
                        .IsRequired()
                        .HasColumnName("address_num_street")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<byte>("AdultsNum")
                        .HasColumnName("adults_num");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnName("created_date")
                        .HasColumnType("datetime");

                    b.Property<byte?>("DietaryRequirement")
                        .HasColumnName("dietary_requirement");

                    b.Property<byte?>("DogOnProperty")
                        .HasColumnName("dog_on_property");

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasMaxLength(55)
                        .IsUnicode(false);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("first_name")
                        .HasMaxLength(55)
                        .IsUnicode(false);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("last_name")
                        .HasMaxLength(55)
                        .IsUnicode(false);

                    b.Property<int>("NearestBranch")
                        .HasColumnName("nearest_branch");

                    b.Property<string>("OtherAllergyInfo")
                        .HasColumnName("other_allergy_info")
                        .HasMaxLength(2555)
                        .IsUnicode(false);

                    b.Property<string>("OtherReferralInfo")
                        .HasColumnName("other_referral_info")
                        .HasMaxLength(2555)
                        .IsUnicode(false);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnName("phone_number")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<int?>("Postcode")
                        .HasColumnName("postcode");

                    b.Property<byte>("ReferralReason")
                        .HasColumnName("referral_reason");

                    b.Property<int?>("ReferrerId")
                        .HasColumnName("referrer_id");

                    b.Property<string>("TownCity")
                        .IsRequired()
                        .HasColumnName("town_city")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<byte>("Under5ChildrenNum")
                        .HasColumnName("under5_children_num");

                    b.Property<byte>("_1117ChildrenNum")
                        .HasColumnName("11-17_children_num");

                    b.Property<byte>("_510ChildrenNum")
                        .HasColumnName("5-10_children_num");

                    b.HasKey("RecipientId");

                    b.HasIndex("DietaryRequirement");

                    b.HasIndex("NearestBranch");

                    b.HasIndex("ReferralReason");

                    b.HasIndex("ReferrerId");

                    b.HasIndex("FirstName", "LastName", "AddressNumStreet")
                        .IsUnique()
                        .HasName("UQ__recipien__0D43C48AFDB8656A");

                    b.ToTable("recipient");
                });

            modelBuilder.Entity("bellyful_proj.Models.ReferralReason", b =>
                {
                    b.Property<byte>("ReferralReasonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("referral_reason_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnName("content")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.HasKey("ReferralReasonId");

                    b.ToTable("referral_reason");
                });

            modelBuilder.Entity("bellyful_proj.Models.Referrer", b =>
                {
                    b.Property<int>("ReferrerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("referrer_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasMaxLength(55)
                        .IsUnicode(false);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("first_name")
                        .HasMaxLength(55)
                        .IsUnicode(false);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("last_name")
                        .HasMaxLength(55)
                        .IsUnicode(false);

                    b.Property<string>("OrganisationName")
                        .HasColumnName("organisation_name")
                        .HasMaxLength(55)
                        .IsUnicode(false);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnName("phone_number")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<byte>("ReferringAs");

                    b.Property<string>("TownCity")
                        .HasColumnName("town_city")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("ReferrerId");

                    b.HasIndex("ReferringAs");

                    b.HasIndex("FirstName", "LastName", "OrganisationName")
                        .IsUnique()
                        .HasName("UQ__referrer__21BE543F23B4F753")
                        .HasFilter("[organisation_name] IS NOT NULL");

                    b.ToTable("referrer");
                });

            modelBuilder.Entity("bellyful_proj.Models.ReferrerRole", b =>
                {
                    b.Property<byte>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("role_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnName("role_name")
                        .HasMaxLength(35)
                        .IsUnicode(false);

                    b.HasKey("RoleId");

                    b.ToTable("referrer_role");
                });

            modelBuilder.Entity("bellyful_proj.Models.Volunteer", b =>
                {
                    b.Property<int>("VolunteerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("volunteer_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnName("address")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("AlternativePhone")
                        .HasColumnName("alternative_phone")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<int?>("BranchBelonged")
                        .HasColumnName("branch_belonged");

                    b.Property<DateTime>("Dob")
                        .HasColumnName("DOB")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasMaxLength(55)
                        .IsUnicode(false);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("first_name")
                        .HasMaxLength(55)
                        .IsUnicode(false);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("last_name")
                        .HasMaxLength(55)
                        .IsUnicode(false);

                    b.Property<string>("PostCode")
                        .HasColumnName("post_code")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("PreferredPhone")
                        .IsRequired()
                        .HasColumnName("preferred_phone")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<byte?>("RoleId")
                        .HasColumnName("role_id");

                    b.Property<byte?>("StatusId")
                        .HasColumnName("status_id");

                    b.Property<string>("TownCity")
                        .IsRequired()
                        .HasColumnName("town_city")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.HasKey("VolunteerId");

                    b.HasIndex("BranchBelonged");

                    b.HasIndex("RoleId");

                    b.HasIndex("StatusId");

                    b.HasIndex("FirstName", "LastName", "Dob")
                        .IsUnique()
                        .HasName("UQ__voluntee__5846F7A1B4C45AA3");

                    b.ToTable("volunteer");
                });

            modelBuilder.Entity("bellyful_proj.Models.VolunteerEmergencyContact", b =>
                {
                    b.Property<int>("VolunteerId")
                        .HasColumnName("volunteer_id");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("first_name")
                        .HasMaxLength(55)
                        .IsUnicode(false);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("last_name")
                        .HasMaxLength(55)
                        .IsUnicode(false);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnName("phone_number")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("Relationship")
                        .IsRequired()
                        .HasColumnName("relationship")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("VolunteerId");

                    b.ToTable("volunteer_emergency_contact");
                });

            modelBuilder.Entity("bellyful_proj.Models.VolunteerPoliceInfo", b =>
                {
                    b.Property<int>("VolunteerId")
                        .HasColumnName("volunteer_id");

                    b.Property<DateTime>("PoliceVetDate")
                        .HasColumnName("police_vet_date")
                        .HasColumnType("date");

                    b.Property<byte>("PoliceVetVerified")
                        .HasColumnName("police_vet_verified");

                    b.HasKey("VolunteerId");

                    b.ToTable("volunteer_police_info");
                });

            modelBuilder.Entity("bellyful_proj.Models.VolunteerRole", b =>
                {
                    b.Property<byte>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("role_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnName("role_name")
                        .HasMaxLength(35)
                        .IsUnicode(false);

                    b.HasKey("RoleId");

                    b.ToTable("volunteer_role");
                });

            modelBuilder.Entity("bellyful_proj.Models.VolunteerStatus", b =>
                {
                    b.Property<byte>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("status_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnName("content")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.HasKey("StatusId");

                    b.ToTable("volunteer_status");
                });

            modelBuilder.Entity("bellyful_proj.Models.VolunteerTrainingInfo", b =>
                {
                    b.Property<int>("VolunteerId")
                        .HasColumnName("volunteer_id");

                    b.Property<byte>("DeliveryTraining")
                        .HasColumnName("delivery_training");

                    b.Property<byte>("FirstAidRaining")
                        .HasColumnName("first_aid_raining");

                    b.Property<byte>("HSTraining")
                        .HasColumnName("H&S_training");

                    b.Property<string>("OtherTrainingSkill")
                        .HasColumnName("other_training_skill")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.HasKey("VolunteerId");

                    b.ToTable("volunteer_training_info");
                });

            modelBuilder.Entity("bellyful_proj.Models.Batch", b =>
                {
                    b.HasOne("bellyful_proj.Models.MealType", "MealType")
                        .WithMany("Batch")
                        .HasForeignKey("MealTypeId")
                        .HasConstraintName("a batch has a meal type")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("bellyful_proj.Models.MealInstock", b =>
                {
                    b.HasOne("bellyful_proj.Models.MealType", "MealType")
                        .WithOne("MealInstock")
                        .HasForeignKey("bellyful_proj.Models.MealInstock", "MealTypeId")
                        .HasConstraintName("one meal type has one instock")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("bellyful_proj.Models.Order", b =>
                {
                    b.HasOne("bellyful_proj.Models.Volunteer", "DeliveryManNavigation")
                        .WithMany("Order")
                        .HasForeignKey("DeliveryMan")
                        .HasConstraintName("an order can assign a volunteer as delivery man");

                    b.HasOne("bellyful_proj.Models.Recipient", "Recipient")
                        .WithMany("Order")
                        .HasForeignKey("RecipientId")
                        .HasConstraintName("an order has a recipient");

                    b.HasOne("bellyful_proj.Models.OrderStatus", "Status")
                        .WithMany("Order")
                        .HasForeignKey("StatusId")
                        .HasConstraintName("every order has a status");
                });

            modelBuilder.Entity("bellyful_proj.Models.Recipient", b =>
                {
                    b.HasOne("bellyful_proj.Models.DietaryRequirement", "DietaryRequirementNavigation")
                        .WithMany("Recipient")
                        .HasForeignKey("DietaryRequirement")
                        .HasConstraintName("Recipient has a requirement");

                    b.HasOne("bellyful_proj.Models.Branch", "NearestBranchNavigation")
                        .WithMany("Recipient")
                        .HasForeignKey("NearestBranch")
                        .HasConstraintName("Recipient belones to a Branch");

                    b.HasOne("bellyful_proj.Models.ReferralReason", "ReferralReasonNavigation")
                        .WithMany("Recipient")
                        .HasForeignKey("ReferralReason")
                        .HasConstraintName("Recipient has a Reason");

                    b.HasOne("bellyful_proj.Models.Referrer", "Referrer")
                        .WithMany("Recipient")
                        .HasForeignKey("ReferrerId")
                        .HasConstraintName("Recipient has/not has a Referrer")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("bellyful_proj.Models.Referrer", b =>
                {
                    b.HasOne("bellyful_proj.Models.ReferrerRole", "ReferringAsNavigation")
                        .WithMany("Referrer")
                        .HasForeignKey("ReferringAs")
                        .HasConstraintName("Referrer has/not has a role");
                });

            modelBuilder.Entity("bellyful_proj.Models.Volunteer", b =>
                {
                    b.HasOne("bellyful_proj.Models.Branch", "BranchBelongedNavigation")
                        .WithMany("Volunteer")
                        .HasForeignKey("BranchBelonged")
                        .HasConstraintName("a volunteer belones to a branch");

                    b.HasOne("bellyful_proj.Models.VolunteerRole", "Role")
                        .WithMany("Volunteer")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("a volunteer has a role");

                    b.HasOne("bellyful_proj.Models.VolunteerStatus", "Status")
                        .WithMany("Volunteer")
                        .HasForeignKey("StatusId")
                        .HasConstraintName("a volunteer has a status");
                });

            modelBuilder.Entity("bellyful_proj.Models.VolunteerEmergencyContact", b =>
                {
                    b.HasOne("bellyful_proj.Models.Volunteer", "Volunteer")
                        .WithOne("VolunteerEmergencyContact")
                        .HasForeignKey("bellyful_proj.Models.VolunteerEmergencyContact", "VolunteerId")
                        .HasConstraintName("a volunteer has a emergency contact");
                });

            modelBuilder.Entity("bellyful_proj.Models.VolunteerPoliceInfo", b =>
                {
                    b.HasOne("bellyful_proj.Models.Volunteer", "Volunteer")
                        .WithOne("VolunteerPoliceInfo")
                        .HasForeignKey("bellyful_proj.Models.VolunteerPoliceInfo", "VolunteerId")
                        .HasConstraintName("a volunteer has a police info");
                });

            modelBuilder.Entity("bellyful_proj.Models.VolunteerTrainingInfo", b =>
                {
                    b.HasOne("bellyful_proj.Models.Volunteer", "Volunteer")
                        .WithOne("VolunteerTrainingInfo")
                        .HasForeignKey("bellyful_proj.Models.VolunteerTrainingInfo", "VolunteerId")
                        .HasConstraintName("a voluteer has a train info");
                });
#pragma warning restore 612, 618
        }
    }
}
