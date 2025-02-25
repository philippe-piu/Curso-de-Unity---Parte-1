using UnityEngine;

public class MyCharacter : MonoBehaviour
{
    /* POLIMORFISMO */
    /* É o princípio pelo qual duas ou mais classes derivadas de uma mesma classe base podem invocar métodos
       que têm a mesma assinatura, porém comportamentos distintos. */

    // Campos públicos para armazenar informações do personagem

    public string CharName;
    public int Health;
    public int Strength;
    public float speead;

    // Método virtual para o personagem falar
    // A palavra-chave 'virtual' permite que esse método seja sobrescrito por classes derivadas.
    public virtual void Say()
    {
        // Comportamento padrão: exibe uma mensagem genérica
        Debug.Log("Olá, meu amigo");
    }
}
