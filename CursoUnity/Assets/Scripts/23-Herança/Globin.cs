using UnityEngine;

// Classe Globin herda da classe Enemy
// Isso significa que Globin tem acesso a todos os campos e m�todos p�blicos/protegidos de Enemy.
public class Globin : Enemy
{
    private void Start()
    {
        // Chama o m�todo Attack da classe Enemy
        Attack();
    }
}
