using UnityEngine;

public class ChamadaEstaticos : MonoBehaviour
{
    //Chamado uma vez ao início do script/jogo
    void Start()
    {
        // Acessamos o método `LifePersonagens` da classe `MétodosEVariáveisEstáticas`
        // através da variável estática `estaticos`
        MétodosEVariáveisEstáticas.estaticos.LifePersonagens();
    }

    // Chamado a cada frame do jogo
    void Update()
    {
        
    }
}
