using UnityEngine;

public class OpTernario : MonoBehaviour
{
    // Vari�vel p�blica para armazenar a vida do jogador
    public int life;

    //Chamado uma vez ao in�cio do script/jogo
    void Start()
    {
        // Usa o operador tern�rio para verificar se o jogador est� vivo ou morto
        // Se a vida for maior que 0, exibe "Player est� vivo!"
        // Caso contr�rio, exibe "Player est� morto"
        Debug.Log(life > 0 ? "Player est� vivo!" : "Player est� morto");

    }

   
    
}
