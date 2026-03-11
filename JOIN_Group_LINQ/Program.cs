using System;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Linq;

string serverName = "localhost\\SQLEXPRESS";
string databaseName = "PracticeModule";

string connectionString = "Server=" + serverName + ";Database=" + databaseName + ";Trusted_Connection=True;TrustServerCertificate=True;";
using (SqlConnection con = new SqlConnection(connectionString))
{
    try
    {
        con.Open();
        string sqlQuery = "SELECT * FROM EMP";
        SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, con);
        DataTable empTable = new DataTable();
        adapter.Fill(empTable);

        // 1. Projection: Correcting the data type to short?
        var employees = from emp in empTable.AsEnumerable()
                        select new
                        {
                            ID = emp.Field<int>("EMPLOYEE_ID"),
                            FullName = emp.Field<string>("FIRST_NAME") + " " + emp.Field<string>("LAST_NAME"),
                            // Change int? to short? to match SQL SMALLINT
                            DeptID = emp.Field<short?>("DEPARTMENT_ID"),
                            Salary = emp.Field<decimal?>("SALARY")
                        };

        // 2. Grouping
        var groupedByDept = employees.GroupBy(e => e.DeptID)
                                     .Select(g => new {
                                         DeptID = g.Key,
                                         EmployeeCount = g.Count(),
                                         TotalPayroll = g.Sum(e => e.Salary ?? 0)
                                     });

        // 3. Output
        Console.WriteLine("\n--- Department Summary ---");
        foreach (var group in groupedByDept)
        {
            // Check for null and convert to string for concatenation
            string deptName = (group.DeptID == null) ? "No Dept" : group.DeptID.ToString();

            Console.WriteLine("Dept: " + deptName +
                              " | Staff: " + group.EmployeeCount +
                              " | Total Payroll: $" + group.TotalPayroll);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error: " + ex.Message);
    }
}