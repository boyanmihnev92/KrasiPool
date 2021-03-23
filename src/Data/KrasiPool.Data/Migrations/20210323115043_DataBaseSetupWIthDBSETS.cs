using Microsoft.EntityFrameworkCore.Migrations;

namespace KrasiPool.Data.Migrations
{
    public partial class DataBaseSetupWIthDBSETS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Polygon_PolygonId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAssignment_Customer_CustomerId",
                table: "CustomerAssignment");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAssignment_Polygon_PolygonId",
                table: "CustomerAssignment");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerRequest_Customer_CustomerId",
                table: "CustomerRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerRequest_ServiceType_ServiceTypeId",
                table: "CustomerRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_Polygon_AspNetUsers_UserId",
                table: "Polygon");

            migrationBuilder.DropForeignKey(
                name: "FK_Service_AspNetUsers_UserId",
                table: "Service");

            migrationBuilder.DropForeignKey(
                name: "FK_Service_ServiceType_ServiceTypeId",
                table: "Service");

            migrationBuilder.DropForeignKey(
                name: "FK_Service_Status_StatusId",
                table: "Service");

            migrationBuilder.DropForeignKey(
                name: "FK_Service_Survey_SurveyId",
                table: "Service");

            migrationBuilder.DropForeignKey(
                name: "FK_Service_Visit_VisitId",
                table: "Service");

            migrationBuilder.DropForeignKey(
                name: "FK_ServicePrice_ServiceType_ServiceTypeId",
                table: "ServicePrice");

            migrationBuilder.DropForeignKey(
                name: "FK_SurveyAnswer_Service_ServiceId",
                table: "SurveyAnswer");

            migrationBuilder.DropForeignKey(
                name: "FK_SurveyAnswer_Survey_SurveyId",
                table: "SurveyAnswer");

            migrationBuilder.DropForeignKey(
                name: "FK_SurveyAnswer_SurveyQuestion_SurveyQuestionId",
                table: "SurveyAnswer");

            migrationBuilder.DropForeignKey(
                name: "FK_SurveyQuestion_Survey_SurveyId",
                table: "SurveyQuestion");

            migrationBuilder.DropForeignKey(
                name: "FK_Visit_AspNetUsers_UserId",
                table: "Visit");

            migrationBuilder.DropForeignKey(
                name: "FK_Visit_Customer_CustomerId",
                table: "Visit");

            migrationBuilder.DropForeignKey(
                name: "FK_Visit_Status_StatusId",
                table: "Visit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Visit",
                table: "Visit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SurveyQuestion",
                table: "SurveyQuestion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SurveyAnswer",
                table: "SurveyAnswer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Survey",
                table: "Survey");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Status",
                table: "Status");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceType",
                table: "ServiceType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServicePrice",
                table: "ServicePrice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Service",
                table: "Service");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Polygon",
                table: "Polygon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerRequest",
                table: "CustomerRequest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerAssignment",
                table: "CustomerAssignment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.RenameTable(
                name: "Visit",
                newName: "Visits");

            migrationBuilder.RenameTable(
                name: "SurveyQuestion",
                newName: "SurveyQuestions");

            migrationBuilder.RenameTable(
                name: "SurveyAnswer",
                newName: "SurveyAnswers");

            migrationBuilder.RenameTable(
                name: "Survey",
                newName: "Surveys");

            migrationBuilder.RenameTable(
                name: "Status",
                newName: "Statuses");

            migrationBuilder.RenameTable(
                name: "ServiceType",
                newName: "ServiceTypes");

            migrationBuilder.RenameTable(
                name: "ServicePrice",
                newName: "ServicePrices");

            migrationBuilder.RenameTable(
                name: "Service",
                newName: "Services");

            migrationBuilder.RenameTable(
                name: "Polygon",
                newName: "Polygons");

            migrationBuilder.RenameTable(
                name: "CustomerRequest",
                newName: "CustomerRequests");

            migrationBuilder.RenameTable(
                name: "CustomerAssignment",
                newName: "CustomerAssignments");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customers");

            migrationBuilder.RenameIndex(
                name: "IX_Visit_UserId",
                table: "Visits",
                newName: "IX_Visits_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Visit_StatusId",
                table: "Visits",
                newName: "IX_Visits_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Visit_IsDeleted",
                table: "Visits",
                newName: "IX_Visits_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Visit_CustomerId",
                table: "Visits",
                newName: "IX_Visits_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_SurveyQuestion_SurveyId",
                table: "SurveyQuestions",
                newName: "IX_SurveyQuestions_SurveyId");

            migrationBuilder.RenameIndex(
                name: "IX_SurveyAnswer_SurveyQuestionId",
                table: "SurveyAnswers",
                newName: "IX_SurveyAnswers_SurveyQuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_SurveyAnswer_SurveyId",
                table: "SurveyAnswers",
                newName: "IX_SurveyAnswers_SurveyId");

            migrationBuilder.RenameIndex(
                name: "IX_SurveyAnswer_ServiceId",
                table: "SurveyAnswers",
                newName: "IX_SurveyAnswers_ServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_ServicePrice_ServiceTypeId",
                table: "ServicePrices",
                newName: "IX_ServicePrices_ServiceTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Service_VisitId",
                table: "Services",
                newName: "IX_Services_VisitId");

            migrationBuilder.RenameIndex(
                name: "IX_Service_UserId",
                table: "Services",
                newName: "IX_Services_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Service_SurveyId",
                table: "Services",
                newName: "IX_Services_SurveyId");

            migrationBuilder.RenameIndex(
                name: "IX_Service_StatusId",
                table: "Services",
                newName: "IX_Services_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Service_ServiceTypeId",
                table: "Services",
                newName: "IX_Services_ServiceTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Service_IsDeleted",
                table: "Services",
                newName: "IX_Services_IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Descriptions",
                table: "Polygons",
                newName: "Description");

            migrationBuilder.RenameIndex(
                name: "IX_Polygon_UserId",
                table: "Polygons",
                newName: "IX_Polygons_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerRequest_ServiceTypeId",
                table: "CustomerRequests",
                newName: "IX_CustomerRequests_ServiceTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerRequest_CustomerId",
                table: "CustomerRequests",
                newName: "IX_CustomerRequests_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerAssignment_PolygonId",
                table: "CustomerAssignments",
                newName: "IX_CustomerAssignments_PolygonId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerAssignment_CustomerId",
                table: "CustomerAssignments",
                newName: "IX_CustomerAssignments_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_PolygonId",
                table: "Customers",
                newName: "IX_Customers_PolygonId");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_IsDeleted",
                table: "Customers",
                newName: "IX_Customers_IsDeleted");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Visits",
                table: "Visits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SurveyQuestions",
                table: "SurveyQuestions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SurveyAnswers",
                table: "SurveyAnswers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Surveys",
                table: "Surveys",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Statuses",
                table: "Statuses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceTypes",
                table: "ServiceTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServicePrices",
                table: "ServicePrices",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Services",
                table: "Services",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Polygons",
                table: "Polygons",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerRequests",
                table: "CustomerRequests",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerAssignments",
                table: "CustomerAssignments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CleaningProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetWeight = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CleaningProducts", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAssignments_Customers_CustomerId",
                table: "CustomerAssignments",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAssignments_Polygons_PolygonId",
                table: "CustomerAssignments",
                column: "PolygonId",
                principalTable: "Polygons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerRequests_Customers_CustomerId",
                table: "CustomerRequests",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerRequests_ServiceTypes_ServiceTypeId",
                table: "CustomerRequests",
                column: "ServiceTypeId",
                principalTable: "ServiceTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Polygons_PolygonId",
                table: "Customers",
                column: "PolygonId",
                principalTable: "Polygons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Polygons_AspNetUsers_UserId",
                table: "Polygons",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ServicePrices_ServiceTypes_ServiceTypeId",
                table: "ServicePrices",
                column: "ServiceTypeId",
                principalTable: "ServiceTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_AspNetUsers_UserId",
                table: "Services",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_ServiceTypes_ServiceTypeId",
                table: "Services",
                column: "ServiceTypeId",
                principalTable: "ServiceTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Statuses_StatusId",
                table: "Services",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Surveys_SurveyId",
                table: "Services",
                column: "SurveyId",
                principalTable: "Surveys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Visits_VisitId",
                table: "Services",
                column: "VisitId",
                principalTable: "Visits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SurveyAnswers_Services_ServiceId",
                table: "SurveyAnswers",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SurveyAnswers_SurveyQuestions_SurveyQuestionId",
                table: "SurveyAnswers",
                column: "SurveyQuestionId",
                principalTable: "SurveyQuestions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SurveyAnswers_Surveys_SurveyId",
                table: "SurveyAnswers",
                column: "SurveyId",
                principalTable: "Surveys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SurveyQuestions_Surveys_SurveyId",
                table: "SurveyQuestions",
                column: "SurveyId",
                principalTable: "Surveys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_AspNetUsers_UserId",
                table: "Visits",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_Customers_CustomerId",
                table: "Visits",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_Statuses_StatusId",
                table: "Visits",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAssignments_Customers_CustomerId",
                table: "CustomerAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAssignments_Polygons_PolygonId",
                table: "CustomerAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerRequests_Customers_CustomerId",
                table: "CustomerRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerRequests_ServiceTypes_ServiceTypeId",
                table: "CustomerRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Polygons_PolygonId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Polygons_AspNetUsers_UserId",
                table: "Polygons");

            migrationBuilder.DropForeignKey(
                name: "FK_ServicePrices_ServiceTypes_ServiceTypeId",
                table: "ServicePrices");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_AspNetUsers_UserId",
                table: "Services");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_ServiceTypes_ServiceTypeId",
                table: "Services");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_Statuses_StatusId",
                table: "Services");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_Surveys_SurveyId",
                table: "Services");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_Visits_VisitId",
                table: "Services");

            migrationBuilder.DropForeignKey(
                name: "FK_SurveyAnswers_Services_ServiceId",
                table: "SurveyAnswers");

            migrationBuilder.DropForeignKey(
                name: "FK_SurveyAnswers_SurveyQuestions_SurveyQuestionId",
                table: "SurveyAnswers");

            migrationBuilder.DropForeignKey(
                name: "FK_SurveyAnswers_Surveys_SurveyId",
                table: "SurveyAnswers");

            migrationBuilder.DropForeignKey(
                name: "FK_SurveyQuestions_Surveys_SurveyId",
                table: "SurveyQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_Visits_AspNetUsers_UserId",
                table: "Visits");

            migrationBuilder.DropForeignKey(
                name: "FK_Visits_Customers_CustomerId",
                table: "Visits");

            migrationBuilder.DropForeignKey(
                name: "FK_Visits_Statuses_StatusId",
                table: "Visits");

            migrationBuilder.DropTable(
                name: "CleaningProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Visits",
                table: "Visits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Surveys",
                table: "Surveys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SurveyQuestions",
                table: "SurveyQuestions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SurveyAnswers",
                table: "SurveyAnswers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Statuses",
                table: "Statuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceTypes",
                table: "ServiceTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Services",
                table: "Services");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServicePrices",
                table: "ServicePrices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Polygons",
                table: "Polygons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerRequests",
                table: "CustomerRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerAssignments",
                table: "CustomerAssignments");

            migrationBuilder.RenameTable(
                name: "Visits",
                newName: "Visit");

            migrationBuilder.RenameTable(
                name: "Surveys",
                newName: "Survey");

            migrationBuilder.RenameTable(
                name: "SurveyQuestions",
                newName: "SurveyQuestion");

            migrationBuilder.RenameTable(
                name: "SurveyAnswers",
                newName: "SurveyAnswer");

            migrationBuilder.RenameTable(
                name: "Statuses",
                newName: "Status");

            migrationBuilder.RenameTable(
                name: "ServiceTypes",
                newName: "ServiceType");

            migrationBuilder.RenameTable(
                name: "Services",
                newName: "Service");

            migrationBuilder.RenameTable(
                name: "ServicePrices",
                newName: "ServicePrice");

            migrationBuilder.RenameTable(
                name: "Polygons",
                newName: "Polygon");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customer");

            migrationBuilder.RenameTable(
                name: "CustomerRequests",
                newName: "CustomerRequest");

            migrationBuilder.RenameTable(
                name: "CustomerAssignments",
                newName: "CustomerAssignment");

            migrationBuilder.RenameIndex(
                name: "IX_Visits_UserId",
                table: "Visit",
                newName: "IX_Visit_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Visits_StatusId",
                table: "Visit",
                newName: "IX_Visit_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Visits_IsDeleted",
                table: "Visit",
                newName: "IX_Visit_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Visits_CustomerId",
                table: "Visit",
                newName: "IX_Visit_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_SurveyQuestions_SurveyId",
                table: "SurveyQuestion",
                newName: "IX_SurveyQuestion_SurveyId");

            migrationBuilder.RenameIndex(
                name: "IX_SurveyAnswers_SurveyQuestionId",
                table: "SurveyAnswer",
                newName: "IX_SurveyAnswer_SurveyQuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_SurveyAnswers_SurveyId",
                table: "SurveyAnswer",
                newName: "IX_SurveyAnswer_SurveyId");

            migrationBuilder.RenameIndex(
                name: "IX_SurveyAnswers_ServiceId",
                table: "SurveyAnswer",
                newName: "IX_SurveyAnswer_ServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_Services_VisitId",
                table: "Service",
                newName: "IX_Service_VisitId");

            migrationBuilder.RenameIndex(
                name: "IX_Services_UserId",
                table: "Service",
                newName: "IX_Service_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Services_SurveyId",
                table: "Service",
                newName: "IX_Service_SurveyId");

            migrationBuilder.RenameIndex(
                name: "IX_Services_StatusId",
                table: "Service",
                newName: "IX_Service_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Services_ServiceTypeId",
                table: "Service",
                newName: "IX_Service_ServiceTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Services_IsDeleted",
                table: "Service",
                newName: "IX_Service_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_ServicePrices_ServiceTypeId",
                table: "ServicePrice",
                newName: "IX_ServicePrice_ServiceTypeId");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Polygon",
                newName: "Descriptions");

            migrationBuilder.RenameIndex(
                name: "IX_Polygons_UserId",
                table: "Polygon",
                newName: "IX_Polygon_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_PolygonId",
                table: "Customer",
                newName: "IX_Customer_PolygonId");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_IsDeleted",
                table: "Customer",
                newName: "IX_Customer_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerRequests_ServiceTypeId",
                table: "CustomerRequest",
                newName: "IX_CustomerRequest_ServiceTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerRequests_CustomerId",
                table: "CustomerRequest",
                newName: "IX_CustomerRequest_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerAssignments_PolygonId",
                table: "CustomerAssignment",
                newName: "IX_CustomerAssignment_PolygonId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerAssignments_CustomerId",
                table: "CustomerAssignment",
                newName: "IX_CustomerAssignment_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Visit",
                table: "Visit",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Survey",
                table: "Survey",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SurveyQuestion",
                table: "SurveyQuestion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SurveyAnswer",
                table: "SurveyAnswer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Status",
                table: "Status",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceType",
                table: "ServiceType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Service",
                table: "Service",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServicePrice",
                table: "ServicePrice",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Polygon",
                table: "Polygon",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerRequest",
                table: "CustomerRequest",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerAssignment",
                table: "CustomerAssignment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Polygon_PolygonId",
                table: "Customer",
                column: "PolygonId",
                principalTable: "Polygon",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAssignment_Customer_CustomerId",
                table: "CustomerAssignment",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAssignment_Polygon_PolygonId",
                table: "CustomerAssignment",
                column: "PolygonId",
                principalTable: "Polygon",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerRequest_Customer_CustomerId",
                table: "CustomerRequest",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerRequest_ServiceType_ServiceTypeId",
                table: "CustomerRequest",
                column: "ServiceTypeId",
                principalTable: "ServiceType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Polygon_AspNetUsers_UserId",
                table: "Polygon",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Service_AspNetUsers_UserId",
                table: "Service",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Service_ServiceType_ServiceTypeId",
                table: "Service",
                column: "ServiceTypeId",
                principalTable: "ServiceType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Service_Status_StatusId",
                table: "Service",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Service_Survey_SurveyId",
                table: "Service",
                column: "SurveyId",
                principalTable: "Survey",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Service_Visit_VisitId",
                table: "Service",
                column: "VisitId",
                principalTable: "Visit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ServicePrice_ServiceType_ServiceTypeId",
                table: "ServicePrice",
                column: "ServiceTypeId",
                principalTable: "ServiceType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SurveyAnswer_Service_ServiceId",
                table: "SurveyAnswer",
                column: "ServiceId",
                principalTable: "Service",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SurveyAnswer_Survey_SurveyId",
                table: "SurveyAnswer",
                column: "SurveyId",
                principalTable: "Survey",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SurveyAnswer_SurveyQuestion_SurveyQuestionId",
                table: "SurveyAnswer",
                column: "SurveyQuestionId",
                principalTable: "SurveyQuestion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SurveyQuestion_Survey_SurveyId",
                table: "SurveyQuestion",
                column: "SurveyId",
                principalTable: "Survey",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Visit_AspNetUsers_UserId",
                table: "Visit",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Visit_Customer_CustomerId",
                table: "Visit",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Visit_Status_StatusId",
                table: "Visit",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
