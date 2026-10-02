using Microsoft.Data.SqlClient;

namespace CourseMng;

public class AddCourse
{
    private string ConnectionString;
    public AddCourse(string connectionString) => this.ConnectionString = ConnectionString;

    public int Excute(courses course)
    {
        SqlConnection connection = new SqlConnection();
        connection.ConnectionString = ConnectionString;

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = connection;
        cmd.CommandText = "Insert Into courses(CName,CDept) output INSERTED.Id values(@name,@dept)";
        cmd.Parameters.AddWithValue("@name", course.CNAME);
        cmd.Parameters.AddWithValue("@dept", course.CDEPT);

        try
        {
            connection.Open();
            int newId = (int)cmd.ExecuteScalar();
            return newId;
        }
        finally
        {
            connection.Close();
        }
    }
}