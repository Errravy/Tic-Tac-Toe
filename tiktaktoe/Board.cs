public class Board
{
    public char[,] slot = new char[3, 3];
    public int dimension;
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
                    slot[0,0] = mark;
                    angka = 0;
                }
                else{angka = 1;}
                break;
            case 2:
                if(slot[0,1] == '2')
                {
                    slot[0,1] = mark;
                    angka = 0;
                }
                else{angka = 1;}
                break;
            case 3:
                if(slot[0,2] == '3')
                {
                    slot[0,2] = mark;
                    angka = 0;
                }
                else{angka = 1;}
                break;
            case 4:
                if(slot[1,0] == '4')
                {
                    slot[1,0] = mark;
                    angka = 0;
                }
                else{angka = 1;}
                break;
            case 5:
                if(slot[1,1] == '5')
                {
                    slot[1,1] = mark;
                    angka = 0;
                }
                else{angka = 1;}
                break;
            case 6:
                if(slot[1,2] == '6')
                {
                    slot[1,2] = mark;
                    angka = 0;
                }
                else{angka = 1;}
                break;
            case 7:
                if(slot[2,0] == '7')
                {
                    slot[2,0] = mark;
                    angka = 0;
                }
                else{angka = 1;}
                break;
            case 8:
                if(slot[2,1] == '8')
                {
                    slot[2,1] = mark;
                    angka = 0;
                }
                else{angka = 1;}
                break;
            case 9:
                if(slot[2,2] == '9')
                {
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




















}