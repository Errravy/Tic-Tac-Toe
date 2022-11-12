public class Game{


    string[] botName = {"Budi","Tono","Kuniawan","Cahyono","Sugeng"};
    string? player1Name = "";
    string? player2Name = "";
    string bot1Name    = "你怎么去";
    string bot2Name    = "请您原谅";
    public Board papan = new Board();
    public int insertSym;
    public Game(GameMode gameMode)
    {
        switch(gameMode)
        {
            case GameMode.pVp:
            StartPVP();
                break;
            case GameMode.pVc:
            StartPVC();
                break;
            case GameMode.cVc:
            StartCVC();
                break;
        }
    }
    public void StartPVP()
    {
        System.Console.WriteLine("Mode PVP");
        System.Console.Write("Masukan Nama Player 1: ");
        player1Name = Console.ReadLine();
        System.Console.WriteLine("Simbol : \n1.Circle \n2.Cross ");
        System.Console.Write("Pilih simbol Player 1 : ");
        int angka = Convert.ToInt32(Console.ReadLine());
        while(angka > 2 && angka < 1)
        {
            System.Console.WriteLine("!!! ANGKA INVALID !!!");
            System.Console.WriteLine("Simbol : \n1.Circle \n2.Cross ");
            System.Console.Write("Pilih simbol Player 1 : ");
            angka = Convert.ToInt32(Console.ReadLine());
        }
        System.Console.Write("Masukan Nama Player 2: ");
        player2Name = Console.ReadLine();
        if(player1Name == null){player1Name = "noName";}
        if(player2Name == null){player2Name = "noName";}
        Symbol symbol1 = (angka == 1) ? Symbol.circle : Symbol.cross;
        Symbol symbol2 = (angka == 1) ? Symbol.cross : Symbol.circle;
        Player player1 = new Player(player1Name,symbol1,papan);
        Player player2 = new Player(player2Name,symbol2,papan);
        PlayPVP(player1,player2);
    }
    public void StartPVC()
    {
        Random rand  = new Random();
        bot1Name = botName[rand.Next(5)];
        System.Console.WriteLine("Mode PVC");
        System.Console.Write("Masukan Nama Player 1: ");
        player1Name = Console.ReadLine();
        System.Console.WriteLine("Simbol : \n1.Circle \n2.Cross ");
        System.Console.Write("Pilih simbol Player 1 : ");
        int angka = Convert.ToInt32(Console.ReadLine());
        while(angka > 2 && angka < 1)
        {
            System.Console.WriteLine("!!! ANGKA INVALID !!!");
            System.Console.WriteLine("Simbol : \n1.Circle \n2.Cross ");
            System.Console.Write("Pilih simbol Player 1 : ");
            angka = Convert.ToInt32(Console.ReadLine());
        }
        if(player1Name == null){player1Name = "noName";}
        Symbol symbol1 = (angka == 1) ? Symbol.circle : Symbol.cross;
        Symbol symbol2 = (angka == 1) ? Symbol.cross : Symbol.circle;
        Player player1 = new Player(player1Name,symbol1,papan);
        Computer bot1 = new Computer(bot1Name,symbol2,papan);
        PlayPVC(player1,bot1);
    }
    public void StartCVC()
    {
        Random rand  = new Random();
        bot1Name = botName[rand.Next(5)];
        bot2Name = botName[rand.Next(5)];
        Computer bot1 = new Computer(bot1Name,Symbol.circle,papan);
        Computer bot2 = new Computer(bot2Name,Symbol.cross,papan);
        PlayCVC(bot1,bot2);
    }
    void PlayPVP(Player player1,Player player2)
    {
        while(true)
        {
            player1.insertSym();
            player2.insertSym();
        }
    }
    void PlayPVC(Player player1,Computer bot1)
    {
        while(true)
        {
            player1.insertSym();
            bot1.RandomNumberInsert();
        }
    }
    void PlayCVC(Computer bot1,Computer bot2)
    {
        papan.PrintBoard();
        while(true)
        {
            bot1.RandomNumberInsert();
            bot2.RandomNumberInsert();
        }
    }
}