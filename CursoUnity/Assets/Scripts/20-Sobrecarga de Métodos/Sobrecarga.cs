using UnityEngine;
using UnityEngine.Rendering.LookDev;

public class Sobrecarga : MonoBehaviour
{
    // Método para somar dois números inteiros
    public int Add(int num1, int num2)
    {
        return num1 + num2; 
    }

    // Método para concatenar duas strings
    public string Add(string str1,string str2 )
    {
        return str1 + " " + str2;
    }
}
