using UnityEngine;

public class IfElse : MonoBehaviour
{
    private int a = 10;
    private int b = 20;

    public bool valor;
    //Chamado uma vez ao início do script/jogo
    void Start()
    {
        //Se a for maior que b
        if(a > b)
        {
            Debug.Log("O valor de " +a +" é maior que "+b +" Verdadeiro");
        }
        else
        {
            //Se a for menor que b
            Debug.Log("O valor de " + a + " é maior que " + b + " Falso");
        }

        //Se a for menor que b
        if (a < b)
        {
            Debug.Log("O valor de " + a + " é menor que " + b + " Verdadeiro");
        }
        else
        {
            //Se a for maior que b
            Debug.Log("O valor de " + a + " é menor que " + b + " Falso");
        }

        Debug.Log(valor);

        if (valor) {

            Debug.Log("Verdadeiro");

        }
        else
        {
            Debug.Log("Falso");
        }
    }

    // Chamado a cada frame do jogo
    void Update()
    {
        
    }
}
