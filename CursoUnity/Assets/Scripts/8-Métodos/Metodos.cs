using UnityEngine;

public class Metodos : MonoBehaviour
{
    // Variável pública que armazena a quantidade de vida do jogador
    public int vida;
    // Variável pública que armazena o dano que o inimigo causa ao jogador
    public int danoInimigo;


    //Chamado uma vez ao início do script/jogo
    void Start()
    {
        // Chama o método AumentarVida(), que adiciona 10 pontos à vida do jogador
        AumentarVida();
        // Chama o método DiminuirVida(), passando o valor de danoInimigo como parâmetro
        // Isso reduz a vida do jogador pelo valor especificado em danoInimigo
        DiminuirVida(danoInimigo);
    }

    // Chamado a cada frame do jogo
    void Update()
    {
       
    }

    // Método que aumenta a vida do jogador em 10 pontos
    public void AumentarVida()
    {
        // Adiciona 10 à variável "vida"
        vida += 10;
    }

    // Método que reduz a vida do jogador com base no dano recebido
    public void DiminuirVida(int dano)
    {
        // Subtrai o valor do dano da variável "vida"
        vida -= dano;
    }
}
