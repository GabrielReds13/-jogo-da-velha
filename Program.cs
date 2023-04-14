using System;

public class Program
{
    static void Main(string[] args)
    {
        // Variaveis
        ConsoleKeyInfo tecla, iniciarJogo;
        JogoDaVelha n = new JogoDaVelha();

        // Codigo
        while(true) {
          Console.Clear();

          // Movimentacao
          Console.WriteLine(" -- MOVIMENTAÇÃO --");
          Console.WriteLine(" - CIMA [ w ]\n - BAIXO [ s ]\n - DIREITA [ d ]\n - ESQUERDA [ a ]\n");

          // Outras configuracoes
          Console.WriteLine(" -- OUTROS --");
          Console.WriteLine(" - ESCOLHER/CONFIRMAR [ espaço ]\n");

          // Iniciar partida
          Console.WriteLine(" ! PRESSIONE [ espaço ] PARA INICIAR PARTIDA !");
          iniciarJogo = Console.ReadKey();

          if($"{iniciarJogo.Key}" == "Spacebar") {
            break;
          } else {
            Console.Clear();
            Console.WriteLine(" ! ERROR: TECLA INVÁLIDA PARA INICIAR JOGO !");
            Console.ReadKey();
          }
        }

        // Jogo
        while(true) {
          Console.Clear();

          // Grade e turno
          Console.WriteLine($"* VEZ DE: {n.TrocarTurno()}\n");
          n.grade();

          // Mostrar cordenadas
          n.Cordenadas();
          n.VerificarVitoria();

          // Movimentacao
          tecla = Console.ReadKey();
          n.Controle(tecla);
          n.EscolherCasa(tecla);
        }
    }
}