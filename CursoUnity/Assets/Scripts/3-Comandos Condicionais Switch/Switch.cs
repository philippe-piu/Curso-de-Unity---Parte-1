using UnityEngine;

public class Switch : MonoBehaviour
{
    // Variável pública que armazena o número correspondente ao dia da semana
    public int diaSemana;

    //Chamado uma vez ao início do script/jogo
    void Start()
    {
        // Estrutura switch para verificar o valor da variável diaSemana
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
                Debug.Log("Terça");
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
                Debug.Log("Não é dia de semana");
                break;
        }
    }

    // Chamado a cada frame do jogo
    void Update()
    {

    }
}
