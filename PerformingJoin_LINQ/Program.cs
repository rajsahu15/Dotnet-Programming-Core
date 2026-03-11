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
        string sqlQuery = @"SELECT e.*, d.DNAME, d.LOC 
                           FROM EMP e 
                           INNER JOIN DEPT d ON e.DEPARTMENT_ID = d.DEPTNO";

        SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, con);
        DataTable joinedTable = new DataTable();
        adapter.Fill(joinedTable);

        var employeesWithDept = joinedTable.AsEnumerable()
            .Select(row => new
            {
                ID = row.Field<int>("EMPLOYEE_ID"),
                FullName = row.Field<string>("FIRST_NAME") + " " + row.Field<string>("LAST_NAME"),
                Email = row.Field<string>("EMAIL"),
                DeptID = row.Field<short>("DEPARTMENT_ID"),
                DeptName = row.Field<string>("DNAME"),
                Location = row.Field<string>("LOC"),
                Salary = row.Field<decimal?>("SALARY"),
                HireDate = row.Field<DateTime>("HIRE_DATE")
            });

        // Simple display with string concatenation - no sorting/filtering
       Console.WriteLine("\n--- Employees with Department Information ---");
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("ID    | FullName                    | Email           | DeptName    | Location    | Salary      ");
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");

        foreach (var emp in employeesWithDept)
        {
            Console.WriteLine(emp.ID + "     | " +
                              emp.FullName + "\t\t\t" +
                              emp.Email + "               | " +
                              emp.DeptName + "            | " +
                              emp.Location + "            | " +
                              (emp.Salary ?? 0));
        }

        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");

    }
    catch (Exception ex)
    {
        Console.WriteLine("Error: " + ex.Message);
    }
}

