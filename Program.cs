using System;

public class Program
{
    static void Main(string[] args)
    {
        // Variaveis
        ConsoleKeyInfo tecla, iniciarJogo;
        bool partida = false;

        JogoDaVelha n = new JogoDaVelha();
        string[] ocupacao = n.GetOcupacao();

        // Codigo
        while(partida == false) {
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
            partida = true;
          } else {
            Console.Clear();
            Console.WriteLine(" ! ERROR: TECLA INVÁLIDA PARA INICIAR JOGO !");
            Console.ReadKey();
          }
        }

        // Jogo
        while(partida == true) {
          Console.Clear();

          // Grade e turno
          Console.WriteLine($"* VEZ DE: {n.TrocarTurno()}\n");
          n.Grade();

          // Mostrar cordenadas
          n.Cordenadas();
          
          // Verificar vitoria
          n.VerificarVitoria();
          if(n.VerificarVitoria() == ocupacao[1] || n.VerificarVitoria() == ocupacao[2]) {
            partida = false;
            Console.WriteLine($"VENCEDOR: {n.VerificarVitoria()}");
            Console.ReadKey();

            // Finalizar partida
            Console.Clear();
            Console.WriteLine("\n- PRESSIONE QUALQUER TECLA PARA SAIR -");
            Console.WriteLine("        - OBRIGADO POR JOGAR - ");
            Console.ReadKey();
            break;
          }

          // Movimentacao
          tecla = Console.ReadKey();
          n.Controle(tecla);
          n.EscolherCasa(tecla);
        }
    }
}