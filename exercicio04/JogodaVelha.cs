public class JogodeVelha
{
    private string[,] grade = new string[3,3];
    public string vazia = "   ";
    private string jogador1 = " X ";
    private string jogador2 = " O ";

    public JogodeVelha() 
    {
        for(int i = 0; i < grade.GetLength(0); i++)
        {
            for(int j = 0; j < grade.GetLength(1); j++)
            {
                grade[i, j]= vazia;
            }
        }
    }
    public void Grade()
    {
        Console.WriteLine($"    0   1   2 "); 
        Console.WriteLine($" 0|{grade[0, 0]}|{grade[0, 1]}|{grade[0,2]}|");
        Console.WriteLine(" ---------------");
        Console.WriteLine($" 1|{grade[1, 0]}|{grade[1, 1]}|{grade[1,2]}|");
        Console.WriteLine(" ---------------");
        Console.WriteLine($" 2|{grade[2, 0]}|{grade[2, 1]}|{grade[2,2]}|");
        
    } 

    public bool Verificar()
    {
        if ((grade[0,0] == jogador1 && grade[0,1] == jogador1 && grade[0,2] == jogador1 || 
            grade[0,0] == jogador2 && grade[0,1] == jogador2 && grade[0,2] == jogador2)) 
        {
            return true;}

        if ((grade[1, 0] == jogador1 && grade[1, 1] == jogador1 && grade[1, 2] == jogador1 ||
            grade[1, 0] == jogador2 && grade[1, 1] == jogador2 && grade[1, 2] == jogador2))
        { 
            return true; }

        if ((grade[2, 0] == jogador1 && grade[2, 1] == jogador1 && grade[2, 2] == jogador1 ||
            grade[2, 0] == jogador2 && grade[2, 1] == jogador2 && grade[2, 2] == jogador2)) 
        {
            return true; }

        //----------------------------------------------------------------------------------------------------

        if ((grade[0, 0] == jogador1 && grade[1, 0] == jogador1 && grade[2, 0] == jogador1 ||
            grade[0, 0] == jogador2 && grade[1, 0] == jogador2 && grade[2, 0] == jogador2)) 
        { 
            return true; }

        if ((grade[0, 1] == jogador1 && grade[1, 1] == jogador1 && grade[2, 1] == jogador1 ||
            grade[0, 1] == jogador2 && grade[1, 1] == jogador2 && grade[2, 1] == jogador2)) 
        { 
            return true; }

        if ((grade[0, 2] == jogador1 && grade[1, 2] == jogador1 && grade[2, 2] == jogador1 ||
            grade[0, 2] == jogador2 && grade[1, 2] == jogador2 && grade[2, 2] == jogador2)) 
        { 
            return true; }

        //--------------------------------------------------------------------------------------------

        if ((grade[0,0] == jogador1 && grade[1,1] == jogador1 && grade[2,2] == jogador1 ||
            grade[0, 0] == jogador2 && grade[1, 1] == jogador2 && grade[2, 2] == jogador2))
        { 
            return true;}

        if ((grade[2,0] == jogador1 && grade[2,1] == jogador1 && grade[0,2] == jogador1 ||
            grade[2, 0] == jogador1 && grade[2, 1] == jogador1 && grade[0, 2] == jogador1))
        {
            return true;}

        else
        {
            bool empata = true;
            int partida = 0;
            for(int i = 0; i< grade.GetLength(0); i++)
            {
                for(int j = 0; j< grade.GetLength(1); j++)
                {
                    if (grade[i, j] == vazia)
                    {
                        empata = false;
                        partida++;
                    }
                    
                }
            }
            if (partida == 0)
            {
                return true;
            }
            return empata;
        }
        
    }

    public bool SetJogada1(int linha, int coluna)
    {
        if (linha >= 0 && linha <= 2 && coluna >= 0 && coluna <= 2) 
        {
            if (grade[linha, coluna] == vazia)
            {
                grade[linha, coluna] = jogador1;
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }

    public bool SetJogada2(int linha, int coluna)
    {
        if (linha >= 0 && linha <= 2 && coluna >= 0 && coluna <= 2)
        {
            if (grade[linha, coluna] == vazia)
            {
                grade[linha, coluna] = jogador2;
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
}