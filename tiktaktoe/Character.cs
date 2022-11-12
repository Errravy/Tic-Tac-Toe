public class Character : IPlayer
{
    public Symbol symbol;
    public Board? board;
    public string name = "";
    public string GetName()
    {
        return name;
    }
    public Symbol GetSymbol()
    {
        return symbol;
    }
}