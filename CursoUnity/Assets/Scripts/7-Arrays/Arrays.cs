using UnityEngine;

public class Arrays : MonoBehaviour
{
    // Declara um array público para armazenar os GameObjects que possuem a tag "Player"
    public GameObject[] player;

    //Chamado uma vez ao início do script/jogo
    void Start()
    {
        // Procura e armazena todos os GameObjects que possuem a tag "Player" na cena
        player = GameObject.FindGameObjectsWithTag("Player");

        // Estrutura de repetição foreach: percorre todos os objetos armazenados no array 'player'
        foreach (GameObject p in player)
        {
            // Exibe no Console o nome de cada objeto encontrado
            Debug.Log(p.name);
        }

        // Estrutura de repetição for: percorre os objetos usando um índice numérico
        for (int i = 0; i < player.Length; i++)
        {

            // Exibe no Console o nome do objeto atual acessado pelo índice 'i'
            Debug.Log("Name do gameObect: " + player[i].name);
        }
    }

    // Chamado a cada frame do jogo
    void Update()
    {
        
    }
}
