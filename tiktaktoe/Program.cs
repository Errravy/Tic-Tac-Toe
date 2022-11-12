
public class Program
{
    public static void Main()
    {   
        int retry;
        do {
        GameMode gameMode = GameMode.pVp;
        System.Console.WriteLine("Cing Cang Cong");
        System.Console.WriteLine("Mode: \n1.Player Vs Player \n2.Player Vs Computer \n3.Computer Vs Computer");
        System.Console.Write("masukan mode yang ingin dimainkan: ");
        int angka = Convert.ToInt32(Console.ReadLine());
        switch (angka)
        {
            case 1:
                gameMode = GameMode.pVp;
                break;
            case 2:
                gameMode = GameMode.pVc;
                break;
            case 3:
                gameMode = GameMode.cVc;
                break;
            default:
                System.Console.WriteLine("!!! PLS, JANGAN MELAWAK COY !!!");
                System.Console.WriteLine("Mode: \n1.Player Vs Player \n2.Player Vs Computer \n3.Computer Vs Computer");
                System.Console.Write("masukan mode yang ingin dimainkan: ");
                angka = Convert.ToInt32(Console.ReadLine());
                break;
        }
        
        Game game = new Game(gameMode);
        System.Console.WriteLine("Main lagi? \n1.Yes \n2.No");
        System.Console.Write("Masukan Input: ");
        retry = Convert.ToInt32(Console.ReadLine());
        } while ( retry == 1);
        System.Console.WriteLine("Thank You for Playing");
    }
}