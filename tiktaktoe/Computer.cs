public class Computer :IPlayer
{
    private Symbol symbol;
    private Board board;
    private string name;
    public Computer(string name,Symbol symbol,Board board)
    {
        this.name = name;
        this.board = board;
        this.symbol = symbol;
    }
    public string GetName()
    {
        return name;
    }
    public Symbol GetSymbol()
    {
        return symbol;
    }
    public void InsertSym()
    {
        System.Console.WriteLine(name+" Turn");
        Random rnd = new Random();
        int checkFull = board.IsiKotak(rnd.Next(1,10),symbol);
        while(checkFull == 1)
        {
            checkFull = board.IsiKotak(rnd.Next(1,10),symbol);
        }
    }
}