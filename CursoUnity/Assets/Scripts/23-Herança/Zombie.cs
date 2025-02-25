using UnityEngine;

// Classe Zombie herda da classe Enemy
// Assim como Globin, Zombie tem acesso a todos os campos e métodos públicos/protegidos de Enemy.
public class Zombie : Enemy
{
    // Método Start é chamado uma vez no início do jogo
    private void Start()
    {
        // Chama o método Attack da classe Zombie (que sobrescreve o método Attack da classe Enemy)
        Attack();
    }

    //REESCREVE O MÉTODO 'ATTACK' DA CLASSE ENEMY
    // Sobrescreve o método Attack da classe Enemy
    // A palavra-chave 'override' indica que este método substitui o método virtual da classe base.
    public override void Attack()
    {
        // Comportamento personalizado do ataque do Zombie
        Debug.Log("Zombie atacou com mordida!");
    }

}
