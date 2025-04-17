internal class Program
{
    private static void Main(string[] args)
    {
        string posicaoInicial = "5 5 ";
        string comando = "MMDMMDMDDM";

        string[] coordenadasIniciais = posicaoInicial.Split(' ');

        int posicaoX = Convert.ToInt32(coordenadasIniciais[0]);
        int posicaoY = Convert.ToInt32(coordenadasIniciais[1]); 
        char direcao = Convert.ToChar(coordenadasIniciais[2]); 

        char[] instrucoes = comando.ToCharArray();

        for (int i = 0; i < instrucoes.Length; i++)
        {
            char instrucaoAtual = instrucoes[i];

            if (instrucaoAtual == 'E')
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
            else if (instrucaoAtual == 'D')
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

        Console.WriteLine($"Posição final do robô: {posicaoX} {posicaoY} {direcao}");

    }

}
