public class DateTimeHelper
{
    private string dateTimeFormat = "yyyy-MM-dd HH:mm:ss";
    private string dateFormat = "yyyy-MM-dd";

    public string GetCurrentDateTime()
    {
        return System.DateTime.Now.ToString(dateTimeFormat);
    }

    public string GetCurrentDate()
    {
        return System.DateTime.Now.ToString(dateFormat);
    }

    public string GetCurrentTime()
    {
        return System.DateTime.Now.ToString("HH:mm:ss");
    }
}
