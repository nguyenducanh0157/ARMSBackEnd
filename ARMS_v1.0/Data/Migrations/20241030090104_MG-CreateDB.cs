using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class MGCreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campus",
                columns: table => new
                {
                    CampusId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CampusName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    History = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrainingMotto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Achievements = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WhyChooseUs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campus", x => x.CampusId);
                });

            migrationBuilder.CreateTable(
                name: "PriorityDetail",
                columns: table => new
                {
                    PriorityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PriorityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PriorityDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeOfPriority = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriorityDetail", x => x.PriorityID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<bool>(type: "bit", nullable: true),
                    AvatarURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isAccountActive = table.Column<bool>(type: "bit", nullable: false),
                    CampusId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SPId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Account_Campus_CampusId",
                        column: x => x.CampusId,
                        principalTable: "Campus",
                        principalColumn: "CampusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdmissionGroup",
                columns: table => new
                {
                    AdmissionGroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    TotalScore = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalScoreAcademic = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StatusScore = table.Column<bool>(type: "bit", nullable: false),
                    StatusScoreAcademic = table.Column<bool>(type: "bit", nullable: false),
                    SubjectGroup = table.Column<int>(type: "int", nullable: false),
                    CampusId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdmissionGroup", x => x.AdmissionGroupId);
                    table.ForeignKey(
                        name: "FK_AdmissionGroup_Campus_CampusId",
                        column: x => x.CampusId,
                        principalTable: "Campus",
                        principalColumn: "CampusId");
                });

            migrationBuilder.CreateTable(
                name: "AdmissionInformation",
                columns: table => new
                {
                    AdmissionInformationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeeRegister = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FeeAdmission = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AdmissionProfileDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CampusId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdmissionInformation", x => x.AdmissionInformationID);
                    table.ForeignKey(
                        name: "FK_AdmissionInformation_Campus_CampusId",
                        column: x => x.CampusId,
                        principalTable: "Campus",
                        principalColumn: "CampusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdmissionTime",
                columns: table => new
                {
                    AIId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdmissionInformationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    StartRegister = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndRegister = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartAdmission = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndAdmission = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CampusId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdmissionTime", x => x.AIId);
                    table.ForeignKey(
                        name: "FK_AdmissionTime_Campus_CampusId",
                        column: x => x.CampusId,
                        principalTable: "Campus",
                        principalColumn: "CampusId");
                });

            migrationBuilder.CreateTable(
                name: "BlogCategory",
                columns: table => new
                {
                    BlogCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CampusId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogCategory", x => x.BlogCategoryId);
                    table.ForeignKey(
                        name: "FK_BlogCategory_Campus_CampusId",
                        column: x => x.CampusId,
                        principalTable: "Campus",
                        principalColumn: "CampusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Major",
                columns: table => new
                {
                    MajorID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MajorCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MajorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Target = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    TimeStudy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isVocationalSchool = table.Column<bool>(type: "bit", nullable: false),
                    CampusId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Tuition = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Major", x => x.MajorID);
                    table.ForeignKey(
                        name: "FK_Major_Campus_CampusId",
                        column: x => x.CampusId,
                        principalTable: "Campus",
                        principalColumn: "CampusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Slider",
                columns: table => new
                {
                    SliderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CampusId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slider", x => x.SliderId);
                    table.ForeignKey(
                        name: "FK_Slider_Campus_CampusId",
                        column: x => x.CampusId,
                        principalTable: "Campus",
                        principalColumn: "CampusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Account_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentProfile",
                columns: table => new
                {
                    SpId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<bool>(type: "bit", nullable: true),
                    Nation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitizenIentificationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CIDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CIAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ward = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecificAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailStudent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneStudent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullnameParents = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneParents = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CampusId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Major1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Major2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearOfGraduation = table.Column<int>(type: "int", nullable: true),
                    SchoolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecipientResults = table.Column<bool>(type: "bit", nullable: true),
                    PermanentAddress = table.Column<bool>(type: "bit", nullable: true),
                    AddressRecipientResults = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgCitizenIdentification1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgCitizenIdentification2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgDiploma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imgpriority = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAcademicTranscript1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAcademicTranscript2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAcademicTranscript3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAcademicTranscript4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgAcademicTranscript5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeOfDiploma = table.Column<int>(type: "int", nullable: true),
                    TypeOfTranscript = table.Column<int>(type: "int", nullable: true),
                    PriorityID = table.Column<int>(type: "int", nullable: true),
                    PriorityDetailPriorityID = table.Column<int>(type: "int", nullable: true),
                    TypeofStatus = table.Column<int>(type: "int", nullable: true),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentProfile", x => x.SpId);
                    table.ForeignKey(
                        name: "FK_StudentProfile_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentProfile_Campus_CampusId",
                        column: x => x.CampusId,
                        principalTable: "Campus",
                        principalColumn: "CampusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentProfile_PriorityDetail_PriorityDetailPriorityID",
                        column: x => x.PriorityDetailPriorityID,
                        principalTable: "PriorityDetail",
                        principalColumn: "PriorityID");
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Account_UserId",
                        column: x => x.UserId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.UserId, x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Account_UserId",
                        column: x => x.UserId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Account_UserId",
                        column: x => x.UserId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Account_UserId",
                        column: x => x.UserId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Blog",
                columns: table => new
                {
                    BlogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BlogCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog", x => x.BlogId);
                    table.ForeignKey(
                        name: "FK_Blog_BlogCategory_BlogCategoryId",
                        column: x => x.BlogCategoryId,
                        principalTable: "BlogCategory",
                        principalColumn: "BlogCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequestChangeMajor",
                columns: table => new
                {
                    RequestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MajorNew = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DateRequest = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileReasonRequestChangeMajor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CampusId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestChangeMajor", x => x.RequestID);
                    table.ForeignKey(
                        name: "FK_RequestChangeMajor_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestChangeMajor_Campus_CampusId",
                        column: x => x.CampusId,
                        principalTable: "Campus",
                        principalColumn: "CampusId");
                    table.ForeignKey(
                        name: "FK_RequestChangeMajor_Major_MajorNew",
                        column: x => x.MajorNew,
                        principalTable: "Major",
                        principalColumn: "MajorID");
                });

            migrationBuilder.CreateTable(
                name: "StudentConsultation",
                columns: table => new
                {
                    StudentConsultationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LinkFB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DateReceive = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CampusId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MajorID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentConsultation", x => x.StudentConsultationId);
                    table.ForeignKey(
                        name: "FK_StudentConsultation_Campus_CampusId",
                        column: x => x.CampusId,
                        principalTable: "Campus",
                        principalColumn: "CampusId");
                    table.ForeignKey(
                        name: "FK_StudentConsultation_Major_MajorID",
                        column: x => x.MajorID,
                        principalTable: "Major",
                        principalColumn: "MajorID");
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    SubjectCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MajorID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SubjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfCredits = table.Column<int>(type: "int", nullable: false),
                    SemesterNumber = table.Column<int>(type: "int", nullable: false),
                    StudyTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => new { x.SubjectCode, x.MajorID });
                    table.ForeignKey(
                        name: "FK_Subject_Major_MajorID",
                        column: x => x.MajorID,
                        principalTable: "Major",
                        principalColumn: "MajorID");
                });

            migrationBuilder.CreateTable(
                name: "TypeAdmission",
                columns: table => new
                {
                    MajorID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TypeDiploma = table.Column<int>(type: "int", nullable: false),
                    TypeOfTranscript = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeAdmission", x => new { x.MajorID, x.TypeDiploma });
                    table.ForeignKey(
                        name: "FK_TypeAdmission_Major_MajorID",
                        column: x => x.MajorID,
                        principalTable: "Major",
                        principalColumn: "MajorID");
                });

            migrationBuilder.CreateTable(
                name: "AcademicTranscript",
                columns: table => new
                {
                    ATId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SpId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubjectPoint = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TypeOfAcademicTranscript = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicTranscript", x => x.ATId);
                    table.ForeignKey(
                        name: "FK_AcademicTranscript_StudentProfile_SpId",
                        column: x => x.SpId,
                        principalTable: "StudentProfile",
                        principalColumn: "SpId");
                });

            migrationBuilder.InsertData(
                table: "Campus",
                columns: new[] { "CampusId", "Achievements", "Address", "CampusName", "History", "PhoneNumber", "TrainingMotto", "WhyChooseUs" },
                values: new object[,]
                {
                    { "Cantho", "Trường Cao đẳng Nghề XYZ đã đạt được nhiều thành tích đáng tự hào trong suốt quá trình phát triển:\r\n\r\nDanh hiệu “Trường nghề xuất sắc” do Bộ Lao động - Thương binh và Xã hội trao tặng trong nhiều năm liên tiếp.\r\nThành tích đào tạo: Hơn 10.000 học viên đã tốt nghiệp và làm việc tại các công ty, tập đoàn lớn trong và ngoài nước.\r\nGiải thưởng về sáng tạo và nghiên cứu khoa học: Học viên của trường đã đạt nhiều giải thưởng tại các cuộc thi tay nghề và sáng tạo kỹ thuật cấp quốc gia.\r\nThành tích hợp tác quốc tế: Nhà trường đã ký kết nhiều chương trình hợp tác đào tạo và trao đổi học viên với các trường nghề uy tín ở nước ngoài, nâng cao chất lượng giáo dục và mở ra cơ hội học tập quốc tế cho học viên.", "Toà nhà FPT Polytechnic, đường số 22, phường Thường Thạnh,quận Cái Răng, TP Cần Thơ", "Cần Thơ", "Giới thiệu về lịch sử thành lập Trường Cao đẳng Nghề XYZ\r\n\r\nTrường Cao đẳng Nghề XYZ được thành lập vào năm 1995 với sứ mệnh cung cấp nguồn nhân lực chất lượng cao cho các ngành công nghiệp, dịch vụ và nông nghiệp trên cả nước. Trong suốt hơn hai thập kỷ phát triển, nhà trường đã không ngừng cải tiến, mở rộng quy mô đào tạo và nâng cao chất lượng giảng dạy nhằm đáp ứng nhu cầu ngày càng cao của xã hội và thị trường lao động.\r\n\r\nBan đầu, trường chỉ đào tạo một số ngành nghề cơ bản với quy mô nhỏ, nhưng nhờ sự nỗ lực của đội ngũ cán bộ, giảng viên và sự đầu tư của nhà nước, trường đã phát triển thành một cơ sở giáo dục nghề nghiệp đa ngành, đa lĩnh vực. Hiện nay, Trường Cao đẳng Nghề XYZ tự hào là một trong những đơn vị đi đầu trong việc đào tạo các ngành nghề kỹ thuật, công nghệ và dịch vụ, trang bị cho học viên kiến thức thực tiễn và kỹ năng chuyên môn cao.\r\n\r\nVới phương châm “Học đi đôi với hành”, trường luôn chú trọng vào việc kết hợp giữa lý thuyết và thực hành, giúp học viên sẵn sàng tham gia vào thị trường lao động ngay sau khi tốt nghiệp. Trải qua quá trình hình thành và phát triển, Trường Cao đẳng Nghề XYZ đã khẳng định được vị thế của mình trong hệ thống giáo dục nghề nghiệp và góp phần quan trọng vào sự phát triển của ngành nghề tại Việt Nam.", "0983881100", "Với phương châm \"Học đi đôi với hành, vững lý thuyết – chắc tay nghề\", Trường Cao đẳng Nghề XYZ luôn hướng tới việc đào tạo ra những thế hệ học viên có đầy đủ kiến thức chuyên môn và kỹ năng thực hành, đáp ứng tốt yêu cầu của thị trường lao động hiện đại.\r\n\r\nPhương châm này được cụ thể hóa thông qua các yếu tố:\r\n\r\nGiảng dạy bám sát nhu cầu thị trường: Chương trình đào tạo luôn được cập nhật theo xu hướng phát triển của các ngành công nghiệp và dịch vụ, đảm bảo học viên được trang bị những kiến thức và kỹ năng mới nhất.\r\nPhát triển toàn diện: Bên cạnh kỹ năng nghề nghiệp, trường còn chú trọng phát triển kỹ năng mềm, như kỹ năng giao tiếp, làm việc nhóm, và tư duy sáng tạo, giúp học viên tự tin hơn trong công việc.\r\nHọc tập suốt đời: Nhà trường khuyến khích tinh thần học tập không ngừng nghỉ, giúp học viên luôn sẵn sàng thích nghi với những thay đổi của xã hội và công nghệ.", "Trường Cao đẳng Nghề XYZ luôn được học viên và doanh nghiệp đánh giá cao nhờ vào những ưu điểm vượt trội sau:\r\n\r\nChất lượng đào tạo hàng đầu: Với đội ngũ giảng viên giàu kinh nghiệm và cơ sở vật chất hiện đại, trường đảm bảo cung cấp cho học viên một nền tảng kiến thức vững chắc cùng kỹ năng nghề nghiệp thiết thực.\r\nChương trình đào tạo thực tiễn: Nhà trường luôn chú trọng việc kết hợp lý thuyết với thực hành, giúp học viên không chỉ nắm vững kiến thức mà còn được rèn luyện các kỹ năng cần thiết để làm việc ngay khi ra trường.\r\nMối liên kết chặt chẽ với doanh nghiệp: Trường hợp tác với nhiều doanh nghiệp trong các lĩnh vực khác nhau, tạo điều kiện cho học viên thực tập và có cơ hội việc làm ngay sau khi tốt nghiệp.\r\nMôi trường học tập thân thiện: Nhà trường không chỉ tạo ra một môi trường học tập chuyên nghiệp mà còn thân thiện, tạo điều kiện tốt nhất cho sự phát triển toàn diện của học viên.\r\nCơ hội việc làm cao: Với tỷ lệ học viên có việc làm sau khi ra trường đạt trên 90%, Trường Cao đẳng Nghề XYZ cam kết mang đến cho học viên những cơ hội việc làm tốt nhất." },
                    { "Danang", "Trường Cao đẳng Nghề XYZ đã đạt được nhiều thành tích đáng tự hào trong suốt quá trình phát triển:\r\n\r\nDanh hiệu “Trường nghề xuất sắc” do Bộ Lao động - Thương binh và Xã hội trao tặng trong nhiều năm liên tiếp.\r\nThành tích đào tạo: Hơn 10.000 học viên đã tốt nghiệp và làm việc tại các công ty, tập đoàn lớn trong và ngoài nước.\r\nGiải thưởng về sáng tạo và nghiên cứu khoa học: Học viên của trường đã đạt nhiều giải thưởng tại các cuộc thi tay nghề và sáng tạo kỹ thuật cấp quốc gia.\r\nThành tích hợp tác quốc tế: Nhà trường đã ký kết nhiều chương trình hợp tác đào tạo và trao đổi học viên với các trường nghề uy tín ở nước ngoài, nâng cao chất lượng giáo dục và mở ra cơ hội học tập quốc tế cho học viên.", "219 Nguyễn Sinh Sắc, phường Hoà Minh, quận Liên Chiểu, TP Đà Nẵng", "Đà Nẵng", "Giới thiệu về lịch sử thành lập Trường Cao đẳng Nghề XYZ\r\n\r\nTrường Cao đẳng Nghề XYZ được thành lập vào năm 1995 với sứ mệnh cung cấp nguồn nhân lực chất lượng cao cho các ngành công nghiệp, dịch vụ và nông nghiệp trên cả nước. Trong suốt hơn hai thập kỷ phát triển, nhà trường đã không ngừng cải tiến, mở rộng quy mô đào tạo và nâng cao chất lượng giảng dạy nhằm đáp ứng nhu cầu ngày càng cao của xã hội và thị trường lao động.\r\n\r\nBan đầu, trường chỉ đào tạo một số ngành nghề cơ bản với quy mô nhỏ, nhưng nhờ sự nỗ lực của đội ngũ cán bộ, giảng viên và sự đầu tư của nhà nước, trường đã phát triển thành một cơ sở giáo dục nghề nghiệp đa ngành, đa lĩnh vực. Hiện nay, Trường Cao đẳng Nghề XYZ tự hào là một trong những đơn vị đi đầu trong việc đào tạo các ngành nghề kỹ thuật, công nghệ và dịch vụ, trang bị cho học viên kiến thức thực tiễn và kỹ năng chuyên môn cao.\r\n\r\nVới phương châm “Học đi đôi với hành”, trường luôn chú trọng vào việc kết hợp giữa lý thuyết và thực hành, giúp học viên sẵn sàng tham gia vào thị trường lao động ngay sau khi tốt nghiệp. Trải qua quá trình hình thành và phát triển, Trường Cao đẳng Nghề XYZ đã khẳng định được vị thế của mình trong hệ thống giáo dục nghề nghiệp và góp phần quan trọng vào sự phát triển của ngành nghề tại Việt Nam.", "02363710999", "Với phương châm \"Học đi đôi với hành, vững lý thuyết – chắc tay nghề\", Trường Cao đẳng Nghề XYZ luôn hướng tới việc đào tạo ra những thế hệ học viên có đầy đủ kiến thức chuyên môn và kỹ năng thực hành, đáp ứng tốt yêu cầu của thị trường lao động hiện đại.\r\n\r\nPhương châm này được cụ thể hóa thông qua các yếu tố:\r\n\r\nGiảng dạy bám sát nhu cầu thị trường: Chương trình đào tạo luôn được cập nhật theo xu hướng phát triển của các ngành công nghiệp và dịch vụ, đảm bảo học viên được trang bị những kiến thức và kỹ năng mới nhất.\r\nPhát triển toàn diện: Bên cạnh kỹ năng nghề nghiệp, trường còn chú trọng phát triển kỹ năng mềm, như kỹ năng giao tiếp, làm việc nhóm, và tư duy sáng tạo, giúp học viên tự tin hơn trong công việc.\r\nHọc tập suốt đời: Nhà trường khuyến khích tinh thần học tập không ngừng nghỉ, giúp học viên luôn sẵn sàng thích nghi với những thay đổi của xã hội và công nghệ.", "Trường Cao đẳng Nghề XYZ luôn được học viên và doanh nghiệp đánh giá cao nhờ vào những ưu điểm vượt trội sau:\r\n\r\nChất lượng đào tạo hàng đầu: Với đội ngũ giảng viên giàu kinh nghiệm và cơ sở vật chất hiện đại, trường đảm bảo cung cấp cho học viên một nền tảng kiến thức vững chắc cùng kỹ năng nghề nghiệp thiết thực.\r\nChương trình đào tạo thực tiễn: Nhà trường luôn chú trọng việc kết hợp lý thuyết với thực hành, giúp học viên không chỉ nắm vững kiến thức mà còn được rèn luyện các kỹ năng cần thiết để làm việc ngay khi ra trường.\r\nMối liên kết chặt chẽ với doanh nghiệp: Trường hợp tác với nhiều doanh nghiệp trong các lĩnh vực khác nhau, tạo điều kiện cho học viên thực tập và có cơ hội việc làm ngay sau khi tốt nghiệp.\r\nMôi trường học tập thân thiện: Nhà trường không chỉ tạo ra một môi trường học tập chuyên nghiệp mà còn thân thiện, tạo điều kiện tốt nhất cho sự phát triển toàn diện của học viên.\r\nCơ hội việc làm cao: Với tỷ lệ học viên có việc làm sau khi ra trường đạt trên 90%, Trường Cao đẳng Nghề XYZ cam kết mang đến cho học viên những cơ hội việc làm tốt nhất." },
                    { "Hanoi", "Trường Cao đẳng Nghề XYZ đã đạt được nhiều thành tích đáng tự hào trong suốt quá trình phát triển:\r\n\r\nDanh hiệu “Trường nghề xuất sắc” do Bộ Lao động - Thương binh và Xã hội trao tặng trong nhiều năm liên tiếp.\r\nThành tích đào tạo: Hơn 10.000 học viên đã tốt nghiệp và làm việc tại các công ty, tập đoàn lớn trong và ngoài nước.\r\nGiải thưởng về sáng tạo và nghiên cứu khoa học: Học viên của trường đã đạt nhiều giải thưởng tại các cuộc thi tay nghề và sáng tạo kỹ thuật cấp quốc gia.\r\nThành tích hợp tác quốc tế: Nhà trường đã ký kết nhiều chương trình hợp tác đào tạo và trao đổi học viên với các trường nghề uy tín ở nước ngoài, nâng cao chất lượng giáo dục và mở ra cơ hội học tập quốc tế cho học viên.", "Cổng số 1, Tòa nhà FPT Polytechnic, 13 phố Trịnh Văn Bô, phường Phương Canh, quận Nam Từ Liêm, TP Hà NộiKm12 Cầu Diễn, Phường Phúc Diễn, Quận Bắc Từ Liêm, Hà Nội", "Hà Nội", "Giới thiệu về lịch sử thành lập Trường Cao đẳng Nghề XYZ\r\n\r\nTrường Cao đẳng Nghề XYZ được thành lập vào năm 1995 với sứ mệnh cung cấp nguồn nhân lực chất lượng cao cho các ngành công nghiệp, dịch vụ và nông nghiệp trên cả nước. Trong suốt hơn hai thập kỷ phát triển, nhà trường đã không ngừng cải tiến, mở rộng quy mô đào tạo và nâng cao chất lượng giảng dạy nhằm đáp ứng nhu cầu ngày càng cao của xã hội và thị trường lao động.\r\n\r\nBan đầu, trường chỉ đào tạo một số ngành nghề cơ bản với quy mô nhỏ, nhưng nhờ sự nỗ lực của đội ngũ cán bộ, giảng viên và sự đầu tư của nhà nước, trường đã phát triển thành một cơ sở giáo dục nghề nghiệp đa ngành, đa lĩnh vực. Hiện nay, Trường Cao đẳng Nghề XYZ tự hào là một trong những đơn vị đi đầu trong việc đào tạo các ngành nghề kỹ thuật, công nghệ và dịch vụ, trang bị cho học viên kiến thức thực tiễn và kỹ năng chuyên môn cao.\r\n\r\nVới phương châm “Học đi đôi với hành”, trường luôn chú trọng vào việc kết hợp giữa lý thuyết và thực hành, giúp học viên sẵn sàng tham gia vào thị trường lao động ngay sau khi tốt nghiệp. Trải qua quá trình hình thành và phát triển, Trường Cao đẳng Nghề XYZ đã khẳng định được vị thế của mình trong hệ thống giáo dục nghề nghiệp và góp phần quan trọng vào sự phát triển của ngành nghề tại Việt Nam.", "02485820808", "Với phương châm \"Học đi đôi với hành, vững lý thuyết – chắc tay nghề\", Trường Cao đẳng Nghề XYZ luôn hướng tới việc đào tạo ra những thế hệ học viên có đầy đủ kiến thức chuyên môn và kỹ năng thực hành, đáp ứng tốt yêu cầu của thị trường lao động hiện đại.\r\n\r\nPhương châm này được cụ thể hóa thông qua các yếu tố:\r\n\r\nGiảng dạy bám sát nhu cầu thị trường: Chương trình đào tạo luôn được cập nhật theo xu hướng phát triển của các ngành công nghiệp và dịch vụ, đảm bảo học viên được trang bị những kiến thức và kỹ năng mới nhất.\r\nPhát triển toàn diện: Bên cạnh kỹ năng nghề nghiệp, trường còn chú trọng phát triển kỹ năng mềm, như kỹ năng giao tiếp, làm việc nhóm, và tư duy sáng tạo, giúp học viên tự tin hơn trong công việc.\r\nHọc tập suốt đời: Nhà trường khuyến khích tinh thần học tập không ngừng nghỉ, giúp học viên luôn sẵn sàng thích nghi với những thay đổi của xã hội và công nghệ.", "Trường Cao đẳng Nghề XYZ luôn được học viên và doanh nghiệp đánh giá cao nhờ vào những ưu điểm vượt trội sau:\r\n\r\nChất lượng đào tạo hàng đầu: Với đội ngũ giảng viên giàu kinh nghiệm và cơ sở vật chất hiện đại, trường đảm bảo cung cấp cho học viên một nền tảng kiến thức vững chắc cùng kỹ năng nghề nghiệp thiết thực.\r\nChương trình đào tạo thực tiễn: Nhà trường luôn chú trọng việc kết hợp lý thuyết với thực hành, giúp học viên không chỉ nắm vững kiến thức mà còn được rèn luyện các kỹ năng cần thiết để làm việc ngay khi ra trường.\r\nMối liên kết chặt chẽ với doanh nghiệp: Trường hợp tác với nhiều doanh nghiệp trong các lĩnh vực khác nhau, tạo điều kiện cho học viên thực tập và có cơ hội việc làm ngay sau khi tốt nghiệp.\r\nMôi trường học tập thân thiện: Nhà trường không chỉ tạo ra một môi trường học tập chuyên nghiệp mà còn thân thiện, tạo điều kiện tốt nhất cho sự phát triển toàn diện của học viên.\r\nCơ hội việc làm cao: Với tỷ lệ học viên có việc làm sau khi ra trường đạt trên 90%, Trường Cao đẳng Nghề XYZ cam kết mang đến cho học viên những cơ hội việc làm tốt nhất." },
                    { "HCM", "Trường Cao đẳng Nghề XYZ đã đạt được nhiều thành tích đáng tự hào trong suốt quá trình phát triển:\r\n\r\nDanh hiệu “Trường nghề xuất sắc” do Bộ Lao động - Thương binh và Xã hội trao tặng trong nhiều năm liên tiếp.\r\nThành tích đào tạo: Hơn 10.000 học viên đã tốt nghiệp và làm việc tại các công ty, tập đoàn lớn trong và ngoài nước.\r\nGiải thưởng về sáng tạo và nghiên cứu khoa học: Học viên của trường đã đạt nhiều giải thưởng tại các cuộc thi tay nghề và sáng tạo kỹ thuật cấp quốc gia.\r\nThành tích hợp tác quốc tế: Nhà trường đã ký kết nhiều chương trình hợp tác đào tạo và trao đổi học viên với các trường nghề uy tín ở nước ngoài, nâng cao chất lượng giáo dục và mở ra cơ hội học tập quốc tế cho học viên.", "Tòa nhà QTSC9 (toà T), đường Tô Ký, phường Tân Chánh Hiệp, quận 12, TP HCM.778/B1 Nguyễn Kiệm, phường 04, quận Phú Nhuận, TP HCM", "Tp HCM", "Giới thiệu về lịch sử thành lập Trường Cao đẳng Nghề XYZ\r\n\r\nTrường Cao đẳng Nghề XYZ được thành lập vào năm 1995 với sứ mệnh cung cấp nguồn nhân lực chất lượng cao cho các ngành công nghiệp, dịch vụ và nông nghiệp trên cả nước. Trong suốt hơn hai thập kỷ phát triển, nhà trường đã không ngừng cải tiến, mở rộng quy mô đào tạo và nâng cao chất lượng giảng dạy nhằm đáp ứng nhu cầu ngày càng cao của xã hội và thị trường lao động.\r\n\r\nBan đầu, trường chỉ đào tạo một số ngành nghề cơ bản với quy mô nhỏ, nhưng nhờ sự nỗ lực của đội ngũ cán bộ, giảng viên và sự đầu tư của nhà nước, trường đã phát triển thành một cơ sở giáo dục nghề nghiệp đa ngành, đa lĩnh vực. Hiện nay, Trường Cao đẳng Nghề XYZ tự hào là một trong những đơn vị đi đầu trong việc đào tạo các ngành nghề kỹ thuật, công nghệ và dịch vụ, trang bị cho học viên kiến thức thực tiễn và kỹ năng chuyên môn cao.\r\n\r\nVới phương châm “Học đi đôi với hành”, trường luôn chú trọng vào việc kết hợp giữa lý thuyết và thực hành, giúp học viên sẵn sàng tham gia vào thị trường lao động ngay sau khi tốt nghiệp. Trải qua quá trình hình thành và phát triển, Trường Cao đẳng Nghề XYZ đã khẳng định được vị thế của mình trong hệ thống giáo dục nghề nghiệp và góp phần quan trọng vào sự phát triển của ngành nghề tại Việt Nam.", "02866866486", "Với phương châm \"Học đi đôi với hành, vững lý thuyết – chắc tay nghề\", Trường Cao đẳng Nghề XYZ luôn hướng tới việc đào tạo ra những thế hệ học viên có đầy đủ kiến thức chuyên môn và kỹ năng thực hành, đáp ứng tốt yêu cầu của thị trường lao động hiện đại.\r\n\r\nPhương châm này được cụ thể hóa thông qua các yếu tố:\r\n\r\nGiảng dạy bám sát nhu cầu thị trường: Chương trình đào tạo luôn được cập nhật theo xu hướng phát triển của các ngành công nghiệp và dịch vụ, đảm bảo học viên được trang bị những kiến thức và kỹ năng mới nhất.\r\nPhát triển toàn diện: Bên cạnh kỹ năng nghề nghiệp, trường còn chú trọng phát triển kỹ năng mềm, như kỹ năng giao tiếp, làm việc nhóm, và tư duy sáng tạo, giúp học viên tự tin hơn trong công việc.\r\nHọc tập suốt đời: Nhà trường khuyến khích tinh thần học tập không ngừng nghỉ, giúp học viên luôn sẵn sàng thích nghi với những thay đổi của xã hội và công nghệ.", "Trường Cao đẳng Nghề XYZ luôn được học viên và doanh nghiệp đánh giá cao nhờ vào những ưu điểm vượt trội sau:\r\n\r\nChất lượng đào tạo hàng đầu: Với đội ngũ giảng viên giàu kinh nghiệm và cơ sở vật chất hiện đại, trường đảm bảo cung cấp cho học viên một nền tảng kiến thức vững chắc cùng kỹ năng nghề nghiệp thiết thực.\r\nChương trình đào tạo thực tiễn: Nhà trường luôn chú trọng việc kết hợp lý thuyết với thực hành, giúp học viên không chỉ nắm vững kiến thức mà còn được rèn luyện các kỹ năng cần thiết để làm việc ngay khi ra trường.\r\nMối liên kết chặt chẽ với doanh nghiệp: Trường hợp tác với nhiều doanh nghiệp trong các lĩnh vực khác nhau, tạo điều kiện cho học viên thực tập và có cơ hội việc làm ngay sau khi tốt nghiệp.\r\nMôi trường học tập thân thiện: Nhà trường không chỉ tạo ra một môi trường học tập chuyên nghiệp mà còn thân thiện, tạo điều kiện tốt nhất cho sự phát triển toàn diện của học viên.\r\nCơ hội việc làm cao: Với tỷ lệ học viên có việc làm sau khi ra trường đạt trên 90%, Trường Cao đẳng Nghề XYZ cam kết mang đến cho học viên những cơ hội việc làm tốt nhất." },
                    { "Thanhhoa", "Trường Cao đẳng Nghề XYZ đã đạt được nhiều thành tích đáng tự hào trong suốt quá trình phát triển:\r\n\r\nDanh hiệu “Trường nghề xuất sắc” do Bộ Lao động - Thương binh và Xã hội trao tặng trong nhiều năm liên tiếp.\r\nThành tích đào tạo: Hơn 10.000 học viên đã tốt nghiệp và làm việc tại các công ty, tập đoàn lớn trong và ngoài nước.\r\nGiải thưởng về sáng tạo và nghiên cứu khoa học: Học viên của trường đã đạt nhiều giải thưởng tại các cuộc thi tay nghề và sáng tạo kỹ thuật cấp quốc gia.\r\nThành tích hợp tác quốc tế: Nhà trường đã ký kết nhiều chương trình hợp tác đào tạo và trao đổi học viên với các trường nghề uy tín ở nước ngoài, nâng cao chất lượng giáo dục và mở ra cơ hội học tập quốc tế cho học viên.", "Tòa Beta, Tổ hợp giáo dục FPT, Đại lộ Võ Nguyên Giáp, phường Quảng Thành, TP Thanh Hóa", "Thanh Hoá", "Giới thiệu về lịch sử thành lập Trường Cao đẳng Nghề XYZ\r\n\r\nTrường Cao đẳng Nghề XYZ được thành lập vào năm 1995 với sứ mệnh cung cấp nguồn nhân lực chất lượng cao cho các ngành công nghiệp, dịch vụ và nông nghiệp trên cả nước. Trong suốt hơn hai thập kỷ phát triển, nhà trường đã không ngừng cải tiến, mở rộng quy mô đào tạo và nâng cao chất lượng giảng dạy nhằm đáp ứng nhu cầu ngày càng cao của xã hội và thị trường lao động.\r\n\r\nBan đầu, trường chỉ đào tạo một số ngành nghề cơ bản với quy mô nhỏ, nhưng nhờ sự nỗ lực của đội ngũ cán bộ, giảng viên và sự đầu tư của nhà nước, trường đã phát triển thành một cơ sở giáo dục nghề nghiệp đa ngành, đa lĩnh vực. Hiện nay, Trường Cao đẳng Nghề XYZ tự hào là một trong những đơn vị đi đầu trong việc đào tạo các ngành nghề kỹ thuật, công nghệ và dịch vụ, trang bị cho học viên kiến thức thực tiễn và kỹ năng chuyên môn cao.\r\n\r\nVới phương châm “Học đi đôi với hành”, trường luôn chú trọng vào việc kết hợp giữa lý thuyết và thực hành, giúp học viên sẵn sàng tham gia vào thị trường lao động ngay sau khi tốt nghiệp. Trải qua quá trình hình thành và phát triển, Trường Cao đẳng Nghề XYZ đã khẳng định được vị thế của mình trong hệ thống giáo dục nghề nghiệp và góp phần quan trọng vào sự phát triển của ngành nghề tại Việt Nam.", "0913785213", "Với phương châm \"Học đi đôi với hành, vững lý thuyết – chắc tay nghề\", Trường Cao đẳng Nghề XYZ luôn hướng tới việc đào tạo ra những thế hệ học viên có đầy đủ kiến thức chuyên môn và kỹ năng thực hành, đáp ứng tốt yêu cầu của thị trường lao động hiện đại.\r\n\r\nPhương châm này được cụ thể hóa thông qua các yếu tố:\r\n\r\nGiảng dạy bám sát nhu cầu thị trường: Chương trình đào tạo luôn được cập nhật theo xu hướng phát triển của các ngành công nghiệp và dịch vụ, đảm bảo học viên được trang bị những kiến thức và kỹ năng mới nhất.\r\nPhát triển toàn diện: Bên cạnh kỹ năng nghề nghiệp, trường còn chú trọng phát triển kỹ năng mềm, như kỹ năng giao tiếp, làm việc nhóm, và tư duy sáng tạo, giúp học viên tự tin hơn trong công việc.\r\nHọc tập suốt đời: Nhà trường khuyến khích tinh thần học tập không ngừng nghỉ, giúp học viên luôn sẵn sàng thích nghi với những thay đổi của xã hội và công nghệ.", "Trường Cao đẳng Nghề XYZ luôn được học viên và doanh nghiệp đánh giá cao nhờ vào những ưu điểm vượt trội sau:\r\n\r\nChất lượng đào tạo hàng đầu: Với đội ngũ giảng viên giàu kinh nghiệm và cơ sở vật chất hiện đại, trường đảm bảo cung cấp cho học viên một nền tảng kiến thức vững chắc cùng kỹ năng nghề nghiệp thiết thực.\r\nChương trình đào tạo thực tiễn: Nhà trường luôn chú trọng việc kết hợp lý thuyết với thực hành, giúp học viên không chỉ nắm vững kiến thức mà còn được rèn luyện các kỹ năng cần thiết để làm việc ngay khi ra trường.\r\nMối liên kết chặt chẽ với doanh nghiệp: Trường hợp tác với nhiều doanh nghiệp trong các lĩnh vực khác nhau, tạo điều kiện cho học viên thực tập và có cơ hội việc làm ngay sau khi tốt nghiệp.\r\nMôi trường học tập thân thiện: Nhà trường không chỉ tạo ra một môi trường học tập chuyên nghiệp mà còn thân thiện, tạo điều kiện tốt nhất cho sự phát triển toàn diện của học viên.\r\nCơ hội việc làm cao: Với tỷ lệ học viên có việc làm sau khi ra trường đạt trên 90%, Trường Cao đẳng Nghề XYZ cam kết mang đến cho học viên những cơ hội việc làm tốt nhất." }
                });

            migrationBuilder.InsertData(
                table: "PriorityDetail",
                columns: new[] { "PriorityID", "PriorityDescription", "PriorityName", "TypeOfPriority" },
                values: new object[,]
                {
                    { 1, "Công dân Việt Nam là người dân tộc thiểu số có nơi thường trú trong thời gian học THPT hoặc trung cấp trên 18 tháng tại Khu vực 1.", "Đối tượng 01", 0 },
                    { 2, "Công nhân trực tiếp sản xuất đã làm việc liên tục 5 năm trở lên, trong đó có ít nhất 2 năm là chiến sĩ thi đua được cấp tỉnh trở lên công nhận và cấp bằng khen.", "Đối tượng 02", 0 },
                    { 3, "a) Thương binh, bệnh binh, người có \"Giấy chứng nhận người được hưởng chính sách như thương binh;\r\n\r\nb) Quân nhân; sĩ quan, hạ sĩ quan, chiến sĩ nghĩa vụ trong Công an nhân dân tại ngũ được cử đi học có thời gian phục vụ từ 12 tháng trở lên tại Khu vực 1;\r\n\r\nc) Quân nhân; sĩ quan, hạ sĩ quan, chiến sĩ nghĩa vụ trong Công an nhân dân tại ngũ được cử đi học có thời gian phục vụ từ 18 tháng trở lên;\r\n\r\nd) Quân nhân; sĩ quan, hạ sĩ quan, chiến sĩ nghĩa vụ trong Công an nhân dân đã xuất ngũ, được công nhận hoàn thành nghĩa vụ phục vụ tại ngũ theo quy định;", "Đối tượng 03", 0 },
                    { 4, "a) Thân nhân liệt sĩ;\r\n\r\nb) Con thương binh, con bệnh binh, con của người được hưởng chính sách như thương binh bị suy giảm khả năng lao động từ 81% trở lên;\r\n\r\nc) Con của người hoạt động kháng chiến bị nhiễm chất độc hóa học bị suy giảm khả năng lao động 81% trở lên;\r\n\r\nd) Con của Anh hùng Lực lượng vũ trang nhân dân; con của Anh hùng Lao động trong thời kỳ kháng chiến;\r\n\r\nđ) Con của người hoạt động kháng chiến bị dị dạng, dị tật do hậu quả của chất độc hóa học đang hưởng trợ cấp hàng tháng.", "Đối tượng 04", 0 },
                    { 5, "a) Thanh niên xung phong tập trung được cử đi học;\r\n\r\nb) Quân nhân; sĩ quan, hạ sĩ quan, chiến sĩ nghĩa vụ trong Công an nhân dân tại ngũ được cử đi học có thời gian phục vụ dưới 12 tháng ở Khu vực 1 và dưới 18 tháng ở khu vực khác;\r\n\r\nc) Chỉ huy trưởng, Chỉ huy phó ban chỉ huy quân sự xã, phường, thị trấn; Thôn đội trưởng, Trung đội trưởng Dân quân tự vệ nòng cốt, Dân quân tự vệ đã hoàn thành nghĩa vụ tham gia Dân quân tự vệ nòng cốt từ 12 tháng trở lên, dự thi vào ngành Quân sự cơ sở. Thời hạn tối đa được hưởng ưu tiên là 18 tháng kể từ ngày ký quyết định xuất ngũ đến ngày ĐKXT.", "Đối tượng 05", 1 },
                    { 6, "a) Công dân Việt Nam là người dân tộc thiểu số có nơi thường trú ở ngoài khu vực đã quy định thuộc đối tượng 01;\r\n\r\nb) Con thương binh, con bệnh binh, con của người được hưởng chính sách như thương binh bị suy giảm khả năng lao động dưới 81%;\r\n\r\nc) Con của người hoạt động kháng chiến bị nhiễm chất độc hóa học có tỷ lệ suy giảm khả năng lao động dưới 81%.", "Đối tượng 06", 1 },
                    { 7, "a) Người khuyết tật nặng có giấy xác nhận khuyết tật của cơ quan có thẩm quyền cấp theo quy định tại Thông tư liên tịch số 37/2012/TTLT- BLĐTBXH-BYT-BTC-BGDĐT ngày 28 tháng 12 năm 2012 của Bộ Lao động - Thương binh và Xã hội, Bộ Y tế, Bộ Tài chính và Bộ GDĐT quy định về việc xác định mức độ khuyết tật do Hội đồng xác định mức độ khuyết tật thực hiện;\r\n\r\nb) Người lao động ưu tú thuộc tất cả thành phần kinh tế từ cấp tỉnh, cấp bộ trở lên được công nhận danh hiệu thợ giỏi, nghệ nhân, được cấp bằng hoặc huy hiệu Lao động sáng tạo của Tổng Liên đoàn Lao động Việt Nam hoặc Trung ương Đoàn TNCS Hồ Chí Minh;\r\n\r\nc) Giáo viên đã giảng dạy đủ 3 năm trở lên dự tuyển vào các ngành đào tạo giáo viên;\r\n\r\nd) Y tá, dược tá, hộ lý, y sĩ, điều dưỡng viên, hộ sinh viên, kỹ thuật viên, người có bằng trung cấp Dược đã công tác đủ 3 năm trở lên dự tuyển vào đúng ngành tốt nghiệp thuộc lĩnh vực sức khỏe.", "Đối tượng 07", 1 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"), "626d5c9c-0438-4e59-853f-781a9abb52ce", "SchoolService", "SCHOOLSERVICE" },
                    { new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"), "13189709-9295-48af-a602-ec88abfcf3b9", "AdmissionOfficer", "ADMISSIONOFFICER" },
                    { new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"), "07aa443c-ae6c-4d7f-a173-bde356bf42d7", "Admin", "ADMIN" },
                    { new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"), "169082b0-d436-4bb7-927a-ae09b2ed32a8", "Student", "STUDENT" },
                    { new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"), "1f1f0968-4228-4d8b-b44b-259a8117bb3e", "AdmissionCouncil", "ADMISSIONCOUNCIL" }
                });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "AccessFailedCount", "AvatarURL", "CampusId", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "Fullname", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "SPId", "SecurityStamp", "TwoFactorEnabled", "UserName", "isAccountActive" },
                values: new object[,]
                {
                    { new Guid("17baf918-d5d2-4628-aad1-8a4926520676"), 0, null, "Hanoi", "cc410e1b-d349-4a5b-8cfd-20e34a53175f", null, "SchoolService@gmail.com", true, "School Service Hanoi", null, false, null, "SCHOOLSERVICE@GMAIL.COM", "SCHOOLSERVICE", "AQAAAAEAACcQAAAAEIWU8w0kIejomf5KcNLKSHb8a6UP/1zT2W0BvaKh666aVYNHMpLLuIWXHm8kZ8TxHA==", null, null, false, null, "99551603-7040-4c47-8333-c1faebe07720", false, "SchoolService", false },
                    { new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"), 0, null, "Hanoi", "9fad5b46-92c0-4773-9782-524a160a7d32", null, "nguyenducanh01.57@gmail.com", true, "Nguyễn Đức Anh", null, false, null, "NGUYENDUCANH01.57@GMAIL.COM", "STUDENT", "AQAAAAEAACcQAAAAEE9L2dAnWjGsZCMuUsjx4WU5+TpYPPqZz7E0r6Baq5Jc/QtRidnA3jdfU9pRupYtlg==", null, null, false, null, "36e25477-c1a9-4be4-8e4b-ff525fc18473", false, "DucAnh", false },
                    { new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd"), 0, null, "Hanoi", "4e4bb77f-0261-42f7-81c4-86c53cb15b14", null, "AdmissionOfficer@gmail.com", true, "Admin Officer Hanoi", null, false, null, "ADMISSIONOFFICER@GMAIL.COM", "ADMISSIONOFFICER", "AQAAAAEAACcQAAAAEIpxtpy4knTDiAz+tBh+Fq4AbEFxGyLJpqFi1J9pMhyBMTlsg+9boUQdSj4be51WmA==", null, null, false, null, "c1e20e65-b3c9-4bf1-af46-557426c1ca14", false, "AdmissionOfficer", false },
                    { new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e"), 0, null, "Hanoi", "e3b0fa02-c96e-46dc-a86a-565528626fe6", null, "AdmissionCouncil@gmail.com", true, "Admission Council Hanoi", null, false, null, "ADMISSIONCOUNCIL@GMAIL.COM", "ADMISSIONCOUNCIL", "AQAAAAEAACcQAAAAEFQqylcFjJvJGonwBtrEm8DEGuGnMurbHkJC7zB+6Qzdf6oeiNB6xLhmMj3yfPC9Zw==", null, null, false, null, "6ab76718-ca61-4bf5-98b9-a0000c02a595", false, "AdmissionCouncil", false },
                    { new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"), 0, null, "Hanoi", "fc453a66-2d3c-46a0-9671-5a71392dd214", null, "AdminHaNoi@gmail.com", true, "Admin Hanoi", null, false, null, "ADMINHANOI@GMAIL.COM", "ADMINISTRATOR", "AQAAAAEAACcQAAAAELx/ekR7x1aT1f7SeWXDdc6aAvN7HDIJMu2g/rCm8irZ3NQN6T7asaHwo8rkIGaCQA==", null, null, false, null, "9f69c158-a908-4e0e-987c-b396aa7427fe", false, "Administrator", false }
                });

            migrationBuilder.InsertData(
                table: "AdmissionGroup",
                columns: new[] { "AdmissionGroupId", "CampusId", "StatusScore", "StatusScoreAcademic", "SubjectGroup", "TotalScore", "TotalScoreAcademic", "Year" },
                values: new object[,]
                {
                    { 1, "Hanoi", true, true, 0, 24m, 24m, 2024 },
                    { 2, "Hanoi", true, true, 1, 24m, 24m, 2024 },
                    { 3, "Hanoi", true, true, 2, 24m, 24m, 2024 },
                    { 4, "Hanoi", true, true, 3, 24m, 24m, 2024 },
                    { 5, "Hanoi", true, true, 4, 24m, 24m, 2024 },
                    { 6, "Hanoi", true, true, 5, 24m, 24m, 2024 },
                    { 7, "Hanoi", true, true, 6, 24m, 24m, 2024 },
                    { 8, "Hanoi", true, true, 7, 24m, 24m, 2024 },
                    { 9, "Hanoi", true, true, 8, 24m, 24m, 2024 },
                    { 10, "Hanoi", true, true, 9, 24m, 24m, 2024 },
                    { 11, "Hanoi", true, true, 10, 24m, 24m, 2024 },
                    { 12, "Hanoi", true, true, 11, 24m, 24m, 2024 },
                    { 13, "Hanoi", true, true, 18, 24m, 24m, 2024 },
                    { 14, "Hanoi", true, true, 19, 24m, 24m, 2024 },
                    { 15, "Hanoi", true, true, 20, 24m, 24m, 2024 },
                    { 16, "Hanoi", true, true, 21, 24m, 24m, 2024 },
                    { 17, "Hanoi", true, true, 22, 24m, 24m, 2024 },
                    { 18, "Hanoi", true, true, 24, 24m, 24m, 2024 },
                    { 19, "Hanoi", true, true, 25, 24m, 24m, 2024 },
                    { 20, "Hanoi", true, true, 26, 24m, 24m, 2024 },
                    { 21, "Hanoi", true, true, 27, 24m, 24m, 2024 },
                    { 22, "Hanoi", true, true, 28, 24m, 24m, 2024 },
                    { 23, "Hanoi", true, true, 29, 24m, 24m, 2024 },
                    { 24, "Hanoi", true, true, 30, 24m, 24m, 2024 },
                    { 25, "Hanoi", true, true, 31, 24m, 24m, 2024 },
                    { 26, "Hanoi", true, true, 32, 24m, 24m, 2024 },
                    { 27, "Hanoi", true, true, 33, 24m, 24m, 2024 },
                    { 28, "Hanoi", true, true, 34, 24m, 24m, 2024 },
                    { 29, "Hanoi", true, true, 35, 24m, 24m, 2024 },
                    { 30, "Hanoi", true, true, 36, 24m, 24m, 2024 },
                    { 31, "Hanoi", true, true, 37, 24m, 24m, 2024 },
                    { 32, "Hanoi", true, true, 38, 24m, 24m, 2024 },
                    { 33, "Hanoi", true, true, 40, 24m, 24m, 2024 },
                    { 34, "Hanoi", true, true, 41, 24m, 24m, 2024 },
                    { 35, "Hanoi", true, true, 42, 24m, 24m, 2024 },
                    { 36, "Hanoi", true, true, 43, 24m, 24m, 2024 },
                    { 37, "Hanoi", true, true, 44, 24m, 24m, 2024 }
                });

            migrationBuilder.InsertData(
                table: "AdmissionGroup",
                columns: new[] { "AdmissionGroupId", "CampusId", "StatusScore", "StatusScoreAcademic", "SubjectGroup", "TotalScore", "TotalScoreAcademic", "Year" },
                values: new object[,]
                {
                    { 38, "Hanoi", true, true, 45, 24m, 24m, 2024 },
                    { 39, "Hanoi", true, true, 50, 24m, 24m, 2024 },
                    { 40, "Hanoi", true, true, 51, 24m, 24m, 2024 },
                    { 41, "Hanoi", true, true, 52, 24m, 24m, 2024 },
                    { 42, "Hanoi", true, true, 53, 24m, 24m, 2024 },
                    { 43, "Hanoi", true, true, 54, 24m, 24m, 2024 },
                    { 44, "Hanoi", true, true, 55, 24m, 24m, 2024 },
                    { 45, "Hanoi", true, true, 56, 24m, 24m, 2024 },
                    { 46, "Hanoi", true, true, 57, 24m, 24m, 2024 },
                    { 47, "Hanoi", true, true, 58, 24m, 24m, 2024 }
                });

            migrationBuilder.InsertData(
                table: "AdmissionInformation",
                columns: new[] { "AdmissionInformationID", "AdmissionProfileDescription", "CampusId", "FeeAdmission", "FeeRegister" },
                values: new object[,]
                {
                    { 1, "01 Phiếu đăng ký học theo mẫu quy định của trường. Phiếu đăng ký học thí sinh có thể điền trực tiếp, hoặc tải về tự in tại đây, hoặc đến nhận tại văn phòng tuyển sinh trên toàn quốc.\r\n01 Bản sao công chứng Căn cước công dân hoặc Chứng minh nhân dân.\r\n01 Bản sao công chứng Bằng tốt nghiệp hoặc Giấy chứng nhận tốt nghiệp tạm thời.\r\n01 Bản sao công chứng bảng điểm(nếu xét học bạ).\r\n2 ảnh 3x4\r\n", "Hanoi", 4600000m, 100000m },
                    { 2, "01 Phiếu đăng ký học theo mẫu quy định của trường. Phiếu đăng ký học thí sinh có thể điền trực tiếp, hoặc tải về tự in tại đây, hoặc đến nhận tại văn phòng tuyển sinh trên toàn quốc.\r\n01 Bản sao công chứng Căn cước công dân hoặc Chứng minh nhân dân.\r\n01 Bản sao công chứng Bằng tốt nghiệp hoặc Giấy chứng nhận tốt nghiệp tạm thời.\r\n01 Bản sao công chứng bảng điểm(nếu xét học bạ).\r\n2 ảnh 3x4\r\n", "Danang", 4600000m, 100000m },
                    { 3, "01 Phiếu đăng ký học theo mẫu quy định của trường. Phiếu đăng ký học thí sinh có thể điền trực tiếp, hoặc tải về tự in tại đây, hoặc đến nhận tại văn phòng tuyển sinh trên toàn quốc.\r\n01 Bản sao công chứng Căn cước công dân hoặc Chứng minh nhân dân.\r\n01 Bản sao công chứng Bằng tốt nghiệp hoặc Giấy chứng nhận tốt nghiệp tạm thời.\r\n01 Bản sao công chứng bảng điểm(nếu xét học bạ).\r\n2 ảnh 3x4\r\n", "Cantho", 4600000m, 100000m },
                    { 4, "01 Phiếu đăng ký học theo mẫu quy định của trường. Phiếu đăng ký học thí sinh có thể điền trực tiếp, hoặc tải về tự in tại đây, hoặc đến nhận tại văn phòng tuyển sinh trên toàn quốc.\r\n01 Bản sao công chứng Căn cước công dân hoặc Chứng minh nhân dân.\r\n01 Bản sao công chứng Bằng tốt nghiệp hoặc Giấy chứng nhận tốt nghiệp tạm thời.\r\n01 Bản sao công chứng bảng điểm(nếu xét học bạ).\r\n2 ảnh 3x4\r\n", "HCM", 4600000m, 100000m },
                    { 5, "01 Phiếu đăng ký học theo mẫu quy định của trường. Phiếu đăng ký học thí sinh có thể điền trực tiếp, hoặc tải về tự in tại đây, hoặc đến nhận tại văn phòng tuyển sinh trên toàn quốc.\r\n01 Bản sao công chứng Căn cước công dân hoặc Chứng minh nhân dân.\r\n01 Bản sao công chứng Bằng tốt nghiệp hoặc Giấy chứng nhận tốt nghiệp tạm thời.\r\n01 Bản sao công chứng bảng điểm(nếu xét học bạ).\r\n2 ảnh 3x4\r\n", "Thanhhoa", 4600000m, 100000m }
                });

            migrationBuilder.InsertData(
                table: "AdmissionTime",
                columns: new[] { "AIId", "AdmissionInformationName", "CampusId", "EndAdmission", "EndRegister", "StartAdmission", "StartRegister", "Year" },
                values: new object[,]
                {
                    { 1, "Đợt 1", "Hanoi", new DateTime(2024, 4, 30, 23, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 23, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2024 },
                    { 2, "Đợt 2", "Hanoi", new DateTime(2024, 7, 30, 23, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 23, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2024 },
                    { 3, "Đợt 3", "Hanoi", new DateTime(2024, 9, 1, 23, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 23, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2024 }
                });

            migrationBuilder.InsertData(
                table: "BlogCategory",
                columns: new[] { "BlogCategoryId", "BlogCategoryName", "CampusId" },
                values: new object[,]
                {
                    { 1, "Tuyển sinh", "Hanoi" },
                    { 2, "Hoạt động của sinh viên", "Hanoi" },
                    { 3, "Sự kiện", "Hanoi" },
                    { 4, "Tuyển sinh", "Danang" },
                    { 5, "Hoạt động của sinh viên", "Danang" },
                    { 6, "Sự kiện", "Danang" },
                    { 7, "Tuyển sinh", "Cantho" },
                    { 8, "Hoạt động của sinh viên", "Cantho" },
                    { 9, "Sự kiện", "Cantho" },
                    { 10, "Tuyển sinh", "HCM" },
                    { 11, "Hoạt động của sinh viên", "HCM" },
                    { 12, "Sự kiện", "HCM" },
                    { 13, "Tuyển sinh", "Thanhhoa" },
                    { 14, "Hoạt động của sinh viên", "Thanhhoa" },
                    { 15, "Sự kiện", "Thanhhoa" }
                });

            migrationBuilder.InsertData(
                table: "Major",
                columns: new[] { "MajorID", "CampusId", "Description", "MajorCode", "MajorName", "Status", "Target", "TimeStudy", "Tuition", "isVocationalSchool" },
                values: new object[,]
                {
                    { "HAO", "Hanoi", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "71490", "Kiểm toán", true, 200, "2 năm", 12000000m, false },
                    { "HBS", "Hanoi", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "71490", "Chăm sóc da và massage", true, 200, "2 năm", 12000000m, true },
                    { "HBT", "Hanoi", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "71490", "Phum xăm thẩm mỹ", true, 200, "2 năm", 12000000m, true },
                    { "HEA", "Hanoi", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "7220201", "Ngôn ngữ anh", true, 200, "2 năm", 12000000m, false },
                    { "HFO", "Hanoi", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "71490", "Kỹ thuật chế biến món ăn", true, 200, "2 năm", 12000000m, true },
                    { "HGE", "Hanoi", "Tin học ứng dụng (CNTT) sử dụng hệ thống các thiết bị và máy tính (bao gồm phần cứng, phần mềm) để cung cấp một giải pháp xử lý thông tin trên nền công nghệ cho các cá nhân, tổ chức có yêu cầu. Các giải pháp CNTT rất đa dạng: phần mềm quản lý nhân viên trong cơ quan, tổ chức, website dạy học qua mạng, hệ thống máy tính phục vụ cho nhu cầu tính cước, phần mềm trên các thiết bị di động hoặc những chương trình giải trí trên Internet v.v… Bởi vậy, đối tượng phục vụ của ngành CNTT ngày càng phong phú.", "7480201", "Lập trình game", true, 200, "2 năm", 12000000m, false },
                    { "HHM", "Hanoi", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "7340101", "Quản trị khách sạn", true, 200, "24 năm", 12000000m, false },
                    { "HJA", "Hanoi", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "7220209", "Ngôn ngữ nhật", true, 200, "2 năm", 12000000m, false },
                    { "HKA", "Hanoi", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "7220210", "Ngôn ngữ hàn", true, 200, "24 năm", 12000000m, false }
                });

            migrationBuilder.InsertData(
                table: "Major",
                columns: new[] { "MajorID", "CampusId", "Description", "MajorCode", "MajorName", "Status", "Target", "TimeStudy", "Tuition", "isVocationalSchool" },
                values: new object[,]
                {
                    { "HME", "Hanoi", "Tin học ứng dụng (CNTT) sử dụng hệ thống các thiết bị và máy tính (bao gồm phần cứng, phần mềm) để cung cấp một giải pháp xử lý thông tin trên nền công nghệ cho các cá nhân, tổ chức có yêu cầu. Các giải pháp CNTT rất đa dạng: phần mềm quản lý nhân viên trong cơ quan, tổ chức, website dạy học qua mạng, hệ thống máy tính phục vụ cho nhu cầu tính cước, phần mềm trên các thiết bị di động hoặc những chương trình giải trí trên Internet v.v… Bởi vậy, đối tượng phục vụ của ngành CNTT ngày càng phong phú.", "7480201", "Lập trình mobile", true, 200, "2 năm", 12000000m, false },
                    { "HRM", "Hanoi", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "7340101", "Quản trị nhà hàng", true, 200, "24 năm", 12000000m, false },
                    { "HSM", "Hanoi", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "7340101", "Marketing", true, 200, "2 năm", 12000000m, false },
                    { "HSO", "Hanoi", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "71490", "Thư ký văn phòng", true, 200, "24 năm", 12000000m, false },
                    { "HTE", "Hanoi", "Tin học ứng dụng (CNTT) sử dụng hệ thống các thiết bị và máy tính (bao gồm phần cứng, phần mềm) để cung cấp một giải pháp xử lý thông tin trên nền công nghệ cho các cá nhân, tổ chức có yêu cầu. Các giải pháp CNTT rất đa dạng: phần mềm quản lý nhân viên trong cơ quan, tổ chức, website dạy học qua mạng, hệ thống máy tính phục vụ cho nhu cầu tính cước, phần mềm trên các thiết bị di động hoặc những chương trình giải trí trên Internet v.v… Bởi vậy, đối tượng phục vụ của ngành CNTT ngày càng phong phú.", "7480201", "Kiểm thử", true, 200, "2 năm", 12000000m, false },
                    { "HWE", "Hanoi", "Tin học ứng dụng (CNTT) sử dụng hệ thống các thiết bị và máy tính (bao gồm phần cứng, phần mềm) để cung cấp một giải pháp xử lý thông tin trên nền công nghệ cho các cá nhân, tổ chức có yêu cầu. Các giải pháp CNTT rất đa dạng: phần mềm quản lý nhân viên trong cơ quan, tổ chức, website dạy học qua mạng, hệ thống máy tính phục vụ cho nhu cầu tính cước, phần mềm trên các thiết bị di động hoặc những chương trình giải trí trên Internet v.v… Bởi vậy, đối tượng phục vụ của ngành CNTT ngày càng phong phú.", "7480201", "Lập trình web", true, 200, "2 năm", 12000000m, false },
                    { "SAO", "HCM", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "71490", "Kiểm toán", true, 200, "2 năm", 12000000m, false },
                    { "SBS", "HCM", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "71490", "Chăm sóc da và massage", true, 200, "2 năm", 12000000m, true },
                    { "SBT", "HCM", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "71490", "Phum xăm thẩm mỹ", true, 200, "2 năm", 12000000m, true },
                    { "SEA", "HCM", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "7220201", "Ngôn ngữ anh", true, 200, "2 năm", 12000000m, false },
                    { "SFO", "HCM", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "71490", "Kỹ thuật chế biến món ăn", true, 200, "2 năm", 12000000m, true },
                    { "SGE", "HCM", "Tin học ứng dụng (CNTT) sử dụng hệ thống các thiết bị và máy tính (bao gồm phần cứng, phần mềm) để cung cấp một giải pháp xử lý thông tin trên nền công nghệ cho các cá nhân, tổ chức có yêu cầu. Các giải pháp CNTT rất đa dạng: phần mềm quản lý nhân viên trong cơ quan, tổ chức, website dạy học qua mạng, hệ thống máy tính phục vụ cho nhu cầu tính cước, phần mềm trên các thiết bị di động hoặc những chương trình giải trí trên Internet v.v… Bởi vậy, đối tượng phục vụ của ngành CNTT ngày càng phong phú.", "7480201", "Lập trình game", true, 200, "2 năm", 12000000m, false },
                    { "SHM", "HCM", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "7340101", "Quản trị khách sạn", true, 200, "24 năm", 12000000m, false },
                    { "SJA", "HCM", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "7220209", "Ngôn ngữ nhật", true, 200, "2 năm", 12000000m, false },
                    { "SKA", "HCM", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "7220210", "Ngôn ngữ hàn", true, 200, "24 năm", 12000000m, false },
                    { "SME", "HCM", "Tin học ứng dụng (CNTT) sử dụng hệ thống các thiết bị và máy tính (bao gồm phần cứng, phần mềm) để cung cấp một giải pháp xử lý thông tin trên nền công nghệ cho các cá nhân, tổ chức có yêu cầu. Các giải pháp CNTT rất đa dạng: phần mềm quản lý nhân viên trong cơ quan, tổ chức, website dạy học qua mạng, hệ thống máy tính phục vụ cho nhu cầu tính cước, phần mềm trên các thiết bị di động hoặc những chương trình giải trí trên Internet v.v… Bởi vậy, đối tượng phục vụ của ngành CNTT ngày càng phong phú.", "7480201", "Lập trình mobile", true, 200, "2 năm", 12000000m, false },
                    { "SRM", "HCM", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "7340101", "Quản trị nhà hàng", true, 200, "24 năm", 12000000m, false },
                    { "SSM", "HCM", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "7340101", "Marketing", true, 200, "2 năm", 12000000m, false },
                    { "SSO", "HCM", "Ngành “Tiếng Anh” bậc TCCN là ngành học cung cấp cho người học kiến thức cơ bản về ngôn ngữ và rèn luyện các kỹ năng Tiếng Anh cơ bản giúp người học sử dụng tốt trong môi trường toàn cầu hoá. Ngành tiếng Anh bậc TCCN bao gồm các môn học rèn luyện bốn kỹ năng trong tiếng Anh là nghe, nói, đọc và viết; thảo luận và giao tiếp tiếng Anh cơ bản; thực hiện các bảng biểu và mẫu đơn cơ bản bằng tiếng Anh; trình bày và truyền đạt quan điểm về các chủ đề thường gặp; thuyết trình tiếng Anh cơ bản; đọc hiểu các tài liệu thương mại và thư tín cơ bản; viết các mẫu thông báo, thư tín và tài liệu Tiếng Anh cơ. Ngành “Tiếng Anh” bậc TCCN còn giúp người học đạt được năng lực tiếng Anh B1 theo Khung tham chiếu trình độ ngôn ngữ chung Châu Âu (CEFR) và có thể học liên thông trình độ Cao đẳng.", "71490", "Thư ký văn phòng", true, 200, "24 năm", 12000000m, false },
                    { "STE", "HCM", "Tin học ứng dụng (CNTT) sử dụng hệ thống các thiết bị và máy tính (bao gồm phần cứng, phần mềm) để cung cấp một giải pháp xử lý thông tin trên nền công nghệ cho các cá nhân, tổ chức có yêu cầu. Các giải pháp CNTT rất đa dạng: phần mềm quản lý nhân viên trong cơ quan, tổ chức, website dạy học qua mạng, hệ thống máy tính phục vụ cho nhu cầu tính cước, phần mềm trên các thiết bị di động hoặc những chương trình giải trí trên Internet v.v… Bởi vậy, đối tượng phục vụ của ngành CNTT ngày càng phong phú.", "7480201", "Kiểm thử", true, 200, "2 năm", 12000000m, false },
                    { "SWE", "HCM", "Tin học ứng dụng (CNTT) sử dụng hệ thống các thiết bị và máy tính (bao gồm phần cứng, phần mềm) để cung cấp một giải pháp xử lý thông tin trên nền công nghệ cho các cá nhân, tổ chức có yêu cầu. Các giải pháp CNTT rất đa dạng: phần mềm quản lý nhân viên trong cơ quan, tổ chức, website dạy học qua mạng, hệ thống máy tính phục vụ cho nhu cầu tính cước, phần mềm trên các thiết bị di động hoặc những chương trình giải trí trên Internet v.v… Bởi vậy, đối tượng phục vụ của ngành CNTT ngày càng phong phú.", "7480201", "Lập trình web", true, 200, "2 năm", 12000000m, false }
                });

            migrationBuilder.InsertData(
                table: "Slider",
                columns: new[] { "SliderId", "CampusId", "Img" },
                values: new object[,]
                {
                    { 1, "Hanoi", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider1.jpg?alt=media&token=8018950a-e9d4-4c97-a81c-2bcea05d72ce" },
                    { 2, "Hanoi", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider2.jpg?alt=media&token=cc8a3de5-1155-4aba-9463-d4108b93330d" },
                    { 4, "Danang", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider1.jpg?alt=media&token=8018950a-e9d4-4c97-a81c-2bcea05d72ce" },
                    { 5, "Danang", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider2.jpg?alt=media&token=cc8a3de5-1155-4aba-9463-d4108b93330d" },
                    { 7, "HCM", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider1.jpg?alt=media&token=8018950a-e9d4-4c97-a81c-2bcea05d72ce" },
                    { 8, "HCM", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider2.jpg?alt=media&token=cc8a3de5-1155-4aba-9463-d4108b93330d" },
                    { 10, "Cantho", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider1.jpg?alt=media&token=8018950a-e9d4-4c97-a81c-2bcea05d72ce" },
                    { 11, "Cantho", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider2.jpg?alt=media&token=cc8a3de5-1155-4aba-9463-d4108b93330d" },
                    { 13, "Thanhhoa", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider1.jpg?alt=media&token=8018950a-e9d4-4c97-a81c-2bcea05d72ce" },
                    { 14, "Thanhhoa", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Banner%2FSlider2.jpg?alt=media&token=cc8a3de5-1155-4aba-9463-d4108b93330d" }
                });

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "BlogId", "BlogCategoryId", "Content", "DateCreate", "Description", "Img", "Title" },
                values: new object[,]
                {
                    { 1, 3, "Trăng tròn đã vươn cao tại Hoà Lạc, Rằm tháng Tám đã gần đi qua, các Cóc “ngoan xinh iu” của FPTU đã đi chơi Trung thu về chưa? \r\n🥮 Trung thu là dịp để chúng ta ngồi lại bên nhau, hàn huyên với gia đình, bạn bè và những người thân yêu. Hãy cùng tận hưởng Tết Trung Thu bên bánh dẻo, bánh nướng và thả mình vào ánh trăng lung linh để cảm nhận những khoảnh khắc tuyệt diệu, đáng quý này nhé!\r\n✨ Nhân dịp Tết Trung thu, xin gửi những lời chúc tốt đẹp nhất đến thầy cô, anh chị cán bộ trường Đại học FPT, cùng các bạn sinh viên thân yêu! Chúc mọi người một mùa trăng an yên hơn sau những ảnh hưởng lớn của bão vừa qua.\r\n 📌 VÀ ĐỪNG QUÊN lên dây cót, bật chế độ sẵn sàng đón chờ những sự kiện “cực kỳ hoành tráng” đang tới gần. Kết nối, khám phá và trải nghiệm hết mình trong kỳ fall này bạn nhé!", new DateTime(2024, 10, 30, 16, 1, 3, 514, DateTimeKind.Local).AddTicks(4263), "Trăng tròn đã vươn cao tại Hoà Lạc, Rằm tháng Tám đã gần đi qua, các Cóc “ngoan xinh iu” của FPTU đã đi chơi Trung thu về chưa?", null, "Trăng tròn đã vươn cao tại Hoà Lạc" },
                    { 2, 3, "[𝐊𝐈𝐂𝐊 𝐎𝐅𝐅] - 𝐉𝐈𝐌𝐁𝐎 𝐔𝐍𝐈𝐓𝐘 𝐅𝐄𝐒𝐓\r\n🏞 Tại vùng đất Hola Campus, nơi mà tinh thần học tập, sáng tạo nghệ thuật và sức mạnh thể chất được đề cao luôn tồn tại một lực lượng quân chủng mang tên 𝐉𝐢𝐦𝐛𝐨 𝐀𝐫𝐦𝐲 - mang trong mình trọng trách quan trọng nhất đó là bảo vệ và phát triển lãnh thổ với ba đại đội: Cơ bắp, Biết tuốt và Bay bổng. \r\n✨ Vào năm 2024, những người đứng đầu của 𝐉𝐢𝐦𝐛𝐨 𝐀𝐫𝐦𝐲 đã quyết định tổ chức một sự kiện, một ngày hội đặc biệt mang tên 𝐽𝑖𝑚𝑏𝑜 𝑈𝑛𝑖𝑡𝑦 𝐹𝑒𝑠𝑡. Sự kiện là dịp để các chiến sĩ của cả 3 Đại đội gặp mặt, giao lưu và học hỏi lẫn nhau không chỉ về tinh thần đồng đội mà còn được khám phá thêm những kỹ năng từ các đội khác. \r\n🌷 Đặc biệt, 𝐽𝑖𝑚𝑏𝑜 𝑈𝑛𝑖𝑡𝑦 𝐹𝑒𝑠𝑡 không chỉ giới hạn cho các chiến sĩ của 𝐉𝐢𝐦𝐛𝐨 𝐀𝐫𝐦𝐲 mà còn mở cửa chào đón tất cả những người trẻ của vùng đất Hola Campus có quan tâm và muốn trải nghiệm môi trường, văn hóa đặc trưng của 𝐉𝐢𝐦𝐛𝐨 𝐀𝐫𝐦𝐲 tham gia sự kiện. Nếu như bạn đã sẵn sàng với các chiến binh bước vào thế giới của 𝐉𝐢𝐦𝐛𝐨 𝐀𝐫𝐦𝐲 cùng một tinh thần nhiệt huyết và tràn đầy năng lượng để vượt qua những thử thách đầy cam go thì hãy cùng chúng mình đón chờ hành trình sắp tới nhé!\r\n---------------------------------------\r\n🔥 𝐉𝐈𝐌𝐁𝐎 𝐔𝐍𝐈𝐓𝐘 𝐅𝐄𝐒𝐓 🔥\r\n◻️ Thời gian: 13h - 17h30 thứ hai, ngày 30/09/2024\r\n◻️ Địa điểm: Đường 30m, Đại học FPT Hà Nội \r\n---------------------------------------\r\nTHÔNG TIN LIÊN HỆ\r\n◻️ Trưởng ban Tổ chức: Kiều Bảo Lộc (0367488155)\r\n◻️ Trưởng ban HR: Nguyễn Ngọc Quỳnh (0865349170)", new DateTime(2024, 10, 30, 16, 1, 3, 514, DateTimeKind.Local).AddTicks(4272), " 𝐉𝐢𝐦𝐛𝐨 𝐀𝐫𝐦𝐲 - mang trong mình trọng trách quan trọng nhất đó là bảo vệ và phát triển lãnh thổ với ba đại đội: Cơ bắp, Biết tuốt và Bay bổng.", null, "[𝐊𝐈𝐂𝐊 𝐎𝐅𝐅] - 𝐉𝐈𝐌𝐁𝐎 𝐔𝐍𝐈𝐓𝐘 𝐅𝐄𝐒𝐓" },
                    { 3, 2, "🌟[ORIENTATION WEEK]🌟 GIỚI THIỆU CÁC PHÒNG BAN CHỨC NĂNG TẠI ĐẠI HỌC FPT\r\n🔥Ngay lúc này đây, Phòng Hợp tác Quốc tế và Phát triển Cá nhân ICPDP đang có mặt tại Hội trường NIC cùng các tân sinh viên K20 tham gia Buổi học định hướng với chủ đề “Giới thiệu các phòng ban tại Đại học FPT”.\r\n🔥Tại buổi định hướng, các Cóc út đã được lắng nghe anh Lê Huy Hoàng - Cán bộ quản lý IC, đại diện phòng ICPDP chia sẻ về vai trò và chức năng của Phòng ICPDP, về các cơ hội học tập, trải nghiệm trong và ngoài nước dành cho tất cả các bạn sinh viên FPT.\r\n🫶Phòng ICPDP rất sẵn lòng đồng hành cùng các Cóc trong hành trình 4 năm thanh xuân tại Đại học FPT. Hy vọng chúng mình sẽ có thật nhiều kỷ niệm tại Đại học FPT Hà Nội. \r\n-----------------------------------------------------------\r\nMọi thắc mắc vui lòng liên hệ: Phòng Hợp tác Quốc tế và Phát triển cá nhân ICPDP FPTU", new DateTime(2024, 10, 30, 16, 1, 3, 514, DateTimeKind.Local).AddTicks(4273), " Giới thiệu các phòng ban tại Đại học FPT", null, "🌟[ORIENTATION WEEK]🌟 GIỚI THIỆU CÁC PHÒNG BAN CHỨC NĂNG TẠI ĐẠI HỌC FPT" },
                    { 4, 1, " 🌈 Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).\r\n🕰️ Thời gian: \r\nSáng: 8h -12h\r\nChiều: 13h30- 17h30\r\n✅ Các bạn học sinh và phụ huynh lưu ý, khi đến trường thì vào CỔNG SỐ 1 - chỗ cây ATM TP Bank màu tím và đi vào Văn phòng tuyển sinh từ lớp 12 trở lên để làm thủ tục nhập học.\r\n👉 Còn đợi gì nữa, xách balo lên trường nộp hồ sơ và tham quan ngay nào!", new DateTime(2024, 10, 30, 16, 1, 3, 514, DateTimeKind.Local).AddTicks(4273), " Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).", null, "🔈 THÔNG BÁO: VĂN PHÒNG TUYỂN SINH CỦA FPT POLYTECHNIC HÀ NỘI SẼ LÀM VIỆC CẢ TUẦN 🔈" },
                    { 5, 1, " 🌈 Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).\r\n🕰️ Thời gian: \r\nSáng: 8h -12h\r\nChiều: 13h30- 17h30\r\n✅ Các bạn học sinh và phụ huynh lưu ý, khi đến trường thì vào CỔNG SỐ 1 - chỗ cây ATM TP Bank màu tím và đi vào Văn phòng tuyển sinh từ lớp 12 trở lên để làm thủ tục nhập học.\r\n👉 Còn đợi gì nữa, xách balo lên trường nộp hồ sơ và tham quan ngay nào!", new DateTime(2024, 10, 30, 16, 1, 3, 514, DateTimeKind.Local).AddTicks(4274), " Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).", null, "🔈 THÔNG BÁO: VĂN PHÒNG TUYỂN SINH CỦA FPT POLYTECHNIC HÀ NỘI SẼ LÀM VIỆC CẢ TUẦN 🔈" },
                    { 6, 1, " 🌈 Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).\r\n🕰️ Thời gian: \r\nSáng: 8h -12h\r\nChiều: 13h30- 17h30\r\n✅ Các bạn học sinh và phụ huynh lưu ý, khi đến trường thì vào CỔNG SỐ 1 - chỗ cây ATM TP Bank màu tím và đi vào Văn phòng tuyển sinh từ lớp 12 trở lên để làm thủ tục nhập học.\r\n👉 Còn đợi gì nữa, xách balo lên trường nộp hồ sơ và tham quan ngay nào!", new DateTime(2024, 10, 30, 16, 1, 3, 514, DateTimeKind.Local).AddTicks(4275), " Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).", null, "🔈 THÔNG BÁO: VĂN PHÒNG TUYỂN SINH CỦA FPT POLYTECHNIC HÀ NỘI SẼ LÀM VIỆC CẢ TUẦN 🔈" },
                    { 7, 1, " 🌈 Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).\r\n🕰️ Thời gian: \r\nSáng: 8h -12h\r\nChiều: 13h30- 17h30\r\n✅ Các bạn học sinh và phụ huynh lưu ý, khi đến trường thì vào CỔNG SỐ 1 - chỗ cây ATM TP Bank màu tím và đi vào Văn phòng tuyển sinh từ lớp 12 trở lên để làm thủ tục nhập học.\r\n👉 Còn đợi gì nữa, xách balo lên trường nộp hồ sơ và tham quan ngay nào!", new DateTime(2024, 10, 30, 16, 1, 3, 514, DateTimeKind.Local).AddTicks(4276), " Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).", null, "🔈 THÔNG BÁO: VĂN PHÒNG TUYỂN SINH CỦA FPT POLYTECHNIC HÀ NỘI SẼ LÀM VIỆC CẢ TUẦN 🔈" },
                    { 8, 1, " 🌈 Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).\r\n🕰️ Thời gian: \r\nSáng: 8h -12h\r\nChiều: 13h30- 17h30\r\n✅ Các bạn học sinh và phụ huynh lưu ý, khi đến trường thì vào CỔNG SỐ 1 - chỗ cây ATM TP Bank màu tím và đi vào Văn phòng tuyển sinh từ lớp 12 trở lên để làm thủ tục nhập học.\r\n👉 Còn đợi gì nữa, xách balo lên trường nộp hồ sơ và tham quan ngay nào!", new DateTime(2024, 10, 30, 16, 1, 3, 514, DateTimeKind.Local).AddTicks(4276), " Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).", null, "🔈 THÔNG BÁO: VĂN PHÒNG TUYỂN SINH CỦA FPT POLYTECHNIC HÀ NỘI SẼ LÀM VIỆC CẢ TUẦN 🔈" },
                    { 9, 1, " 🌈 Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).\r\n🕰️ Thời gian: \r\nSáng: 8h -12h\r\nChiều: 13h30- 17h30\r\n✅ Các bạn học sinh và phụ huynh lưu ý, khi đến trường thì vào CỔNG SỐ 1 - chỗ cây ATM TP Bank màu tím và đi vào Văn phòng tuyển sinh từ lớp 12 trở lên để làm thủ tục nhập học.\r\n👉 Còn đợi gì nữa, xách balo lên trường nộp hồ sơ và tham quan ngay nào!", new DateTime(2024, 10, 30, 16, 1, 3, 514, DateTimeKind.Local).AddTicks(4277), " Để phục vụ nhu cầu tư vấn, đăng ký nhập học của các bạn học sinh, bắt đầu từ tuần này Văn phòng tuyển sinh của Trường Cao đẳng FPT Polytechnic Hà Nội sẽ làm việc tất cả các ngày trong tuần (từ thứ 2 đến thứ bảy).", null, "🔈 THÔNG BÁO: VĂN PHÒNG TUYỂN SINH CỦA FPT POLYTECHNIC HÀ NỘI SẼ LÀM VIỆC CẢ TUẦN 🔈" }
                });

            migrationBuilder.InsertData(
                table: "RequestChangeMajor",
                columns: new[] { "RequestID", "AccountId", "CampusId", "DateRequest", "Description", "FileReasonRequestChangeMajor", "MajorNew", "Status" },
                values: new object[,]
                {
                    { 1, new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"), "Hanoi", new DateTime(2024, 10, 30, 16, 1, 3, 514, DateTimeKind.Local).AddTicks(4408), "Em muốn chuyển ngành!", "file", "HME", false },
                    { 2, new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"), "Hanoi", new DateTime(2024, 10, 30, 16, 1, 3, 514, DateTimeKind.Local).AddTicks(4411), "Em muốn chuyển ngành!", "file", "HME", false }
                });

            migrationBuilder.InsertData(
                table: "StudentConsultation",
                columns: new[] { "StudentConsultationId", "CampusId", "DateReceive", "Email", "FullName", "LinkFB", "MajorID", "Notes", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("536443af-5629-4982-b750-aaa848a9757a"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 3 },
                    { new Guid("d35f2d0b-7f03-42ff-a3f9-93f65ee5d258"), "Hanoi", new DateTime(2024, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), "nguyenducanh01.57@gmail.com", "Nguyen Đức Anh", "https://www.facebook.com/profile.php?id=61551770462937", "HME", null, "0123456789", 0 }
                });

            migrationBuilder.InsertData(
                table: "StudentProfile",
                columns: new[] { "SpId", "AccountId", "AddressRecipientResults", "CIAddress", "CIDate", "CampusId", "CitizenIentificationNumber", "District", "Dob", "EmailStudent", "Fullname", "FullnameParents", "Gender", "ImgAcademicTranscript1", "ImgAcademicTranscript2", "ImgAcademicTranscript3", "ImgAcademicTranscript4", "ImgAcademicTranscript5", "ImgCitizenIdentification1", "ImgCitizenIdentification2", "ImgDiploma", "Imgpriority", "Major1", "Major2", "Nation", "PermanentAddress", "PhoneParents", "PhoneStudent", "PriorityDetailPriorityID", "PriorityID", "Province", "RecipientResults", "SchoolName", "SpecificAddress", "StudentCode", "TypeOfDiploma", "TypeOfTranscript", "TypeofStatus", "Ward", "YearOfGraduation" },
                values: new object[] { new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa"), null, "HCM", new DateTime(2024, 10, 30, 16, 1, 3, 514, DateTimeKind.Local).AddTicks(4375), "Hanoi", "038301012121", null, new DateTime(2024, 10, 30, 16, 1, 3, 514, DateTimeKind.Local).AddTicks(4377), "nguyenducanh01.57@gmail.com", "Nguyễn Đức Anh", null, true, null, null, null, null, null, null, null, null, null, "HAO", null, null, null, null, "0971341555", null, null, null, null, null, null, null, null, null, 0, null, null });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "MajorID", "SubjectCode", "Note", "NumberOfCredits", "SemesterNumber", "StudyTime", "SubjectName" },
                values: new object[,]
                {
                    { "HGE", "DBI101", null, 3, 3, "4 tháng", "Cơ sở lập trình" },
                    { "HME", "DBI101", null, 3, 3, "4 tháng", "Cơ sở lập trình" },
                    { "HTE", "DBI101", null, 3, 3, "4 tháng", "Cơ sở lập trình" },
                    { "HWE", "DBI101", null, 3, 3, "4 tháng", "Cơ sở lập trình" },
                    { "SGE", "DBI101", null, 3, 3, "4 tháng", "Cơ sở lập trình" },
                    { "SME", "DBI101", null, 3, 3, "4 tháng", "Cơ sở lập trình" },
                    { "STE", "DBI101", null, 3, 3, "4 tháng", "Cơ sở lập trình" },
                    { "SWE", "DBI101", null, 3, 3, "4 tháng", "Cơ sở lập trình" },
                    { "HAO", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "HBS", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "HBT", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "HEA", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "HFO", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "HGE", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "HHM", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "HJA", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "HKA", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "HME", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "HRM", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "HSM", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "HSO", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "HTE", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "HWE", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "SAO", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "SBS", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "SBT", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "SEA", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "SFO", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "MajorID", "SubjectCode", "Note", "NumberOfCredits", "SemesterNumber", "StudyTime", "SubjectName" },
                values: new object[,]
                {
                    { "SGE", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "SHM", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "SJA", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "SKA", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "SME", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "SRM", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "SSM", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "SSO", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "STE", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "SWE", "ENG101", null, 3, 0, "2 tháng", "Tiếng anh 1" },
                    { "HAO", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "HBS", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "HBT", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "HEA", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "HFO", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "HGE", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "HHM", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "HJA", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "HKA", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "HME", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "HRM", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "HSM", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "HSO", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "HTE", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "HWE", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "SAO", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "SBS", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "SBT", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "SEA", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "SFO", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "SGE", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "SHM", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "SJA", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "SKA", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "SME", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "SRM", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "SSM", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "SSO", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "STE", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "SWE", "ENG102", null, 3, 0, "2 tháng", "Tiếng anh 2" },
                    { "HAO", "ENG103", null, 3, 0, "2 tháng", "Tiếng anh 3" },
                    { "HEA", "ENG103", null, 3, 0, "2 tháng", "Tiếng anh 3" }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "MajorID", "SubjectCode", "Note", "NumberOfCredits", "SemesterNumber", "StudyTime", "SubjectName" },
                values: new object[,]
                {
                    { "HHM", "ENG103", null, 3, 0, "2 tháng", "Tiếng anh 3" },
                    { "HME", "ENG103", null, 3, 0, "2 tháng", "Tiếng anh 3" },
                    { "HRM", "ENG103", null, 3, 0, "2 tháng", "Tiếng anh 3" },
                    { "HSM", "ENG103", null, 3, 0, "2 tháng", "Tiếng anh 3" },
                    { "SAO", "ENG103", null, 3, 0, "2 tháng", "Tiếng anh 3" },
                    { "SEA", "ENG103", null, 3, 0, "2 tháng", "Tiếng anh 3" },
                    { "SHM", "ENG103", null, 3, 0, "2 tháng", "Tiếng anh 3" },
                    { "SME", "ENG103", null, 3, 0, "2 tháng", "Tiếng anh 3" },
                    { "SRM", "ENG103", null, 3, 0, "2 tháng", "Tiếng anh 3" },
                    { "SSM", "ENG103", null, 3, 0, "2 tháng", "Tiếng anh 3" },
                    { "HAO", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "HBS", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "HBT", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "HEA", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "HFO", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "HGE", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "HHM", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "HJA", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "HKA", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "HME", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "HRM", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "HSM", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "HSO", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "HTE", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "HWE", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "SAO", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "SBS", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "SBT", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "SEA", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "SFO", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "SGE", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "SHM", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "SJA", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "SKA", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "SME", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "SRM", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "SSM", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "SSO", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "STE", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "SWE", "GDQP", null, 0, 0, "1 tháng", "Giáo dục quốc phòng" },
                    { "HGE", "MAD101", null, 3, 2, "4 tháng", "Toán cho ngành kỹ thuật" },
                    { "HME", "MAD101", null, 3, 2, "4 tháng", "Toán cho ngành kỹ thuật" }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "MajorID", "SubjectCode", "Note", "NumberOfCredits", "SemesterNumber", "StudyTime", "SubjectName" },
                values: new object[,]
                {
                    { "HTE", "MAD101", null, 3, 2, "4 tháng", "Toán cho ngành kỹ thuật" },
                    { "HWE", "MAD101", null, 3, 2, "4 tháng", "Toán cho ngành kỹ thuật" },
                    { "SGE", "MAD101", null, 3, 2, "4 tháng", "Toán cho ngành kỹ thuật" },
                    { "SME", "MAD101", null, 3, 2, "4 tháng", "Toán cho ngành kỹ thuật" },
                    { "STE", "MAD101", null, 3, 2, "4 tháng", "Toán cho ngành kỹ thuật" },
                    { "SWE", "MAD101", null, 3, 2, "4 tháng", "Toán cho ngành kỹ thuật" },
                    { "HGE", "MAE101", null, 3, 1, "4 tháng", "Toán rời rạc" },
                    { "HME", "MAE101", null, 3, 1, "4 tháng", "Toán rời rạc" },
                    { "HTE", "MAE101", null, 3, 1, "4 tháng", "Toán rời rạc" },
                    { "HWE", "MAE101", null, 3, 1, "4 tháng", "Toán rời rạc" },
                    { "SGE", "MAE101", null, 3, 1, "4 tháng", "Toán rời rạc" },
                    { "SME", "MAE101", null, 3, 1, "4 tháng", "Toán rời rạc" },
                    { "STE", "MAE101", null, 3, 1, "4 tháng", "Toán rời rạc" },
                    { "SWE", "MAE101", null, 3, 1, "4 tháng", "Toán rời rạc" },
                    { "HGE", "PRF101", null, 3, 1, "4 tháng", "Cơ sở lập trình" },
                    { "HME", "PRF101", null, 3, 1, "4 tháng", "Cơ sở lập trình" },
                    { "HTE", "PRF101", null, 3, 1, "4 tháng", "Cơ sở lập trình" },
                    { "HWE", "PRF101", null, 3, 1, "4 tháng", "Cơ sở lập trình" },
                    { "SGE", "PRF101", null, 3, 1, "4 tháng", "Cơ sở lập trình" },
                    { "SME", "PRF101", null, 3, 1, "4 tháng", "Cơ sở lập trình" },
                    { "STE", "PRF101", null, 3, 1, "4 tháng", "Cơ sở lập trình" },
                    { "SWE", "PRF101", null, 3, 1, "4 tháng", "Cơ sở lập trình" }
                });

            migrationBuilder.InsertData(
                table: "TypeAdmission",
                columns: new[] { "MajorID", "TypeDiploma", "TypeOfTranscript" },
                values: new object[,]
                {
                    { "HGE", 1, null },
                    { "HGE", 2, null },
                    { "HME", 1, null },
                    { "HME", 2, null },
                    { "HWE", 1, null },
                    { "HWE", 2, null },
                    { "HWE", 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("602f7a5f-e0a7-4c00-9da0-a413bfcfab3a"), new Guid("17baf918-d5d2-4628-aad1-8a4926520676") },
                    { new Guid("d2d63c5b-d09b-4828-8322-f18ba103fe86"), new Guid("2f36ad81-47c3-4194-9af8-ba19300695aa") },
                    { new Guid("62378687-e16c-4d94-b767-de9f0bfe9498"), new Guid("5738248d-b40e-4332-9b9e-deb0abc8f8dd") },
                    { new Guid("e5ec8836-e240-4bfc-9bbe-33f2cc7a404d"), new Guid("aa321fa2-d640-449f-9cf3-d5a14001aa3e") },
                    { new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"), new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7") }
                });

            migrationBuilder.InsertData(
                table: "AcademicTranscript",
                columns: new[] { "ATId", "SpId", "SubjectName", "SubjectPoint", "TypeOfAcademicTranscript" },
                values: new object[] { new Guid("6ad442aa-24bd-4d74-93c3-828dc0af2d3a"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Anh", 9m, 2 });

            migrationBuilder.InsertData(
                table: "AcademicTranscript",
                columns: new[] { "ATId", "SpId", "SubjectName", "SubjectPoint", "TypeOfAcademicTranscript" },
                values: new object[] { new Guid("aa00897b-112f-419d-80b8-7fb3cf13520d"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Văn", 9m, 1 });

            migrationBuilder.InsertData(
                table: "AcademicTranscript",
                columns: new[] { "ATId", "SpId", "SubjectName", "SubjectPoint", "TypeOfAcademicTranscript" },
                values: new object[] { new Guid("e884f15d-2b87-443d-bb45-bf0bd19986a2"), new Guid("41a2ad7d-1af6-464e-bbf4-0d18ae664851"), "Toán", 9m, 0 });

            migrationBuilder.CreateIndex(
                name: "IX_AcademicTranscript_SpId",
                table: "AcademicTranscript",
                column: "SpId");

            migrationBuilder.CreateIndex(
                name: "IX_Account_CampusId",
                table: "Account",
                column: "CampusId");

            migrationBuilder.CreateIndex(
                name: "IX_AdmissionGroup_CampusId",
                table: "AdmissionGroup",
                column: "CampusId");

            migrationBuilder.CreateIndex(
                name: "IX_AdmissionInformation_CampusId",
                table: "AdmissionInformation",
                column: "CampusId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AdmissionTime_CampusId",
                table: "AdmissionTime",
                column: "CampusId");

            migrationBuilder.CreateIndex(
                name: "IX_Blog_BlogCategoryId",
                table: "Blog",
                column: "BlogCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogCategory_CampusId",
                table: "BlogCategory",
                column: "CampusId");

            migrationBuilder.CreateIndex(
                name: "IX_Major_CampusId",
                table: "Major",
                column: "CampusId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestChangeMajor_AccountId",
                table: "RequestChangeMajor",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestChangeMajor_CampusId",
                table: "RequestChangeMajor",
                column: "CampusId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestChangeMajor_MajorNew",
                table: "RequestChangeMajor",
                column: "MajorNew");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Slider_CampusId",
                table: "Slider",
                column: "CampusId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentConsultation_CampusId",
                table: "StudentConsultation",
                column: "CampusId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentConsultation_MajorID",
                table: "StudentConsultation",
                column: "MajorID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentProfile_AccountId",
                table: "StudentProfile",
                column: "AccountId",
                unique: true,
                filter: "[AccountId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_StudentProfile_CampusId",
                table: "StudentProfile",
                column: "CampusId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentProfile_PriorityDetailPriorityID",
                table: "StudentProfile",
                column: "PriorityDetailPriorityID");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_MajorID",
                table: "Subject",
                column: "MajorID");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcademicTranscript");

            migrationBuilder.DropTable(
                name: "AdmissionGroup");

            migrationBuilder.DropTable(
                name: "AdmissionInformation");

            migrationBuilder.DropTable(
                name: "AdmissionTime");

            migrationBuilder.DropTable(
                name: "Blog");

            migrationBuilder.DropTable(
                name: "RequestChangeMajor");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Slider");

            migrationBuilder.DropTable(
                name: "StudentConsultation");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropTable(
                name: "TypeAdmission");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "StudentProfile");

            migrationBuilder.DropTable(
                name: "BlogCategory");

            migrationBuilder.DropTable(
                name: "Major");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "PriorityDetail");

            migrationBuilder.DropTable(
                name: "Campus");
        }
    }
}
