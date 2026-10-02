namespace CourseMng;

public class courses
{
    private int Id;
    private string CName;
    private string CDept;

    public int ID
    {
        get { return Id; }
        set
        {
            if (value <= 0) throw new Exception("not valid Id");
            Id = value;
        }
    }

    public string CNAME
    {
        get { return CName; }
        set
        {
            if(string.IsNullOrWhiteSpace(value)) throw new Exception("not valid CNAME");
            CName = value;
        }
    }

    public string CDEPT
    {
        get { return CDept; }
        set
        {
            if (value.Length <= 0) throw new Exception("Invalid Input");
            CDept = value;
        }
    }

    public courses(string cname, string cdept)
    {
        CNAME = cname;
        CDEPT = cdept;
    }
    public courses(int id, string cname, string cdept)
    {
        ID = id;
        CNAME = cname;
        CDEPT = cdept;
    }

}