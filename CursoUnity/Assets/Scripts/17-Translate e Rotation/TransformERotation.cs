using Mono.Cecil.Cil;
using UnityEngine;

public class TransformERotation : MonoBehaviour
{
    // Vari�veis p�blicas para definir a velocidade e rota��o
    public float velocidade; // Controla a velocidade de movimento
    public float rotacao;  // Controla a velocidade de rota��o

    //Chamado uma vez ao in�cio do script/jogo
    void Start()
    {
        
    }

    // Chamado a cada frame do jogo
    void Update()
    {
        // Verifica se a tecla "Seta para Cima" (UpArrow) foi pressionada
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // Move o objeto para frente ao longo do eixo Z
            // `transform.Translate(Vector3.forward)` move o objeto para frente (Z positivo)
            transform.Translate(Vector3.forward * velocidade * Time.deltaTime);
        }

        // Verifica se a tecla "Seta para Baixo" (DownArrow) foi pressionada
        if (Input.GetKey(KeyCode.DownArrow))
        {
            // Move o objeto para tr�s ao longo do eixo Z
            // `-Vector3.forward` move o objeto para tr�s (Z negativo)
            transform.Translate(-Vector3.forward * velocidade * Time.deltaTime);
        }

        // Verifica se a tecla "Seta para a Direita" (RightArrow) foi pressionada
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // Roda o objeto no sentido anti-hor�rio ao redor do eixo Y (horizontal)
            // `transform.Rotate(-Vector3.up)` faz a rota��o no sentido anti-hor�rio
            // `rotacao * Time.deltaTime` ajusta a velocidade de rota��o conforme o tempo
            transform.Rotate(-Vector3.up * rotacao * Time.deltaTime);
        }


        // Verifica se a tecla "Seta para a Esquerda" (LeftArrow) foi pressionada
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // Roda o objeto no sentido hor�rio ao redor do eixo Y (horizontal)
            // `transform.Rotate(Vector3.up)` faz a rota��o no sentido hor�rio
            transform.Rotate(Vector3.up * rotacao * Time.deltaTime);
        }
    }
}
