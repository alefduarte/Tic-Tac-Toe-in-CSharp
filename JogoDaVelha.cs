using System;

namespace Jogo_da_velha
{
    static class JogoDaVelha
    {
        static public int termino = 0, jogada = 0;
        static public char ganhador = ' ';
        static public void Main(string[] args)
        {
            char[,] m = new char[3, 3];
            zera(m);
            JogoPrincipal(m);
        }



        static void numbers()
        {
            Console.WriteLine("\t\t  1 | 2 | 3 \n");
            Console.WriteLine("\t\t-------------\n");
            Console.WriteLine("\t\t  4 | 5 | 6 \n");
            Console.WriteLine("\t\t-------------\n");
            Console.WriteLine("\t\t  7 | 8 | 9 \n");
        }

        static void limpar()
        {
            Console.Clear();
        }

        static void zera(char[,] matrix)
        {
            int i = 0, j = 0;
            for (i = 0; i < 3; i++)
                for (j = 0; j < 3; j++)
                    matrix[i,j] = ' ';
        }

        static void print(char[,] matrix)
        {
            Console.WriteLine("\n\t {0}  |  {1}  |  {2}  \n", matrix[0,0], matrix[0,1], matrix[0,2]);
            Console.WriteLine("\t-----------------\n");
            Console.WriteLine("\t  {0}  |  {1}  |  {2}  \n", matrix[1,0], matrix[1,1], matrix[1,2]);
            Console.WriteLine("\t-----------------\n");
            Console.WriteLine("\t  {0}  |  {1}  |  {2}  \n", matrix[2,0], matrix[2,1], matrix[2,2]);
        }

