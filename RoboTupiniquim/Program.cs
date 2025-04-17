static class Robo
{
    public static int posicaoX;
    public static int posicaoY;
    public static int direcao;

    public static void VirarEsquerda()
    {
        if (direcao == 'N')
                {
                    direcao = 'O';
                }
                else if (direcao == 'O')
                {
                    direcao = 'S';
                }
                else if (direcao == 'S')
                {
                    direcao = 'L';
                }
                else if (direcao == 'L')
                {
                    direcao = 'N';
                }
                else if (direcao == 'M')
                {
                    if (direcao == 'N')
                    {
                        posicaoY++;
                    }
                    else if (direcao == 'S')
                    {
                        posicaoY--;
                    }
                    else if (direcao == 'O')
                    {
                        posicaoX--;
                    }
                    else if (direcao == 'L')
                    {
                        posicaoX++;
                    }
                }
    }

    public static void VirarDireita()
    {
        if (direcao == 'N')
                {
                    direcao = 'L';
                }
                else if (direcao == 'L')
                {
                    direcao = 'S';
                }
                else if (direcao == 'S')
                {
                    direcao = 'O';
                }
                else if (direcao == 'O')
                {
                    direcao = 'N';
                }
                else if (direcao == 'M')
                {
                    if (direcao == 'N')
                    {
                        posicaoY++;
                    }
                    else if (direcao == 'S')
                    {
                        posicaoY--;
                    }
                    else if (direcao == 'O')
                    {
                        posicaoX--;
                    }
                    else if (direcao == 'L')
                    {
                        posicaoX++;
                    }
                }
    }

    public static void Mover ()
    {
        if (direcao == 'N')
        {
            posicaoY++;
        }
        else if (direcao == 'S')
        {
            posicaoY--;
        }
        else if (direcao == 'O')
        {
            posicaoX--;
        }
        else if (direcao == 'L')
        {
            posicaoX++;
        }
    }

    public static void Explorar(char [] instrucoes)
    {
        for (int i = 0; i < instrucoes.Length; i++)
        {
            char instrucaoAtual = instrucoes[i];

            if (instrucaoAtual == 'E')
            {
                Robo.VirarEsquerda();
            }
            else if (instrucaoAtual == 'D')
            {
               Robo.VirarDireita();
            }
            else if (instrucaoAtual == 'M')
            {
                Robo.Mover();
            }
        }
    }

    public static void ExibirCoordenadas()
    {
         Console.WriteLine($"Posição final do robô: {posicaoX} {posicaoY} {direcao}");
    }

}


internal class Program
{
    private static void Main(string[] args)
    {
        string posicaoInicial = "5 5 ";
        string comando = "MMDMMDMDDM";

        string[] coordenadasIniciais = posicaoInicial.Split(' ');

        Robo.posicaoX = Convert.ToInt32(coordenadasIniciais[0]);
        Robo.posicaoY = Convert.ToInt32(coordenadasIniciais[1]); 
        Robo.direcao = Convert.ToChar(coordenadasIniciais[2]); 

        char[] instrucoes = comando.ToCharArray();

        Robo.Explorar(instrucoes);

        Robo.ExibirCoordenadas();

    }

}
