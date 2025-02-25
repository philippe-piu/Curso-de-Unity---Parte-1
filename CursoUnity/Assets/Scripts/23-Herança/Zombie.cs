using UnityEngine;

// Classe Zombie herda da classe Enemy
// Assim como Globin, Zombie tem acesso a todos os campos e m�todos p�blicos/protegidos de Enemy.
public class Zombie : Enemy
{
    // M�todo Start � chamado uma vez no in�cio do jogo
    private void Start()
    {
        // Chama o m�todo Attack da classe Zombie (que sobrescreve o m�todo Attack da classe Enemy)
        Attack();
    }

    //REESCREVE O M�TODO 'ATTACK' DA CLASSE ENEMY
    // Sobrescreve o m�todo Attack da classe Enemy
    // A palavra-chave 'override' indica que este m�todo substitui o m�todo virtual da classe base.
    public override void Attack()
    {
        // Comportamento personalizado do ataque do Zombie
        Debug.Log("Zombie atacou com mordida!");
    }

}
