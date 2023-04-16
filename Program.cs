using System;

public class Program
{
    static void Main(string[] args)
    {
        // Variaveis
        ConsoleKeyInfo tecla, iniciarJogo;
        bool partida = false;
        bool jogo = false;

        // Codigo
        while (partida == false)
        {
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

            if ($"{iniciarJogo.Key}" == "Spacebar")
            {
                partida = true;
                jogo = true;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(" ! ERROR: TECLA INVÁLIDA PARA INICIAR JOGO !");
                Console.ReadKey();
            }
        }

        // Jogo
        while(jogo == true) {
            // Objeto
            JogoDaVelha n = new JogoDaVelha();
            string[] ocupacao = n.GetOcupacao();

            // Partida
            while (partida == true)
            {
                Console.Clear();

                // Grade e turno
                Console.WriteLine($"* VEZ DE: {n.TrocarTurno()}\n");
                n.Grade();

                // Encerrar partida
                if (n.GetVencedor() == ocupacao[1] || n.GetVencedor() == ocupacao[2])
                {
                    // Variaveis
                    partida = !true;
                    jogo = !true;

                    // Imprimir vencedor
                    Console.WriteLine($"\nVENCEDOR: {n.GetVencedor()}\n");
                    break;
                } 
                // Empate
                else if(n.GetVencedor() == "EMPATE")
                {
                    // Variaveis
                    partida = !true;
                    jogo = !true;

                    // Imprimir Vencedor
                    Console.WriteLine($"\nVENCEDOR: {n.GetVencedor()}\n");
                    break;
                } else { }

                // Mostrar cordenadas
                n.Cordenadas();

                // Movimentacao
                tecla = Console.ReadKey();
                n.Controle(tecla);
                n.EscolherCasa(tecla);

                // Verificar Vitoria
                n.VerificarVitoria();
            }

            // Reiniciar partida
            if(partida != true) {
                Console.WriteLine("- PRESSIONE [ espaço ] PARA RECOMEÇAR PARTIDA");
                Console.WriteLine("- PRESSIONE QUALQUER TECLA PARA SAIR");
                iniciarJogo = Console.ReadKey();

                // Sair do programa
                if ($"{iniciarJogo.Key}" == "Spacebar") {
                    partida = true;
                    jogo = true;
                } else { break; }
            }
        }

        // Fechar programa
        Console.Clear();
        Console.WriteLine("\n- PRESSIONE QUALQUER TECLA PARA SAIR -");
        Console.WriteLine("       - OBRIGADO POR JOGAR - ");
        Console.ReadKey();
    }
}
