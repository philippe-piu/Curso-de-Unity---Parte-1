using UnityEngine;

public class Game : MonoBehaviour
{
    //Chamado uma vez ao início do script/jogo
    void Start()
    {
        // Tenta criar uma nova instância de Player usando o operador 'new'
        Player player_1 = new Player();
        // Define a experiência do jogador como 10
        player_1.Experience = 10;
        // Exibe a experiência do jogador no console
        Debug.Log(player_1.Experience);

        // Define a vida do jogador como 5
        
        player_1.Life = 5;
        // Exibe a vida do jogador no console
        Debug.Log(player_1.Life);

        // Define as vidas do jogador como 6
        player_1.Lives = 6;

        // Exibe as vidas do jogador no console
        Debug.Log(player_1.Lives);

    }

}
