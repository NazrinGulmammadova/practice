//Students class
//    -Name
//    -Surname
//    -AvgPoint
//AvgPoint 0-100 araliginda olmalidir


public class Students
{
    public string name;
    public string Surname;
    private int _avgPoint;
    public int AvgPoint
    {
        get
        {
            return -1;
        }
        set
        {
            if (value > 0 && value < 100)
            {
                _avgPoint = value;
            }
        }
    }
}
