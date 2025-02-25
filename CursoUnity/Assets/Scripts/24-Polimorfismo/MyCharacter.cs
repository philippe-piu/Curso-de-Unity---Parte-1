using UnityEngine;

public class MyCharacter : MonoBehaviour
{
    /* POLIMORFISMO */
    /* � o princ�pio pelo qual duas ou mais classes derivadas de uma mesma classe base podem invocar m�todos
       que t�m a mesma assinatura, por�m comportamentos distintos. */

    // Campos p�blicos para armazenar informa��es do personagem

    public string CharName;
    public int Health;
    public int Strength;
    public float speead;

    // M�todo virtual para o personagem falar
    // A palavra-chave 'virtual' permite que esse m�todo seja sobrescrito por classes derivadas.
    public virtual void Say()
    {
        // Comportamento padr�o: exibe uma mensagem gen�rica
        Debug.Log("Ol�, meu amigo");
    }
}
