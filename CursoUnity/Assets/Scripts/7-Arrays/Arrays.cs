using UnityEngine;

public class Arrays : MonoBehaviour
{
    // Declara um array p�blico para armazenar os GameObjects que possuem a tag "Player"
    public GameObject[] player;

    //Chamado uma vez ao in�cio do script/jogo
    void Start()
    {
        // Procura e armazena todos os GameObjects que possuem a tag "Player" na cena
        player = GameObject.FindGameObjectsWithTag("Player");

        // Estrutura de repeti��o foreach: percorre todos os objetos armazenados no array 'player'
        foreach (GameObject p in player)
        {
            // Exibe no Console o nome de cada objeto encontrado
            Debug.Log(p.name);
        }

        // Estrutura de repeti��o for: percorre os objetos usando um �ndice num�rico
        for (int i = 0; i < player.Length; i++)
        {

            // Exibe no Console o nome do objeto atual acessado pelo �ndice 'i'
            Debug.Log("Name do gameObect: " + player[i].name);
        }
    }

    // Chamado a cada frame do jogo
    void Update()
    {
        
    }
}
