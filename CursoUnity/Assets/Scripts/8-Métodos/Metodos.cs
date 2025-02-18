using UnityEngine;

public class Metodos : MonoBehaviour
{
    // Vari�vel p�blica que armazena a quantidade de vida do jogador
    public int vida;
    // Vari�vel p�blica que armazena o dano que o inimigo causa ao jogador
    public int danoInimigo;


    //Chamado uma vez ao in�cio do script/jogo
    void Start()
    {
        // Chama o m�todo AumentarVida(), que adiciona 10 pontos � vida do jogador
        AumentarVida();
        // Chama o m�todo DiminuirVida(), passando o valor de danoInimigo como par�metro
        // Isso reduz a vida do jogador pelo valor especificado em danoInimigo
        DiminuirVida(danoInimigo);
    }

    // Chamado a cada frame do jogo
    void Update()
    {
       
    }

    // M�todo que aumenta a vida do jogador em 10 pontos
    public void AumentarVida()
    {
        // Adiciona 10 � vari�vel "vida"
        vida += 10;
    }

    // M�todo que reduz a vida do jogador com base no dano recebido
    public void DiminuirVida(int dano)
    {
        // Subtrai o valor do dano da vari�vel "vida"
        vida -= dano;
    }
}
