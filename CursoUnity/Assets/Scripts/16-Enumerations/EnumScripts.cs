using UnityEngine;

public class EnumScripts : MonoBehaviour
{
    // Definindo um Enum chamado Direcoes
    // Enum � uma lista de valores nomeados para representar dire��es
    public enum Direcoes
    {
        Norte,
        Sul,
        Leste,
        Oeste
    }

    // Vari�vel p�blica do tipo Direcoes que ser� atribu�da no Unity
    public Direcoes MinhaDirecao;

    //Chamado uma vez ao in�cio do script/jogo
    void Start()
    {
        // Chama o m�todo DirecaoSelecionada assim que o script come�a
        DirecaoSelecionada();
    }

    // Chamado a cada frame do jogo
    void Update()
    {

    }

    // M�todo que verifica qual dire��o foi selecionada
    public void DirecaoSelecionada()
    {
        // Switch case para verificar o valor de MinhaDirecao
        switch (MinhaDirecao)
        {
            // Caso a dire��o seja "Norte"
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
            // Caso nenhuma dire��o seja selecionada ou ocorra erro
            default:
                Debug.Log("Erro ou nda selecionado!");
                break;

        }
    }
}
