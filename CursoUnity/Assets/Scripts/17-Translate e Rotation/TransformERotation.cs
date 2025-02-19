using Mono.Cecil.Cil;
using UnityEngine;

public class TransformERotation : MonoBehaviour
{
    // Variáveis públicas para definir a velocidade e rotação
    public float velocidade; // Controla a velocidade de movimento
    public float rotacao;  // Controla a velocidade de rotação

    //Chamado uma vez ao início do script/jogo
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
            // Move o objeto para trás ao longo do eixo Z
            // `-Vector3.forward` move o objeto para trás (Z negativo)
            transform.Translate(-Vector3.forward * velocidade * Time.deltaTime);
        }

        // Verifica se a tecla "Seta para a Direita" (RightArrow) foi pressionada
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // Roda o objeto no sentido anti-horário ao redor do eixo Y (horizontal)
            // `transform.Rotate(-Vector3.up)` faz a rotação no sentido anti-horário
            // `rotacao * Time.deltaTime` ajusta a velocidade de rotação conforme o tempo
            transform.Rotate(-Vector3.up * rotacao * Time.deltaTime);
        }


        // Verifica se a tecla "Seta para a Esquerda" (LeftArrow) foi pressionada
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // Roda o objeto no sentido horário ao redor do eixo Y (horizontal)
            // `transform.Rotate(Vector3.up)` faz a rotação no sentido horário
            transform.Rotate(Vector3.up * rotacao * Time.deltaTime);
        }
    }
}
