internal class Program
{
    private static void Main(string[] args)
    {
        string posicaoInicial = "3 3 L";
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
