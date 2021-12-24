using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class ProjectDbStart1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branchs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Explanation = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    parentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branchs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Explanation = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    parentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jops", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeftMenu",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Src = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    MenuId = table.Column<short>(type: "smallint", nullable: true),
                    MenuIndex = table.Column<short>(type: "smallint", nullable: true),
                    ImageUrl = table.Column<string>(type: "varchar(1500)", unicode: false, maxLength: 1500, nullable: true),
                    ImageUrl2 = table.Column<string>(type: "varchar(1500)", unicode: false, maxLength: 1500, nullable: true),
                    OnClick = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    AccessRank = table.Column<short>(type: "smallint", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Left_Menu", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Matchs",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Explanation = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matchs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Explanation = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PerformanceAims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Explanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerformanceAims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PerformancePeriots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Explanation = table.Column<short>(type: "smallint", maxLength: 50, nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerformancePeriots", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PerformanceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Explanation = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerformanceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Periots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    StartYear = table.Column<int>(type: "int", nullable: false),
                    StopYear = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Periots", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefreshToken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsUsing = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshToken", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SurveyStatu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Statu = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyStatu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLeftMenuClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperationClaimId = table.Column<int>(type: "int", nullable: false),
                    LeftMenuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLeftMenuClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserLeftMenuClaims_OperationClaims_OperationClaimId",
                        column: x => x.OperationClaimId,
                        principalTable: "OperationClaims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(100)", maxLength: 100, nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    JopId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenId = table.Column<int>(type: "int", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Jops_JopId",
                        column: x => x.JopId,
                        principalTable: "Jops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActionPrices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PeriotId = table.Column<int>(type: "int", nullable: false),
                    MatchId = table.Column<int>(type: "int", nullable: false),
                    ActionId = table.Column<int>(type: "int", nullable: false),
                    TargetValue = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    ResultValue = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    OrganizationId = table.Column<int>(type: "int", nullable: true),
                    MatchId1 = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionPrices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActionPrices_Matchs_MatchId1",
                        column: x => x.MatchId1,
                        principalTable: "Matchs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ActionPrices_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ActionPrices_Periots_PeriotId",
                        column: x => x.PeriotId,
                        principalTable: "Periots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Aims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Explanation = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PeriotId = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aims_Periots_PeriotId",
                        column: x => x.PeriotId,
                        principalTable: "Periots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Performances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Explanation = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    PeriotId = table.Column<int>(type: "int", nullable: false),
                    PerformancePeriotId = table.Column<int>(type: "int", nullable: false),
                    PerformanceTypeId = table.Column<int>(type: "int", nullable: false),
                    PerformanceAimId = table.Column<int>(type: "int", nullable: false),
                    StartYear = table.Column<int>(type: "int", nullable: false),
                    StopYear = table.Column<int>(type: "int", nullable: false),
                    StartMonth = table.Column<int>(type: "int", nullable: false),
                    StartDay = table.Column<int>(type: "int", nullable: false),
                    BaseValue = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    TargetValue = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Performances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Performances_PerformanceAims_PerformanceAimId",
                        column: x => x.PerformanceAimId,
                        principalTable: "PerformanceAims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Performances_PerformancePeriots_PerformancePeriotId",
                        column: x => x.PerformancePeriotId,
                        principalTable: "PerformancePeriots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Performances_PerformanceTypes_PerformanceTypeId",
                        column: x => x.PerformanceTypeId,
                        principalTable: "PerformanceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Performances_Periots_PeriotId",
                        column: x => x.PeriotId,
                        principalTable: "Periots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "(newid())"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PeriotId = table.Column<int>(type: "int", nullable: false),
                    SuccesCount = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    IsSuccess = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StopTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Periots_PeriotId",
                        column: x => x.PeriotId,
                        principalTable: "Periots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserOperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    OperationClaimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOperationClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserOperationClaims_OperationClaims_OperationClaimId",
                        column: x => x.OperationClaimId,
                        principalTable: "OperationClaims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserOperationClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Targets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TargetId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(700)", maxLength: 700, nullable: true),
                    AimId = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Targets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Targets_Aims_AimId",
                        column: x => x.AimId,
                        principalTable: "Aims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Performance_Target_Results",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PerformanceId = table.Column<int>(type: "int", nullable: false),
                    PerformanceMatchId = table.Column<int>(type: "int", nullable: false),
                    Target = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Result = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Explanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    TargetTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Performance_Target_Results", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Performance_Target_Results_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Performance_Target_Results_Performances_PerformanceId",
                        column: x => x.PerformanceId,
                        principalTable: "Performances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PerformanceMatchTargets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PerformanceId = table.Column<int>(type: "int", nullable: false),
                    MatchId = table.Column<short>(type: "smallint", nullable: false),
                    TargetId = table.Column<int>(type: "int", nullable: false),
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerformanceMatchTargets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PerformanceMatchTargets_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PerformanceMatchTargets_Performances_PerformanceId",
                        column: x => x.PerformanceId,
                        principalTable: "Performances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Text = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Index = table.Column<int>(type: "int", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Actions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(700)", maxLength: 700, nullable: true),
                    TargetId = table.Column<int>(type: "int", nullable: false),
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Actions_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Actions_Targets_TargetId",
                        column: x => x.TargetId,
                        principalTable: "Targets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestionHorizontals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    ColumnName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    Text = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Index = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionHorizontals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionHorizontals_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestionVerticals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    ColumnName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    Text = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Index = table.Column<short>(type: "smallint", nullable: true),
                    Value = table.Column<short>(type: "smallint", nullable: true),
                    IsOpen = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Point = table.Column<decimal>(type: "decimal(9,4)", precision: 9, scale: 4, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionVerticals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionVerticals_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubActions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubActionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(700)", maxLength: 700, nullable: true),
                    ActionId = table.Column<int>(type: "int", nullable: false),
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubActions_Actions_ActionId",
                        column: x => x.ActionId,
                        principalTable: "Actions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Branchs",
                columns: new[] { "Id", "Explanation", "parentId" },
                values: new object[] { 1, "IT", null });

            migrationBuilder.InsertData(
                table: "Jops",
                columns: new[] { "Id", "Explanation", "parentId" },
                values: new object[] { 1, "Genel Müdür", null });

            migrationBuilder.InsertData(
                table: "LeftMenu",
                columns: new[] { "Id", "AccessRank", "Description", "ImageUrl", "ImageUrl2", "MenuId", "MenuIndex", "OnClick", "Src" },
                values: new object[] { (short)1, null, "Kullanıcı İşlemleri", "fa fa-user", null, (short)0, null, null, "/user" });

            migrationBuilder.InsertData(
                table: "Matchs",
                columns: new[] { "Id", "Explanation" },
                values: new object[,]
                {
                    { (short)1, "Hedef" },
                    { (short)2, "Faaliyet" },
                    { (short)3, "Alt Faaliyet" }
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Admin" });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Explanation", "ParentId" },
                values: new object[] { 1, "IT", null });

            migrationBuilder.InsertData(
                table: "PerformanceAims",
                columns: new[] { "Id", "Explanation", "InsertTime" },
                values: new object[,]
                {
                    { 5, "Yüzdesel Artış", null },
                    { 4, "Rakamsal Azalış", null },
                    { 2, "Rakamsal Artış", null },
                    { 1, "Yüzdesel Artış", null },
                    { 3, "Eşit", null }
                });

            migrationBuilder.InsertData(
                table: "PerformancePeriots",
                columns: new[] { "Id", "Explanation" },
                values: new object[,]
                {
                    { 8, (short)8 },
                    { 12, (short)12 },
                    { 11, (short)11 },
                    { 10, (short)10 },
                    { 9, (short)9 },
                    { 7, (short)7 },
                    { 1, (short)1 },
                    { 5, (short)5 },
                    { 4, (short)4 },
                    { 3, (short)3 },
                    { 2, (short)2 },
                    { 6, (short)6 }
                });

            migrationBuilder.InsertData(
                table: "PerformanceTypes",
                columns: new[] { "Id", "Explanation" },
                values: new object[,]
                {
                    { 2, "m2" },
                    { 1, "kg" },
                    { 3, "m3" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BranchId", "Email", "FirstName", "IsActive", "JopId", "LastName", "OrganizationId", "PasswordHash", "PasswordSalt", "RefreshTokenId", "Status", "Telephone", "UserName" },
                values: new object[] { 1, 1, "admin@arastirmaturk.com", "Admin", null, 1, "Admin", 1, new byte[] { 229, 34, 201, 114, 89, 155, 205, 55, 251, 174, 184, 10, 252, 222, 96, 91, 118, 245, 89, 190, 2, 188, 89, 157, 168, 183, 110, 90, 102, 13, 209, 2, 7, 150, 127, 231, 234, 37, 0, 82, 198, 193, 125, 213, 5, 204, 22, 113, 57, 155, 206, 79, 149, 89, 254, 250, 236, 73, 88, 17, 67, 179, 157, 208 }, new byte[] { 254, 73, 57, 153, 36, 224, 46, 87, 62, 159, 213, 94, 26, 33, 79, 229, 44, 129, 189, 215, 212, 109, 7, 176, 35, 215, 225, 58, 9, 42, 166, 1, 227, 131, 201, 171, 38, 30, 136, 119, 38, 55, 222, 244, 187, 246, 177, 64, 35, 240, 175, 176, 218, 25, 113, 170, 205, 11, 108, 198, 167, 114, 80, 247, 101, 43, 176, 126, 94, 105, 219, 20, 74, 97, 92, 238, 154, 168, 40, 181, 67, 181, 223, 26, 41, 55, 87, 209, 106, 21, 92, 58, 252, 137, 152, 172, 243, 233, 164, 91, 245, 158, 133, 161, 26, 213, 0, 104, 213, 184, 52, 220, 100, 201, 83, 58, 21, 151, 2, 232, 212, 129, 77, 169, 37, 109, 146, 14 }, null, true, null, "admin@arastirmaturk.com" });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "OperationClaimId", "UserId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_ActionPrices_MatchId1",
                table: "ActionPrices",
                column: "MatchId1");

            migrationBuilder.CreateIndex(
                name: "IX_ActionPrices_OrganizationId",
                table: "ActionPrices",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_ActionPrices_PeriotId",
                table: "ActionPrices",
                column: "PeriotId");

            migrationBuilder.CreateIndex(
                name: "IX_Actions_OrganizationId",
                table: "Actions",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Actions_TargetId",
                table: "Actions",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_Aims_PeriotId",
                table: "Aims",
                column: "PeriotId");

            migrationBuilder.CreateIndex(
                name: "IX_Performance_Target_Results_OrganizationId",
                table: "Performance_Target_Results",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Performance_Target_Results_PerformanceId",
                table: "Performance_Target_Results",
                column: "PerformanceId");

            migrationBuilder.CreateIndex(
                name: "IX_PerformanceMatchTargets_OrganizationId",
                table: "PerformanceMatchTargets",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_PerformanceMatchTargets_PerformanceId",
                table: "PerformanceMatchTargets",
                column: "PerformanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Performances_PerformanceAimId",
                table: "Performances",
                column: "PerformanceAimId");

            migrationBuilder.CreateIndex(
                name: "IX_Performances_PerformancePeriotId",
                table: "Performances",
                column: "PerformancePeriotId");

            migrationBuilder.CreateIndex(
                name: "IX_Performances_PerformanceTypeId",
                table: "Performances",
                column: "PerformanceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Performances_PeriotId",
                table: "Performances",
                column: "PeriotId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_PeriotId",
                table: "Projects",
                column: "PeriotId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionHorizontals_QuestionId",
                table: "QuestionHorizontals",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ProjectId",
                table: "Questions",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionVerticals_QuestionId",
                table: "QuestionVerticals",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_SubActions_ActionId",
                table: "SubActions",
                column: "ActionId");

            migrationBuilder.CreateIndex(
                name: "IX_Targets_AimId",
                table: "Targets",
                column: "AimId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLeftMenuClaims_OperationClaimId",
                table: "UserLeftMenuClaims",
                column: "OperationClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOperationClaims_OperationClaimId",
                table: "UserOperationClaims",
                column: "OperationClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOperationClaims_UserId",
                table: "UserOperationClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_JopId",
                table: "Users",
                column: "JopId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_OrganizationId",
                table: "Users",
                column: "OrganizationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActionPrices");

            migrationBuilder.DropTable(
                name: "Branchs");

            migrationBuilder.DropTable(
                name: "LeftMenu");

            migrationBuilder.DropTable(
                name: "Performance_Target_Results");

            migrationBuilder.DropTable(
                name: "PerformanceMatchTargets");

            migrationBuilder.DropTable(
                name: "QuestionHorizontals");

            migrationBuilder.DropTable(
                name: "QuestionVerticals");

            migrationBuilder.DropTable(
                name: "RefreshToken");

            migrationBuilder.DropTable(
                name: "SubActions");

            migrationBuilder.DropTable(
                name: "SurveyStatu");

            migrationBuilder.DropTable(
                name: "UserLeftMenuClaims");

            migrationBuilder.DropTable(
                name: "UserOperationClaims");

            migrationBuilder.DropTable(
                name: "Matchs");

            migrationBuilder.DropTable(
                name: "Performances");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Actions");

            migrationBuilder.DropTable(
                name: "OperationClaims");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "PerformanceAims");

            migrationBuilder.DropTable(
                name: "PerformancePeriots");

            migrationBuilder.DropTable(
                name: "PerformanceTypes");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Targets");

            migrationBuilder.DropTable(
                name: "Jops");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "Aims");

            migrationBuilder.DropTable(
                name: "Periots");
        }
    }
}
