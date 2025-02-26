using System;
using System.Collections;
using UnityEngine;

// Classe principal que controla as corrotinas
public class CourotineController : MonoBehaviour
{
    // Método Start é chamado automaticamente pelo Unity quando o jogo inicia
    void Start()
    {
        // Inicia a corrotina chamada "Test"
        StartCoroutine("Test");
        // Inicia a corrotina chamada "Test2"
        StartCoroutine("Test2");
        // Inicia a corrotina chamada "Test3"
        StartCoroutine("Test3");
        // Inicia a corrotina chamada "Test4"
        StartCoroutine("Test4");
    }

    // Corrotina 1: Exemplo básico de uma corrotina
    IEnumerator Test()
    {
        // Exibe uma mensagem no console
        Debug.Log("Execuando Corrotina!");
        // Pausa a execução da corrotina até o próximo frame
        yield return null;
    }

    // Corrotina 2: Exemplo de corrotina com WaitForSeconds
    IEnumerator Test2()
    {
        // Exibe uma mensagem no console
        Debug.Log("Execuando Corrotina!");
        // Pausa a execução da corrotina por 5 segundos
        yield return new WaitForSeconds(5f);
        // Exibe uma mensagem no console após os 5 segundos
        Debug.Log("Corrotina finalizada após WaitForSeconds 5 segundos!");
    }

    // Corrotina 3: Exemplo de corrotina que altera a cor de um objeto
    IEnumerator Test3()
    {

        // Pausa a execução da corrotina por 5 segundos
        yield return new WaitForSeconds(5f);
        // Define uma nova cor (vermelho)
        Color color = Color.red;
        // Altera a cor do material do objeto que contém este script
        GetComponent<MeshRenderer>().material.color = color;
    }

    // Corrotina 4: Exemplo de corrotina com loop e WaitForSeconds
    IEnumerator Test4()
    {

        // Loop que executa 11 vezes (de 0 a 10)
        for (int i = 0; i <= 10; i++) {
            // Exibe uma mensagem no console a cada iteração
            Debug.Log("Executar!");
            // Pausa a execução da corrotina por 6 segundos a cada iteração
            yield return new WaitForSeconds(6f);
        }
    }

}
