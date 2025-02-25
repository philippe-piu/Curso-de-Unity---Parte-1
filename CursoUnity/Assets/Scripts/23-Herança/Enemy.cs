using UnityEngine;

// Classe Enemy herda da classe MonoBehaviour
// Isso permite que Enemy seja anexada a um GameObject no Unity e use m�todos como Start e Update.
public class Enemy : MonoBehaviour
{
    /*HERAN�A*/

    /* Conceito que permite o uso/acesso de propriedades e m�todos de outra classe.
    Neste caso, Enemy herda de MonoBehaviour, ganhando acesso a m�todos como Start e Update. */

    // Campo p�blico para armazenar a sa�de do inimigo
    public int health = 100;
    
    // M�todo para aplicar dano ao inimigo
    public void Damage(int DamageValue)
    {
        // Reduz a sa�de do inimigo pelo valor do dano recebido
        health -= DamageValue;
    }

    //POSSIBILITA ESSE M�TODO SER REESCRITO POR CLASSES HERDADAS
    // M�todo virtual para o ataque do inimigo
    // A palavra-chave 'virtual' permite que esse m�todo seja reescrito (sobrescrito) por classes derivadas.
    public virtual void Attack()
    {
        // Comportamento padr�o do ataque do inimigo
        // Por exemplo, tira dano do Player
        Debug.Log("Inimigo atacou!");
    }
   
}
