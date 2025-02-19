using UnityEngine;

public class EnumScripts : MonoBehaviour
{
    // Definindo um Enum chamado Direcoes
    // Enum é uma lista de valores nomeados para representar direções
    public enum Direcoes
    {
        Norte,
        Sul,
        Leste,
        Oeste
    }

    // Variável pública do tipo Direcoes que será atribuída no Unity
    public Direcoes MinhaDirecao;

    //Chamado uma vez ao início do script/jogo
    void Start()
    {
        // Chama o método DirecaoSelecionada assim que o script começa
        DirecaoSelecionada();
    }

    // Chamado a cada frame do jogo
    void Update()
    {

    }

    // Método que verifica qual direção foi selecionada
    public void DirecaoSelecionada()
    {
        // Switch case para verificar o valor de MinhaDirecao
        switch (MinhaDirecao)
        {
            // Caso a direção seja "Norte"
            case Direcoes.Norte:
                Debug.Log("Norte Selecionado");// Exibe no console "Norte Selecionado"
                break;
            case Direcoes.Sul:
                Debug.Log("Sul Selecionado");
                break;
            case Direcoes.Leste:
                Debug.Log("Leste Selecionado");
                break;
            case Direcoes.Oeste:
                Debug.Log("Oeste Selecionado");
                break;
            // Caso nenhuma direção seja selecionada ou ocorra erro
            default:
                Debug.Log("Erro ou nda selecionado!");
                break;

        }
    }
}
