using UnityEngine;

public class OpTernario : MonoBehaviour
{
    // Variável pública para armazenar a vida do jogador
    public int life;

    //Chamado uma vez ao início do script/jogo
    void Start()
    {
        // Usa o operador ternário para verificar se o jogador está vivo ou morto
        // Se a vida for maior que 0, exibe "Player está vivo!"
        // Caso contrário, exibe "Player está morto"
        Debug.Log(life > 0 ? "Player está vivo!" : "Player está morto");

    }

   
    
}
