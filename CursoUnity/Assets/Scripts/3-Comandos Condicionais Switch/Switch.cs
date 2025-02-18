using UnityEngine;

public class Switch : MonoBehaviour
{
    // Vari�vel p�blica que armazena o n�mero correspondente ao dia da semana
    public int diaSemana;

    //Chamado uma vez ao in�cio do script/jogo
    void Start()
    {
        // Estrutura switch para verificar o valor da vari�vel diaSemana
        switch (diaSemana)
        {

            case 1:
                // Se diaSemana for 1, imprime "Domingo"
                Debug.Log("Domingo");
                break;
            case 2:
                Debug.Log("Segunda");
                break;
            case 3:
                Debug.Log("Ter�a");
                break;
            case 4:
                Debug.Log("Quarta");
                break;
            case 5:
                Debug.Log("Quinta");
                break;
            case 6:
                Debug.Log("Sexta");
                break;
            case 7:
                Debug.Log("Sabado");
                break;
            default:
                Debug.Log("N�o � dia de semana");
                break;
        }
    }

    // Chamado a cada frame do jogo
    void Update()
    {

    }
}