        static void movimentoAI(char[,] matrix)
        {
            int cond = 0;
            if (cond == 0)
            {
                if (jogada == 0)
                {
                    if ((matrix[0,0] == ' ') && (matrix[0,2] == ' ') && (matrix[2,0] == ' ') && (matrix[2,2] == ' '))
                    {
                        if (matrix[1,1] == ' ')
                        {
                            matrix[0,0] = 'O';
                            cond = 1;
                        }
                        else
                        {
                            matrix[1,0] = 'O';
                            cond = 1;
                        }
                    }
                    else
                    {
                        matrix[1,1] = 'O';
                        cond = 1;
                    }

                }
                else
                {

                    if ((matrix[0,0] == 'O') && (matrix[0,2] == 'O') && (matrix[0,1] == ' '))
                    {
                        matrix[0,1] = 'O';
                        cond = 1;
                    }
                    else
                        if ((matrix[0,0] == 'O') && (matrix[0,1] == 'O') && (matrix[0,2] == ' '))
                    {
                        matrix[0,2] = 'O';
                        cond = 1;
                    }
                    else
                        if ((matrix[0,2] == 'O') && (matrix[0,1] == 'O') && (matrix[0,0] == ' '))
                    {
                        matrix[0,0] = 'O';
                        cond = 1;
                    }
                    else
                        if ((matrix[0,0] == 'O') && (matrix[2,0] == 'O') && (matrix[1,0] == ' '))
                    {
                        matrix[1,0] = 'O';
                        cond = 1;
                    }
                    else
                        if ((matrix[0,0] == 'O') && (matrix[1,0] == 'O') && (matrix[2,0] == ' '))
                    {
                        matrix[2,0] = 'O';
                        cond = 1;
                    }
                    else
                        if ((matrix[1,0] == 'O') && (matrix[2,0] == 'O') && (matrix[0,0] == ' '))
                    {
                        matrix[0,0] = 'O';
                        cond = 1;
                    }
                    else
                        if ((matrix[2,0] == 'O') && (matrix[2,2] == 'O') && (matrix[2,1] == ' '))
                    {
                        matrix[2,1] = 'O';
                        cond = 1;
                    }
                    else
                        if ((matrix[2,0] == 'O') && (matrix[2,1] == 'O') && (matrix[2,2] == ' '))
                    {
                        matrix[2,2] = 'O';
                        cond = 1;
                    }
                    else
                        if ((matrix[2,1] == 'O') && (matrix[2,2] == 'O') && (matrix[2,0] == ' '))
                    {
                        matrix[2,0] = 'O';
                        cond = 1;
                    }
                    else
                        if ((matrix[2,2] == 'O') && (matrix[0,2] == 'O') && (matrix[1,2] == ' '))
                    {
                        matrix[1,2] = 'O';
                        cond = 1;
                    }
                    else
                        if ((matrix[2,2] == 'O') && (matrix[1,2] == 'O') && (matrix[0,2] == ' '))
                    {
                        matrix[0,2] = 'O';
                        cond = 1;
                    }
                    else
                        if ((matrix[1,2] == 'O') && (matrix[0,2] == 'O') && (matrix[2,2] == ' '))
                    {
                        matrix[2,2] = 'O';
                        cond = 1;
                    }
                    else
                        if ((matrix[0,1] == 'O') && (matrix[2,1] == 'O') && (matrix[1,1] == ' '))
                    {
                        matrix[1,1] = 'O';
                        cond = 1;
                    }
                    else
                        if ((matrix[0,1] == 'O') && (matrix[1,1] == 'O') && (matrix[2,1] == ' '))
                    {
                        matrix[2,1] = 'O';
                        cond = 1;
                    }
                    else
                        if ((matrix[1,1] == 'O') && (matrix[2,1] == 'O') && (matrix[0,1] == ' '))
                    {
                        matrix[0,1] = 'O';
                        cond = 1;
                    }
                    else
                        if ((matrix[0,0] == 'X') && (matrix[2,2] == 'X') && (matrix[1,1] == ' '))
                    {
                        matrix[1,1] = 'O';
                        cond = 1;
                    }
                    else
                        if ((matrix[0,0] == 'O') && (matrix[1,1] == 'O') && (matrix[2,2] == ' '))
                    {
                        matrix[2,2] = 'O';
                        cond = 1;
                    }
                    else
                        if ((matrix[1,1] == 'O') && (matrix[2,2] == 'O') && (matrix[0,0] == ' '))
                    {
                        matrix[0,0] = 'O';
                        cond = 1;
                    }
                    else
                        if ((matrix[0,2] == 'O') && (matrix[2,0] == 'O') && (matrix[1,1] == ' '))
                    {
                        matrix[1,1] = 'O';
                        cond = 1;
                    }
                    else
                        if ((matrix[0,2] == 'O') && (matrix[1,1] == 'O') && (matrix[2,0] == ' '))
                    {
                        matrix[2,0] = 'O';
                        cond = 1;
                    }
                    else
                        if ((matrix[2,0] == 'O') && (matrix[1,1] == 'O') && (matrix[0,2] == ' '))
                    {
                        matrix[0,2] = 'O';
                        cond = 1;
                    }
                    else
                        //para atrapalhar o oponente a ganhar
                        if ((matrix[0,0] == 'X') && (matrix[0,2] == 'X') && (matrix[0,1] == ' '))
                    {
                        matrix[0,1] = 'O';
                        cond = 1;
                    }
                    else
                        if ((matrix[0,0] == 'X') && (matrix[0,1] == 'X') && (matrix[0,2] == ' '))
                    {
                        matrix[0,2] = 'O';
                        cond = 1;
                    }
                    else
                        if ((matrix[0,2] == 'X') && (matrix[0,1] == 'X') && (matrix[0,0] == ' '))
                    {
                        matrix[0,0] = 'O';
                        cond = 1;
                    }
                    else
                        if ((matrix[0,0] == 'X') && (matrix[2,0] == 'X') && (matrix[1,0] == ' '))
                    {
                        matrix[1,0] = 'O';
                        cond = 1;
                    }
                    else
                        if ((matrix[0,0] == 'X') && (matrix[1,0] == 'X') && (matrix[2,0] == ' '))
                    {
                        matrix[2,0] = 'O';
                        cond = 1;
                    }
                    else
                        if ((matrix[1,0] == 'X') && (matrix[2,0] == 'X') && (matrix[0,0] == ' '))
                    {
                        matrix[0,0] = 'O';
                        cond = 1;
                    }
                    else
                        if ((matrix[2,0] == 'X') && (matrix[2,2] == 'X') && (matrix[2,1] == ' '))
                    {
                        matrix[2,1] = 'O';
                        cond = 1;
                    }
                    else
                        if ((matrix[2,0] == 'X') && (matrix[2,1] == 'X') && (matrix[2,2] == ' '))
                    {
                        matrix[2,2] = 'O';
                        cond = 1;
                    }
                    else
                        if ((matrix[2,1] == 'X') && (matrix[2,2] == 'X') && (matrix[2,0] == ' '))
                    {
                        matrix[2,0] = 'O';
                        cond = 1;
                    }
                    else
                        if ((matrix[2,2] == 'X') && (matrix[0,2] == 'X') && (matrix[1,2] == ' '))
                    {
                        matrix[1,2] = 'O';
                        cond = 1;
                    }
                    else
                        if ((matrix[2,2] == 'X') && (matrix[1,2] == 'X') && (matrix[0,2] == ' '))
                    {
                        matrix[0,2] = 'O';
                        cond = 1;
                    }
                    else
                        if ((matrix[1,2] == 'X') && (matrix[0,2] == 'X') && (matrix[2,2] == ' '))
                    {
                        matrix[2,2] = 'O';
                        cond = 1;
                    }
                    else
                        if ((matrix[0,1] == 'X') && (matrix[2,1] == 'X') && (matrix[1,1] == ' '))
                    {
                        matrix[1,1] = 'O';
                        cond = 1;
                    }
                    else
                        if ((matrix[0,1] == 'X') && (matrix[1,1] == 'X') && (matrix[2,1] == ' '))
                    {
                        matrix[2,1] = 'O';
                        cond = 1;
                    }
                    else
                        if ((matrix[1,1] == 'X') && (matrix[2,1] == 'X') && (matrix[0,1] == ' '))
                    {
                        matrix[0,1] = 'O';
                        cond = 1;
                    }
                    else


                        if ((matrix[0,0] == 'X') && (matrix[2,2] == 'X') && (matrix[1,1] == ' '))
                    {
                        matrix[1,1] = 'O';
                        cond = 1;
                    }
                    else
                        if ((matrix[0,0] == 'X') && (matrix[1,1] == 'X') && (matrix[2,2] == ' '))
                    {
                        matrix[2,2] = '0';
                        cond = 1;
                    }
                    else
                        if ((matrix[1,1] == 'X') && (matrix[2,2] == 'X') && (matrix[0,0] == ' '))
                    {
                        matrix[0,0] = 'O';
                        cond = 1;
                    }
                    else
                        if ((matrix[0,2] == 'X') && (matrix[2,0] == 'X') && (matrix[1,1] == ' '))
                    {
                        matrix[1,1] = 'O';
                        cond = 1;
                    }
                    else
                        if ((matrix[0,2] == 'X') && (matrix[1,1] == 'X') && (matrix[2,0] == ' '))
                    {
                        matrix[2,0] = 'O';
                        cond = 1;
                    }
                    else
                        if ((matrix[2,0] == 'X') && (matrix[1,1] == 'X') && (matrix[0,2] == ' '))
                    {
                        matrix[0,2] = 'O';
                        cond = 1;
                    }
                    else
                    {
                        int x = 0, y = 0;
                        for (x = 0; x < 3; x++)
                            for (y = 0; y < 3; y++)
                            {
                                if ((cond == 0) && (matrix[x,y] == ' '))
                                {

                                    matrix[x,y] = 'O';
                                    cond = 1;
                                }

                            }
                    }
                }
            }
        }

