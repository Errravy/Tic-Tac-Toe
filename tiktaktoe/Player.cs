public class Player :IPlayer
{
    private Symbol symbol;
    private Board board;
    private string name;
    public Player(string name ,Symbol symbol,Board board)
    {
        this.name = name;
        this.symbol = symbol;
        this.board = board;
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
        board.PrintBoard();
        System.Console.WriteLine(name+" Turn");
        Console.Write("Masukan angka: ");
        int angka = Convert.ToInt32(Console.ReadLine());
        int checkFull = board.IsiKotak(angka,symbol);
        while(checkFull == 1)
        {
            Console.WriteLine("!!! ANGKA TIDAK VALID !!!");
            Console.Write("Masukan angka: ");
            angka = Convert.ToInt32(Console.ReadLine());
            checkFull = board.IsiKotak(angka,symbol);
        }
    }
}