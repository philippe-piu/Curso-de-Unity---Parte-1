using UnityEngine;

public class ChamadaEstaticos : MonoBehaviour
{
    //Chamado uma vez ao in�cio do script/jogo
    void Start()
    {
        // Acessamos o m�todo `LifePersonagens` da classe `M�todosEVari�veisEst�ticas`
        // atrav�s da vari�vel est�tica `estaticos`
        M�todosEVari�veisEst�ticas.estaticos.LifePersonagens();
    }

    // Chamado a cada frame do jogo
    void Update()
    {
        
    }
}
