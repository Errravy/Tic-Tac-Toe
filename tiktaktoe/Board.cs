public class Board
{
    public char[,] slot = new char[3, 3];
    public int dimension; 
    public GameStatus status = GameStatus.inprogress;
    public Board()
    {
        ResetBoard();
    }
    public void PrintBoard()
    {
        System.Console.WriteLine("{0}_|{1}|_{2} ", slot[0, 0], slot[0, 1], slot[0, 2]);
        System.Console.WriteLine("{0}_|{1}|_{2} ", slot[1, 0], slot[1, 1], slot[1, 2]);
        System.Console.WriteLine("{0}_|{1}|_{2} ", slot[2, 0], slot[2, 1], slot[2, 2]);
        System.Console.WriteLine("\n ");
    }
    public void ResetBoard()
    {
        dimension = 9;
        char angka = '1';
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                slot[i,j] = angka;
                angka++;
            }
        }
    }
    public int IsiKotak(int getNumber,Symbol symbol){
        char mark;
        mark = (symbol == Symbol.circle) ? 'O' : 'X';
        int angka = 0;
        switch(getNumber)
        {
            case 1:
                if(slot[0,0] == '1')
                {
                    dimension--;
                    slot[0,0] = mark;
                    angka = 0;
                }
                else{angka = 1;}
                break;
            case 2:
                if(slot[0,1] == '2')
                {
                    dimension--;
                    slot[0,1] = mark;
                    angka = 0;
                }
                else{angka = 1;}
                break;
            case 3:
                if(slot[0,2] == '3')
                {
                    dimension--;
                    slot[0,2] = mark;
                    angka = 0;
                }
                else{angka = 1;}
                break;
            case 4:
                if(slot[1,0] == '4')
                {
                    dimension--;
                    slot[1,0] = mark;
                    angka = 0;
                }
                else{angka = 1;}
                break;
            case 5:
                if(slot[1,1] == '5')
                {
                    dimension--;
                    slot[1,1] = mark;
                    angka = 0;
                }
                else{angka = 1;}
                break;
            case 6:
                if(slot[1,2] == '6')
                {
                    dimension--;
                    slot[1,2] = mark;
                    angka = 0;
                }
                else{angka = 1;}
                break;
            case 7:
                if(slot[2,0] == '7')
                {
                    dimension--;
                    slot[2,0] = mark;
                    angka = 0;
                }
                else{angka = 1;}
                break;
            case 8:
                if(slot[2,1] == '8')
                {
                    dimension--;
                    slot[2,1] = mark;
                    angka = 0;
                }
                else{angka = 1;}
                break;
            case 9:
                if(slot[2,2] == '9')
                {
                    dimension--;
                    slot[2,2] = mark;
                    angka = 0;
                }
                else{angka = 1;}
                break;
            default:
                angka = 1;
                break;
        }
        return angka;
    }

    public GameStatus CheckBoard(Player kar)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                //row Check
                if(slot[i,0] == slot[i,1] && slot[i,1] == slot[i,2])
                {
                    status = GameStatus.Win;
                    PrintBoard();
                    System.Console.WriteLine(kar.name + " Win ");
                    break;
                }
                //kolom check
                else if(slot[0,i] == slot[1,i] && slot[1,i] == slot[2,i])
                {
                    status = GameStatus.Win;
                    PrintBoard();
                    System.Console.WriteLine(kar.name + " Win ");
                    break;
                }
                //Diagonal Check
                else if(slot[0,0] == slot[1,1] && slot[1,1] == slot[2,2])
                {
                    status = GameStatus.Win;
                    PrintBoard();
                    System.Console.WriteLine(kar.name + " Win ");
                    break;
                }
                //Anti Diagonal Check
                else if(slot[0,2] == slot[1,1] && slot[1,1] == slot[2,0])
                {
                    status = GameStatus.Win;
                    PrintBoard();
                    System.Console.WriteLine(kar.name + " Win ");
                    break;
                }
                else if(dimension == 0)
                {
                    status = GameStatus.draw;
                    PrintBoard();
                    System.Console.WriteLine("Game Draw");
                    break;
                }
            }
            if(status != GameStatus.inprogress)
            break;
        }
        return status;
    }
    public GameStatus CheckBoard(Computer kar)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                //row Check
                if(slot[i,0] == slot[i,1] && slot[i,1] == slot[i,2])
                {
                    PrintBoard();
                    System.Console.WriteLine(kar.name + " Win ");
                    status = GameStatus.Win;
                    break;
                }
                //kolom check
                else if(slot[0,i] == slot[1,i] && slot[1,i] == slot[2,i])
                {
                    PrintBoard();
                    System.Console.WriteLine(kar.name + " Win ");
                    status = GameStatus.Win;
                    break;
                }
                //Diagonal Check
                else if(slot[0,0] == slot[1,1] && slot[1,1] == slot[2,2])
                {
                    PrintBoard();
                    System.Console.WriteLine(kar.name + " Win ");
                    status = GameStatus.Win;
                    break;
                }
                //Anti Diagonal Check
                else if(slot[0,2] == slot[1,1] && slot[1,1] == slot[2,0])
                {
                    PrintBoard();
                    System.Console.WriteLine(kar.name + " Win ");
                    status = GameStatus.Win;
                    break;
                }
                else if(dimension == 0)
                {
                    PrintBoard();
                    System.Console.WriteLine("Game Draw");
                    status = GameStatus.draw;
                    break;
                }
            }
            if(status != GameStatus.inprogress)
            break;
        }
        return status;
    }
}