using System;

namespace Ivory.TesteEstagio.CampoMinado
{
    class Program
    {
        static void Main(string[] args)
        {
            var campoMinado = new CampoMinado();
            Console.WriteLine("Início do jogo\n=========");
            Console.WriteLine(campoMinado.Tabuleiro);

            // Realize sua codificação a partir deste ponto, boa sorte!

            do
            {
                System.Console.WriteLine("Digite a coordenada de linha (De 1 a 9):");
                int linha = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Digite a coordenada de coluna (De 1 a 9):");
                int coluna = int.Parse(Console.ReadLine());
                campoMinado.Abrir(linha,coluna);
                System.Console.WriteLine("");            
                Console.WriteLine(campoMinado.Tabuleiro);
                System.Console.WriteLine("");
                    
            } while(campoMinado.JogoStatus == 0);

            if(campoMinado.JogoStatus == 2)
            {
                System.Console.WriteLine("Game Over!");
                System.Console.WriteLine("");
            }
            else
            {
                System.Console.WriteLine("Parabéns, Você Ganhou!");
                System.Console.WriteLine("");
            }

        }
    } 
}
