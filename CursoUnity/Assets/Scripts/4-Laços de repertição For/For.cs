using UnityEngine;

public class For : MonoBehaviour
{
    // Vari�vel privada que define a quantidade de inimigos
    private int numeroInimigos = 3;

    // Vari�vel p�blica que armazena o n�mero correspondente ao dia da semana
    void Start()
    {
        // Loop "for" que ir� executar 10 vezes
        for (int i = 0; i < 10; i++)
        {
            // Exibe o valor atual da vari�vel 'i' no Console do Unity
            Debug.Log(+i);
        }

        // Segundo loop "for" que executa conforme o n�mero de inimigos
        for (int i = 0; i < numeroInimigos; i++) {
            // Exibe o n�mero do inimigo no Console do Unity
            Debug.Log("N�mero de inimigos � "+i);
        }
        
    }

    //Chamado uma vez ao in�cio do script/jogo
    void Update()
    {
        
    }
}
