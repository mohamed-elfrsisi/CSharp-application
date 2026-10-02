using Microsoft.Data.SqlClient;

namespace CourseMng;

public class GetAllCourses
{
    private string ConnectionString;
    public GetAllCourses(string ConnectionString) => this.ConnectionString = ConnectionString;

    public List<courses> Excute()
    {
        List<courses> list = new List<courses>();
        
        SqlConnection connection = new SqlConnection();
        connection.ConnectionString = ConnectionString;

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = connection;
        cmd.CommandText = "Select Id,CName,CDept from courses order by Id";

        try
        {
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                string dept = reader.GetString(2);

                courses course = new courses(id,name, dept);
                list.Add(course);
            }

            reader.Close();
        }
        finally
        {
            connection.Close();
        }

        return list;
    }
}