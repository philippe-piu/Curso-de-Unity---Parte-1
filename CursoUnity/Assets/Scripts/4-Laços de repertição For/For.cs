using UnityEngine;

public class For : MonoBehaviour
{
    // Variável privada que define a quantidade de inimigos
    private int numeroInimigos = 3;

    // Variável pública que armazena o número correspondente ao dia da semana
    void Start()
    {
        // Loop "for" que irá executar 10 vezes
        for (int i = 0; i < 10; i++)
        {
            // Exibe o valor atual da variável 'i' no Console do Unity
            Debug.Log(+i);
        }

        // Segundo loop "for" que executa conforme o número de inimigos
        for (int i = 0; i < numeroInimigos; i++) {
            // Exibe o número do inimigo no Console do Unity
            Debug.Log("Número de inimigos é "+i);
        }
        
    }

    //Chamado uma vez ao início do script/jogo
    void Update()
    {
        
    }
}
