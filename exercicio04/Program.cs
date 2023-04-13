using System;
class Exercicio
{
    static void Main(string[] args)
    {
    inicio:;
        JogodeVelha game = new JogodeVelha();
        while (true)
        {
        erro:;
            game.Grade();
            Console.WriteLine("Jogador 1");
            Console.WriteLine("Digite a coluna:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a linha:");
            int b = Convert.ToInt32(Console.ReadLine());

            if (game.SetJogada1(b, a))
                /*if (game.SetJogada1(b, a))
                {
                    Console.WriteLine("Jogada Inválida.");
                    Console.ReadKey();
                    goto erro;
                }*/
            
            if (game.Verificar())
            {
                    while (true)
                    {
                        Console.Clear();
                        game.Grade();
                        Console.WriteLine("Acabou");
                        Console.WriteLine("Deseja iniciar novamente: " + "\n1 - Sim"+"\n2 - Não");
                        int num = Convert.ToInt32(Console.ReadLine());
                        if(num == 1)
                        {
                            goto inicio;
                        }
                        if (num == 2)
                        {
                            goto sair;
                        }
                        if(num != 1 && num != 2)
                        {
                            Console.Write("Opção inválida!");
                            Console.ReadLine();
                        }
                    }                   
            }
        erro2:;
            Console.Clear();
            game.Grade();
            Console.WriteLine("Jogador 2");
            Console.WriteLine("Digite a coluna:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a linha:");
            int d = Convert.ToInt32(Console.ReadLine());
            if (game.SetJogada2(c, d)) ;
               /* if (!game.SetJogada2(c, d))
                {
                    Console.WriteLine("Jogada Inválida.");
                    Console.ReadKey();
                    goto erro2;
                }*/
        }
        if (game.Verificar())
        {
            while (true)
            {
                Console.Clear();
                game.Grade();
                Console.WriteLine("Acabou");
                Console.WriteLine("Deseja iniciar novamente: " + "\n1 - Sim" + "\n2 - Não");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 1)
                {
                    goto inicio;
                }
                if (num == 2)
                {
                    goto sair;
                }
                if (num != 1 && num != 2)
                {
                    Console.Write("Opção inválida!");
                    Console.ReadLine();
                }
            }
        }
    sair:;

        Console.ReadLine();
    }
}