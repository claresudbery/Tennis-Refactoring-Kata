namespace Tennis;

public class Player
{
    private int _points;
    private string _name;

    public Player(string name)
    {
        _name = name;
    }

    public int Points
    {
        set { _points = value; }
        get { return _points; }
    }

    public string Name
    {
        set { _name = value; }
        get { return _name; }
    }
}