using UnityEngine;

public class WhileDoWhile : MonoBehaviour
{
    // Vari�vel privada que representa a quantidade de itens dispon�veis na cena
    private int itensCena = 5;

    // Vari�vel privada que representa a quantidade de dinheiro do jogador
    private int dinheiro = 500;

    //Chamado uma vez ao in�cio do script/jogo
    void Start()
    {
        // Loop "while" que executa enquanto houver itens na cena
        while (itensCena > 0) {
            // Exibe a mensagem no Console do Unity informando que um item foi pego
            Debug.Log("Itens pegados! " );
            // Decrementa a vari�vel "itensCena", reduzindo o n�mero de itens restantes
            itensCena--;
        }

        // Loop "do-while" que adiciona dinheiro at� atingir 1000
        do
        {
            // Exibe no console a quantidade atual de dinheiro
            Debug.Log("O seu dinheiro �: " + dinheiro);
            // Adiciona 50 � vari�vel "dinheiro"
            dinheiro += 50;

        } while (dinheiro < 1000);// Continua enquanto o dinheiro for menor que 1000
    }

    // Chamado a cada frame do jogo
    void Update()
    {
        
    }
}
