public class JogoDaVelha
{
    // Atributos
    private string[] ocupacao = {"", "X", "O"};

    private int posicaoX;
    private int posicaoY;

    private string[,] tabuleiroCasas = new string[3, 3];
    private bool turno;

    // Metodos

    // Mostrar grade
    public void grade() {
        // Imprimir grade
        Console.WriteLine($"   1   2   3\n1  {tabuleiroCasas[0, 0]} | {tabuleiroCasas[0, 1]} | {tabuleiroCasas[0, 2]}\n  -----------\n2  {tabuleiroCasas[1, 0]} | {tabuleiroCasas[1, 1]} | {tabuleiroCasas[1, 2]}\n  -----------\n3  {tabuleiroCasas[2, 0]} | {tabuleiroCasas[2, 1]} | {tabuleiroCasas[2, 2]}");
    }

    // Trocar turno
    public string TrocarTurno() {
        // Variaveis
        if(this.turno == false) {
            return $"JOGADOR {this.ocupacao[1]}";
        } else {
            return $"JOGADOR {this.ocupacao[2]}";
        }
    }

    // Mostrar Cordenadas
    public void Cordenadas() {
        Console.WriteLine($"\nLINHA: {this.posicaoX + 1}");
        Console.WriteLine($"COLUNA: {this.posicaoY + 1}\n");
    }

    // Controles

    // - Movimentacao
    public void Controle(ConsoleKeyInfo key) {
        // Variaveis
        string tecla = $"{key.Key}";

        // - Cima
        if(tecla == "W") {
            if(this.posicaoY <= 0) { }
            else { this.posicaoY-=1; }
        } 
        // - Baixo
        else if(tecla == "S") {
            if(this.posicaoY >= 2) { }
            else { this.posicaoY+=1; }
        } 
        // - Direita
        else if(tecla == "A") {
            if(this.posicaoX <= 0) { }
            else { this.posicaoX-=1; }
        } 
        // - Esquerda
        else if(tecla == "D") {
            if(this.posicaoX >= 2) { }
            else { this.posicaoX+=1; }
        } 
    }

    // Escolher casa
    public void EscolherCasa(ConsoleKeyInfo key) {
        // Variaveis
        string confirmar = $"{key.Key}";

        // Confirmar escolha
        if (confirmar == "Spacebar" && tabuleiroCasas[this.posicaoY, this.posicaoX] == null) {
            if(this.turno == false) {
                // Jogador x
                tabuleiroCasas[this.posicaoY, this.posicaoX] = ocupacao[1];
                this.turno = true;
            } else {
                // Jogador o
                tabuleiroCasas[this.posicaoY, this.posicaoX] = ocupacao[2];
                this.turno = false;
            }

            // Resetar posicao
            this.posicaoX = 0;
            this.posicaoY = 0;
        }
    }

    // Verificar vitoria 
    public void VerificarVitoria() {
        
    }
}