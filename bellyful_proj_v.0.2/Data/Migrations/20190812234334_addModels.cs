﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace bellyful_proj_v._0._2.Data.Migrations
{
    public partial class addModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "branch",
                columns: table => new
                {
                    branch_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    phone_number = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
                    address_num_street = table.Column<string>(unicode: false, maxLength: 55, nullable: true),
                    town_city = table.Column<string>(unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_branch", x => x.branch_id);
                });

            migrationBuilder.CreateTable(
                name: "dietary_requirement",
                columns: table => new
                {
                    dietary_requirement_id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    dietary_name = table.Column<string>(unicode: false, maxLength: 55, nullable: false),
                    matched_set_meal = table.Column<string>(unicode: false, maxLength: 125, nullable: true),
                    description = table.Column<string>(unicode: false, maxLength: 125, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dietary_requirement", x => x.dietary_requirement_id);
                });

            migrationBuilder.CreateTable(
                name: "meal_type",
                columns: table => new
                {
                    meal_type_id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    meal_type_name = table.Column<string>(unicode: false, maxLength: 35, nullable: false),
                    shelf_location = table.Column<string>(unicode: false, maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_meal_type", x => x.meal_type_id);
                });

            migrationBuilder.CreateTable(
                name: "order_status",
                columns: table => new
                {
                    status_id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    content = table.Column<string>(unicode: false, maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order_status", x => x.status_id);
                });

            migrationBuilder.CreateTable(
                name: "referral_reason",
                columns: table => new
                {
                    referral_reason_id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    content = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_referral_reason", x => x.referral_reason_id);
                });

            migrationBuilder.CreateTable(
                name: "referrer_role",
                columns: table => new
                {
                    role_id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    role_name = table.Column<string>(unicode: false, maxLength: 35, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_referrer_role", x => x.role_id);
                });

            migrationBuilder.CreateTable(
                name: "volunteer_role",
                columns: table => new
                {
                    role_id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    role_name = table.Column<string>(unicode: false, maxLength: 35, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_volunteer_role", x => x.role_id);
                });

            migrationBuilder.CreateTable(
                name: "volunteer_status",
                columns: table => new
                {
                    status_id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    content = table.Column<string>(unicode: false, maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_volunteer_status", x => x.status_id);
                });

            migrationBuilder.CreateTable(
                name: "batch",
                columns: table => new
                {
                    batch_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    add_amount = table.Column<int>(nullable: false),
                    production_date = table.Column<DateTime>(type: "date", nullable: false),
                    meal_type_id = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_batch", x => x.batch_id);
                    table.ForeignKey(
                        name: "a batch has a meal type",
                        column: x => x.meal_type_id,
                        principalTable: "meal_type",
                        principalColumn: "meal_type_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "meal_instock",
                columns: table => new
                {
                    meal_type_id = table.Column<byte>(nullable: false),
                    instock_amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_meal_instock", x => x.meal_type_id);
                    table.ForeignKey(
                        name: "one meal type has one instock",
                        column: x => x.meal_type_id,
                        principalTable: "meal_type",
                        principalColumn: "meal_type_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "referrer",
                columns: table => new
                {
                    referrer_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    first_name = table.Column<string>(unicode: false, maxLength: 55, nullable: false),
                    last_name = table.Column<string>(unicode: false, maxLength: 55, nullable: false),
                    organisation_name = table.Column<string>(unicode: false, maxLength: 55, nullable: true),
                    phone_number = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    email = table.Column<string>(unicode: false, maxLength: 55, nullable: true),
                    town_city = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ReferringAs = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_referrer", x => x.referrer_id);
                    table.ForeignKey(
                        name: "Referrer has/not has a role",
                        column: x => x.ReferringAs,
                        principalTable: "referrer_role",
                        principalColumn: "role_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "volunteer",
                columns: table => new
                {
                    volunteer_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    first_name = table.Column<string>(unicode: false, maxLength: 55, nullable: false),
                    last_name = table.Column<string>(unicode: false, maxLength: 55, nullable: false),
                    DOB = table.Column<DateTime>(type: "date", nullable: false),
                    email = table.Column<string>(unicode: false, maxLength: 55, nullable: false),
                    preferred_phone = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    alternative_phone = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
                    address = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    town_city = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    post_code = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    status_id = table.Column<byte>(nullable: true),
                    branch_belonged = table.Column<int>(nullable: true),
                    role_id = table.Column<byte>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_volunteer", x => x.volunteer_id);
                    table.ForeignKey(
                        name: "a volunteer belones to a branch",
                        column: x => x.branch_belonged,
                        principalTable: "branch",
                        principalColumn: "branch_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "a volunteer has a role",
                        column: x => x.role_id,
                        principalTable: "volunteer_role",
                        principalColumn: "role_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "a volunteer has a status",
                        column: x => x.status_id,
                        principalTable: "volunteer_status",
                        principalColumn: "status_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "recipient",
                columns: table => new
                {
                    recipient_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    first_name = table.Column<string>(unicode: false, maxLength: 55, nullable: false),
                    last_name = table.Column<string>(unicode: false, maxLength: 55, nullable: false),
                    address_num_street = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    town_city = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    postcode = table.Column<int>(nullable: true),
                    phone_number = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    email = table.Column<string>(unicode: false, maxLength: 55, nullable: true),
                    dog_on_property = table.Column<byte>(nullable: true),
                    nearest_branch = table.Column<int>(nullable: false),
                    referral_reason = table.Column<byte>(nullable: false),
                    other_referral_info = table.Column<string>(unicode: false, maxLength: 2555, nullable: true),
                    adults_num = table.Column<byte>(nullable: false),
                    under5_children_num = table.Column<byte>(nullable: false),
                    _510_children_num = table.Column<byte>(name: "5-10_children_num", nullable: false),
                    _1117_children_num = table.Column<byte>(name: "11-17_children_num", nullable: false),
                    dietary_requirement = table.Column<byte>(nullable: true),
                    other_allergy_info = table.Column<string>(unicode: false, maxLength: 2555, nullable: true),
                    additional_info = table.Column<string>(unicode: false, maxLength: 2555, nullable: true),
                    referrer_id = table.Column<int>(nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recipient", x => x.recipient_id);
                    table.ForeignKey(
                        name: "Recipient has a requirement",
                        column: x => x.dietary_requirement,
                        principalTable: "dietary_requirement",
                        principalColumn: "dietary_requirement_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Recipient belones to a Branch",
                        column: x => x.nearest_branch,
                        principalTable: "branch",
                        principalColumn: "branch_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Recipient has a Reason",
                        column: x => x.referral_reason,
                        principalTable: "referral_reason",
                        principalColumn: "referral_reason_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Recipient has/not has a Referrer",
                        column: x => x.referrer_id,
                        principalTable: "referrer",
                        principalColumn: "referrer_id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "volunteer_emergency_contact",
                columns: table => new
                {
                    volunteer_id = table.Column<int>(nullable: false),
                    first_name = table.Column<string>(unicode: false, maxLength: 55, nullable: false),
                    last_name = table.Column<string>(unicode: false, maxLength: 55, nullable: false),
                    phone_number = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    relationship = table.Column<string>(unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_volunteer_emergency_contact", x => x.volunteer_id);
                    table.ForeignKey(
                        name: "a volunteer has a emergency contact",
                        column: x => x.volunteer_id,
                        principalTable: "volunteer",
                        principalColumn: "volunteer_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "volunteer_police_info",
                columns: table => new
                {
                    volunteer_id = table.Column<int>(nullable: false),
                    police_vet_date = table.Column<DateTime>(type: "date", nullable: false),
                    police_vet_verified = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_volunteer_police_info", x => x.volunteer_id);
                    table.ForeignKey(
                        name: "a volunteer has a police info",
                        column: x => x.volunteer_id,
                        principalTable: "volunteer",
                        principalColumn: "volunteer_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "volunteer_training_info",
                columns: table => new
                {
                    volunteer_id = table.Column<int>(nullable: false),
                    delivery_training = table.Column<byte>(nullable: false),
                    HS_training = table.Column<byte>(name: "H&S_training", nullable: false),
                    first_aid_raining = table.Column<byte>(nullable: false),
                    other_training_skill = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_volunteer_training_info", x => x.volunteer_id);
                    table.ForeignKey(
                        name: "a voluteer has a train info",
                        column: x => x.volunteer_id,
                        principalTable: "volunteer",
                        principalColumn: "volunteer_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "order",
                columns: table => new
                {
                    order_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    status_id = table.Column<byte>(nullable: true, defaultValueSql: "((1))"),
                    delivery_man = table.Column<int>(nullable: true),
                    recipient_id = table.Column<int>(nullable: false),
                    created_datetime = table.Column<DateTime>(type: "datetime", nullable: true),
                    assign_datetime = table.Column<DateTime>(type: "datetime", nullable: true),
                    pickup_datetime = table.Column<DateTime>(type: "datetime", nullable: true),
                    delivered_datetime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order", x => x.order_id);
                    table.ForeignKey(
                        name: "an order can assign a volunteer as delivery man",
                        column: x => x.delivery_man,
                        principalTable: "volunteer",
                        principalColumn: "volunteer_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "an order has a recipient",
                        column: x => x.recipient_id,
                        principalTable: "recipient",
                        principalColumn: "recipient_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "every order has a status",
                        column: x => x.status_id,
                        principalTable: "order_status",
                        principalColumn: "status_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_batch_meal_type_id",
                table: "batch",
                column: "meal_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_order_delivery_man",
                table: "order",
                column: "delivery_man");

            migrationBuilder.CreateIndex(
                name: "IX_order_recipient_id",
                table: "order",
                column: "recipient_id");

            migrationBuilder.CreateIndex(
                name: "IX_order_status_id",
                table: "order",
                column: "status_id");

            migrationBuilder.CreateIndex(
                name: "IX_recipient_dietary_requirement",
                table: "recipient",
                column: "dietary_requirement");

            migrationBuilder.CreateIndex(
                name: "IX_recipient_nearest_branch",
                table: "recipient",
                column: "nearest_branch");

            migrationBuilder.CreateIndex(
                name: "IX_recipient_referral_reason",
                table: "recipient",
                column: "referral_reason");

            migrationBuilder.CreateIndex(
                name: "IX_recipient_referrer_id",
                table: "recipient",
                column: "referrer_id");

            migrationBuilder.CreateIndex(
                name: "UQ__recipien__0D43C48AFDB8656A",
                table: "recipient",
                columns: new[] { "first_name", "last_name", "address_num_street" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_referrer_ReferringAs",
                table: "referrer",
                column: "ReferringAs");

            migrationBuilder.CreateIndex(
                name: "UQ__referrer__21BE543F23B4F753",
                table: "referrer",
                columns: new[] { "first_name", "last_name", "organisation_name" },
                unique: true,
                filter: "[organisation_name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_volunteer_branch_belonged",
                table: "volunteer",
                column: "branch_belonged");

            migrationBuilder.CreateIndex(
                name: "IX_volunteer_role_id",
                table: "volunteer",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "IX_volunteer_status_id",
                table: "volunteer",
                column: "status_id");

            migrationBuilder.CreateIndex(
                name: "UQ__voluntee__5846F7A1B4C45AA3",
                table: "volunteer",
                columns: new[] { "first_name", "last_name", "DOB" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "batch");

            migrationBuilder.DropTable(
                name: "meal_instock");

            migrationBuilder.DropTable(
                name: "order");

            migrationBuilder.DropTable(
                name: "volunteer_emergency_contact");

            migrationBuilder.DropTable(
                name: "volunteer_police_info");

            migrationBuilder.DropTable(
                name: "volunteer_training_info");

            migrationBuilder.DropTable(
                name: "meal_type");

            migrationBuilder.DropTable(
                name: "recipient");

            migrationBuilder.DropTable(
                name: "order_status");

            migrationBuilder.DropTable(
                name: "volunteer");

            migrationBuilder.DropTable(
                name: "dietary_requirement");

            migrationBuilder.DropTable(
                name: "referral_reason");

            migrationBuilder.DropTable(
                name: "referrer");

            migrationBuilder.DropTable(
                name: "branch");

            migrationBuilder.DropTable(
                name: "volunteer_role");

            migrationBuilder.DropTable(
                name: "volunteer_status");

            migrationBuilder.DropTable(
                name: "referrer_role");
        }
    }
}
