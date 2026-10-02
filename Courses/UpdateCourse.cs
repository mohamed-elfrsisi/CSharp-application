using Microsoft.Data.SqlClient;

namespace CourseMng;

public class UpdateCourse
{
    private string ConnectionString;
    public UpdateCourse(string connectionString) => this.ConnectionString = connectionString;

    public bool Excute(courses course)
    {
        SqlConnection connection = new SqlConnection();
        connection.ConnectionString = ConnectionString;

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = connection;
        cmd.CommandText = "Update courses set CName = @name, CDept = @dept where Id = @id";
        cmd.Parameters.AddWithValue("@name", course.CNAME);
        cmd.Parameters.AddWithValue("@dept", course.CDEPT);

        try
        {
            connection.Open();
            int rows = cmd.ExecuteNonQuery();
            //return true if rows effected > 0 else return false
            return rows > 0;

        }
        finally
        {
            connection.Close();
        }
        
    }
}