        static void movimentoEasy(char[,] matrix)
        {
            int cond = 0, i = 0, j = 0;
            for (i = 0; i <= 2; i++)
            {
                for (j = 0; j <= 2; j++)
                {
                    if ((cond == 0) && (matrix[i,j] == ' '))
                    {
                        matrix[i,j] = 'O';
                        cond = 1;
                    }
                }
            }
        }

        static void movimentoNormal(char[,] matrix)
        {

            Random rnd = new Random();
            int p = rnd.Next(1, 10);
            if (p <= 3)
            {
                if ((matrix[0,p - 1] == ' '))
                {
                    matrix[0,p - 1] = 'O';
                }
                else
                {
                    movimentoNormal(matrix);
                }

            }
            else if (p > 3 && p <= 6)
            {
                p -= 3;
                if ((matrix[1,p - 1] == ' '))
                {
                    matrix[1,p - 1] = 'O';
                }
                else
                {
                    movimentoNormal(matrix);
                }
            }
            else if (p > 6 && p <= 9)
            {
                p -= 6;
                if ((matrix[2,p - 1] == ' '))
                {
                    matrix[2,p - 1] = 'O';
                }
                else
                {
                    movimentoNormal(matrix);
                }
            }
        }

        static void jogador(char[,] matrix)
        {
            int p = 0;
            Console.WriteLine("\nEscolha um número correspondente à posição desejada\n");
            while (p < 1 || p > 9)
            {
                try
                {
                p = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    p = 0;
                }
                if (p < 1 || p > 9)
                    Console.WriteLine("Escolha um número entre 1 e 9\n");
            }
            if (p <= 3)
            {
                if ((matrix[0,p - 1] == ' '))
                {
                    matrix[0,p - 1] = 'X';
                }
                else
                {
                    Console.WriteLine("\n posição invalida");

                    jogador(matrix);
                }

            }
            else if (p > 3 && p <= 6)
            {
                p -= 3;
                if ((matrix[1,p - 1] == ' '))
                {
                    matrix[1,p - 1] = 'X';
                }
                else
                {
                    Console.WriteLine("\n posição invalida");
                    jogador(matrix);
                }
            }
            else if (p > 6 && p <= 9)
            {
                p -= 6;
                if ((matrix[2,p - 1] == ' '))
                {
                    matrix[2,p - 1] = 'X';
                }
                else
                {
                    Console.WriteLine("\n posição invalida");
                    jogador(matrix);
                }
            }

        }

