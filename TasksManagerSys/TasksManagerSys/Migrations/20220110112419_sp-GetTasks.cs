using Microsoft.EntityFrameworkCore.Migrations;

namespace TasksManagerSys.Migrations
{
    public partial class spGetTasks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE TaskSearch
                        @TaskName NVARCHAR(max) NULL,
                        @ProjectId int NULL,
                        @AddedBy int null,
                        @Completed int null
                        AS
                        BEGIN
                        SET NOCOUNT ON;
                        SELECT t.Id, t.Task_desc , t.Added_date , t.Completed , p.Project_name, u.Fname , u.Lname
                        FROM tasks AS t
                        INNER JOIN projects as p
                        ON t.Project_id=p.Id
                        INNER JOIN AspNetUsers AS u
                        ON t.added_by=u.Id
                        WHERE Task_desc =ISNULL(@TaskName,Task_desc)
                        and Project_id = ISNULL(@ProjectId,Project_id)
                        and AddedBy=ISNULL(@AddedBy,AddedBy)
                        and Completed=ISNULL(@AddedBy,AddedBy)";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
