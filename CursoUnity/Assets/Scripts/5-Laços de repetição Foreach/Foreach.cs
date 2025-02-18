using UnityEngine;

public class Foreach : MonoBehaviour
{
    /*foreach em C# funciona principalmente para arrays e listas, mas tamb�m 
     * pode ser usado em qualquer cole��o que implemente a interface IEnumerable 
     * ou IEnumerable<T>*/

    // Declara um array de strings para armazenar os nomes dos inimigos
    public string[] inimigos = new string[3];

    // Declara um array de inteiros para armazenar a quantidade de inimigos
    public int[] quantInimigos = new int[3];

    // Vari�vel p�blica que armazena o n�mero correspondente ao dia da semana
    void Start()
    {
        // Atribui valores ao array "inimigos"
        inimigos[0] = "Donquixote Doflamingo";
        inimigos[1] = "Enel";
        inimigos[2] = "Loki";

        // Utiliza um loop "foreach" para percorrer todos os elementos do array
        foreach (string i in inimigos)
        {
            // Exibe o nome do inimigo atual no Console do Unity
            Debug.Log(i);
        }

        // Atribui valores ao array "quantInimigos"
        quantInimigos[0] = 1;
        quantInimigos[1] = 2;
        quantInimigos[2] = 3;

        // Utiliza um loop "foreach" para percorrer todos os elementos do array "quantInimigos"
        foreach (int i in quantInimigos)
        {
            // Exibe a quantidade de inimigos no Console do Unity
            Debug.Log(i);
        }
    }

    //Chamado uma vez ao in�cio do script/jogo
    void Update()
    {
        
    }
}
