using UnityEngine;

// Classe Globin herda da classe Enemy
// Isso significa que Globin tem acesso a todos os campos e métodos públicos/protegidos de Enemy.
public class Globin : Enemy
{
    private void Start()
    {
        // Chama o método Attack da classe Enemy
        Attack();
    }
}
