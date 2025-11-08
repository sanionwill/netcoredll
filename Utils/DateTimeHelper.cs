public class DateTimeHelper
{
    private string dateTimeFormat = "yyyy-MM-dd HH:mm:ss";

    public string GetCurrentDateTime()
    {
        return System.DateTime.Now.ToString(dateTimeFormat);
    }

    public string GetCurrentDate()
    {
        return System.DateTime.Now.ToString("yyyy-MM-dd");
    }

    public string GetCurrentTime()
    {
        return System.DateTime.Now.ToString("HH:mm:ss");
    }
}
