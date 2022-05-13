namespace Tennis;

public class Player
{
    public Player(string name)
    {
        Name = name;
    }

    public int Points { set; get; }

    public string Name { set; get; }
}