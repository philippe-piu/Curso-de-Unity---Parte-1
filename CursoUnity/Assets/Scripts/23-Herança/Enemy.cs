using UnityEngine;

// Classe Enemy herda da classe MonoBehaviour
// Isso permite que Enemy seja anexada a um GameObject no Unity e use métodos como Start e Update.
public class Enemy : MonoBehaviour
{
    /*HERANÇA*/

    /* Conceito que permite o uso/acesso de propriedades e métodos de outra classe.
    Neste caso, Enemy herda de MonoBehaviour, ganhando acesso a métodos como Start e Update. */

    // Campo público para armazenar a saúde do inimigo
    public int health = 100;
    
    // Método para aplicar dano ao inimigo
    public void Damage(int DamageValue)
    {
        // Reduz a saúde do inimigo pelo valor do dano recebido
        health -= DamageValue;
    }

    //POSSIBILITA ESSE MÉTODO SER REESCRITO POR CLASSES HERDADAS
    // Método virtual para o ataque do inimigo
    // A palavra-chave 'virtual' permite que esse método seja reescrito (sobrescrito) por classes derivadas.
    public virtual void Attack()
    {
        // Comportamento padrão do ataque do inimigo
        // Por exemplo, tira dano do Player
        Debug.Log("Inimigo atacou!");
    }
   
}
