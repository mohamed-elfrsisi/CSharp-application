namespace TaskTracker;

public class Task
{
    #region Data Members

    private int id;
    private string title;
    private bool isCompleted;
    private string description;
    private DateTime startDate;
    private DateTime endDate;

    #endregion

    #region Properties

    #region Id

    public int Id
    {
        get
        {
            return id;
        }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(value),
                    "Id must be greater than zero."
                );
            }

            id = value;
        }
    }
    internal void SetId(int id)
    {
        Id = id;
    }

    #endregion

    #region Title

    public string Title
    {
        get
        {
            return title;
        }

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(
                    "Title cannot be empty or contain only whitespace."
                );
            }

            if (value.Length < 3)
            {
                throw new ArgumentException(
                    "Title cannot be less than 3 characters."
                );
            }

            if (value.Length > 100)
            {
                throw new ArgumentException(
                    "Title cannot be more than 100 characters."
                );
            }

            title = value.Trim();
        }
    }

    #endregion

    #region IsCompleted

    public bool IsCompleted
    {
        get
        {
            return isCompleted;
        }
    }
    public void Complete()
    {
        isCompleted = true;
    }

    #endregion

    #region Description

    public string Description
    {
        get
        {
            return description;
        }

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                description = value;
                return;
            }

            if (value.Length < 3 || value.Length > 500)
            {
                throw new ArgumentException(
                    "Description must be between 3 and 500 characters."
                );
            }

            description = value;
        }
    }

    #endregion

    #region StartDate

    public DateTime StartDate
    {
        get
        {
            return startDate;
        }

        set
        {
            if (value == DateTime.MinValue)
            {
                throw new ArgumentException("Start Date is invalid");
            }
            startDate = value;
        }
    }

    #endregion

    #region EndDate

    public DateTime EndDate
    {
        get
        {
            return endDate;
        }

        set
        {
            if (value == DateTime.MinValue)
            {
                throw new ArgumentException("End Date is invalid");
            }

            if (value < StartDate)
            {
                throw new ArgumentException("End Date cannot be less than Start Date.");
            }
            endDate = value;
        }
    }

    #endregion

    #endregion

    #region Constructor

    public Task( string title, string description, DateTime startDate, DateTime endDate)
    {
        Title = title;
        Description = description;
        StartDate = startDate;
        EndDate = endDate;

        isCompleted = false;
    }

    #endregion
}