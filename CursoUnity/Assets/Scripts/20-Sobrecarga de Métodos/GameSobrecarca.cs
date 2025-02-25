using System;
using System.Runtime.ConstrainedExecution;
using Unity.VisualScripting;
using UnityEngine;

public class GameSobrecarca : MonoBehaviour
{

    //Chamado uma vez ao in�cio do script/jogo
    void Start()
    {
        //Se tentar instanciar uma classe Sobrecarga sob = new Sobrecarga(); dessa forma da erro 
        //No Unity, classes que herdam de MonoBehaviour n�o podem ser instanciadas diretamente com new.Em vez disso, voc� deve adicionar o componente a um GameObject usando AddComponent<T>().

        // Cria um novo GameObject
        GameObject obj = new GameObject ("Sobrecarga");
        // Adiciona o componente Sobrecarga ao GameObject
        Sobrecarga sob = obj.AddComponent<Sobrecarga>();

        // Usa o m�todo Add para inteiros e exibe o resultado no console
        sob.Add(10,20);

        Debug.Log(sob.Add(10, 20));

        // Usa o m�todo Add para strings e exibe o resultado no console
        sob.Add("Teste1", "Teste2");

        Debug.Log(sob.Add("Teste1", "Teste2"));
    }

    
}
