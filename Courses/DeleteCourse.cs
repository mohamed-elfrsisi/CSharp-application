using Microsoft.Data.SqlClient;

namespace CourseMng;

public class DeleteCourse
{
    private string connectionString;
    public DeleteCourse(string connectionString) => this.connectionString = connectionString;

    public bool Excute(courses course)
    {
        SqlConnection conenction = new SqlConnection();
        conenction.ConnectionString = connectionString;

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conenction;
        cmd.CommandText = "delete from courses where Id = @id";
        cmd.Parameters.AddWithValue("@id", course.ID);

        try
        {
            conenction.Open();
            int rows = cmd.ExecuteNonQuery();
            return rows > 0;
        }
        finally
        {
            conenction.Close();
        }
    }
}