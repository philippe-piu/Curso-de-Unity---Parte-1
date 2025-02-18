using UnityEngine;

public class WhileDoWhile : MonoBehaviour
{
    // Variável privada que representa a quantidade de itens disponíveis na cena
    private int itensCena = 5;

    // Variável privada que representa a quantidade de dinheiro do jogador
    private int dinheiro = 500;

    //Chamado uma vez ao início do script/jogo
    void Start()
    {
        // Loop "while" que executa enquanto houver itens na cena
        while (itensCena > 0) {
            // Exibe a mensagem no Console do Unity informando que um item foi pego
            Debug.Log("Itens pegados! " );
            // Decrementa a variável "itensCena", reduzindo o número de itens restantes
            itensCena--;
        }

        // Loop "do-while" que adiciona dinheiro até atingir 1000
        do
        {
            // Exibe no console a quantidade atual de dinheiro
            Debug.Log("O seu dinheiro é: " + dinheiro);
            // Adiciona 50 à variável "dinheiro"
            dinheiro += 50;

        } while (dinheiro < 1000);// Continua enquanto o dinheiro for menor que 1000
    }

    // Chamado a cada frame do jogo
    void Update()
    {
        
    }
}