        static void segundoJogador(char[,] matrix)
        {
            int p = 0;
            Console.WriteLine("\nEscolha um número correspondente à posição desejada\n");
            while (p < 1 || p > 9)
            {
                p = Convert.ToInt32(Console.ReadLine());
                if (p < 1 || p > 9)
                    Console.WriteLine("Escolha um número entre 1 e 9\n");
            }
            if (p <= 3)
            {
                if ((matrix[0,p - 1] == ' '))
                {
                    matrix[0,p - 1] = 'O';
                }
                else
                {
                    Console.WriteLine("\n posição invalida");

                    segundoJogador(matrix);
                }

            }
            else if (p > 3 && p <= 6)
            {
                p -= 3;
                if ((matrix[1,p - 1] == ' '))
                {
                    matrix[1,p - 1] = 'O';
                }
                else
                {
                    Console.WriteLine("\n posição invalida");
                    segundoJogador(matrix);
                }
            }
            else if (p > 6 && p <= 9)
            {
                p -= 6;
                if ((matrix[2,p - 1] == ' '))
                {
                    matrix[2,p - 1] = 'O';
                }
                else
                {
                    Console.WriteLine("\n posição invalida");
                    segundoJogador(matrix);
                }
            }

        }

        static void menu()
        {
            Console.WriteLine("\n\t\tJOGO DA VELHA\t\t\t      Alef Duarte\n\n");
            Console.WriteLine("\t\t+-----------------------------------------------+\n");
            Console.WriteLine("\t\t|  Escolha uma opção:                           |\n");
            Console.WriteLine("\t\t|\t1. Jogador Vs Jogador.                  |\n");
            Console.WriteLine("\t\t|\t2. Jogador Vs Maquina (modo facil).     |\n");
            Console.WriteLine("\t\t|\t3. Jogador Vs Maquina (modo medio).     |\n");
            Console.WriteLine("\t\t|\t4. Jogador Vs Maquina (modo difícil).   |\n");
            Console.WriteLine("\t\t|\t5. Sair.                                |\n");
            Console.WriteLine("\t\t+-----------------------------------------------+\n");
            Console.WriteLine("\t\t\tOpção: ");
        }

        static void jogo1(char[,] m)
        {
            if (jogada == 0) zera(m);
            Console.WriteLine("Jogador 1\n");
            jogador(m);
            print(m);
            teste(m);
            Console.WriteLine("Jogador 2\n");
            segundoJogador(m);
            print(m);
            teste(m);

        }

        static void jogo2(char[,] m)
        {
            if (jogada == 0) zera(m);
            Console.WriteLine("Jogador 1\n");
            jogador(m);
            print(m);
            teste(m);
            Console.WriteLine("Maquina\nAperte enter para continuar");
            Console.ReadLine();
            movimentoEasy(m);
            print(m);
            teste(m);

        }

        static void jogo3(char[,] m)
        {
            if (jogada == 0) zera(m);
            Console.WriteLine("Jogador 1\n");
            jogador(m);
            print(m);
            teste(m);
            Console.WriteLine("Maquina\nAperte enter para continuar");
            Console.ReadLine();
            movimentoNormal(m);
            print(m);
            teste(m);

        }

