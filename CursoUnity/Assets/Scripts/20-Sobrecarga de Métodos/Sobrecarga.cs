using UnityEngine;
using UnityEngine.Rendering.LookDev;

public class Sobrecarga : MonoBehaviour
{
    // M�todo para somar dois n�meros inteiros
    public int Add(int num1, int num2)
    {
        return num1 + num2; 
    }

    // M�todo para concatenar duas strings
    public string Add(string str1,string str2 )
    {
        return str1 + " " + str2;
    }
}