        static void jogo4(char[,] m)
        {
            if (jogada == 0) zera(m);
            Console.WriteLine("Jogador 1\n");
            jogador(m);
            print(m);
            teste(m);
            Console.WriteLine("Maquina\nAperte enter para continuar");
            Console.ReadLine();
            movimentoAI(m);
            print(m);
            teste(m);

        }

        static void fim(char[,] matrix)
        {

            limpar();
            print(matrix);
            Console.WriteLine("O jogador {0} venceu", ganhador);
            Console.WriteLine("\nDigite s para jogar outra vez\n");
            char denovo = ' ';
            try
            {
            denovo = Convert.ToChar(Console.ReadLine());
            }
            catch
            {
                denovo = 's';
            }
            if (denovo == 's')
            {
                ganhador = ' ';
                termino = 0;
                jogada = 0;
                limpar();
                JogoPrincipal(matrix);
            }

        }

        static void teste(char[,] matrix)
        {

            //teste horizontal
            if ((matrix[0,0] == matrix[0,1]) && (matrix[0,1] == matrix[0,2]) && (matrix[0,0] != ' '))
            {
                termino = 1;
                ganhador = matrix[0,0];
                fim(matrix);
            }
            if ((matrix[1,0] == matrix[1,1]) && (matrix[1,1] == matrix[1,2]) && (matrix[1,0] != ' '))
            {
                termino = 1;
                ganhador = matrix[1,0];
                fim(matrix);
            }
            if ((matrix[2,0] == matrix[2,1]) && (matrix[2,1] == matrix[2,2]) && (matrix[2,0] != ' '))
            {
                termino = 1;
                ganhador = matrix[2,0];
                fim(matrix);
            }

            //teste vertical

            if ((matrix[0,0] == matrix[1,0]) && (matrix[1,0] == matrix[2,0]) && (matrix[0,0] != ' '))
            {
                termino = 1;
                ganhador = matrix[0,0];
                fim(matrix);
            }
            if ((matrix[0,1] == matrix[1,1]) && (matrix[1,1] == matrix[2,1]) && (matrix[0,1] != ' '))
            {
                termino = 1;
                ganhador = matrix[0,1];
                fim(matrix);
            }
            if ((matrix[0,2] == matrix[1,2]) && (matrix[1,2] == matrix[2,2]) && (matrix[0,2] != ' '))
            {
                termino = 1;
                ganhador = matrix[0,2];
                fim(matrix);
            }

            //teste na digonal

            if ((matrix[0,0] == matrix[1,1]) && (matrix[1,1] == matrix[2,2]) && (matrix[0,0] != ' '))
            {
                termino = 1;
                ganhador = matrix[0,0];
                fim(matrix);
            }
            if ((matrix[0,2] == matrix[1,1]) && (matrix[1,1] == matrix[2,0]) && (matrix[0,2] != ' '))
            {
                termino = 1;
                ganhador = matrix[0,2];
                fim(matrix);
            }
            // teste se deu velha
            if ((jogada == 4) && (ganhador == ' '))
            {
                limpar();
                Console.WriteLine("\n\nVELHA \nDigite s para jogar de novo ");
                char denovo = Convert.ToChar(Console.ReadLine());
                if (denovo == 's')
                {
                    ganhador = ' ';
                    termino = 0;
                    jogada = 0;
                    limpar();
                    JogoPrincipal(matrix);
                }
            }

        }

        static void JogoPrincipal(char[,] m)
        {
            int opt = 0;
            menu();
            while (opt > 5 || opt < 1)
            {
                opt = int.Parse(Console.ReadLine());
                if (opt > 5 || opt < 1)
                    Console.WriteLine("\nOpção inválida\nEscolha outra opação\n");
            }
            switch (opt)
            {
                case 1:
                    numbers();
                    while ((jogada <= 9) && (termino != 1))
                    {

                        jogo1(m);
                        jogada++;
                    }
                    break;
                case 2:
                    numbers();
                    while ((jogada <= 9) && (termino != 1))
                    {

                        jogo2(m);
                        jogada++;
                    }
                    break;
                case 3:
                    numbers();
                    while ((jogada <= 9) && (termino != 1))
                    {

                        jogo3(m);
                        jogada++;
                    }
                    break;
                case 4:
                    numbers();
                    while ((jogada <= 9) && (termino != 1))
                    {

                        jogo4(m);
                        jogada++;
                    }
                    break;
                case 5:
                    Console.WriteLine("\nSair\n");
                    break;
                default:
                    break;
            }
            jogada = 0;
        }
    }
}
