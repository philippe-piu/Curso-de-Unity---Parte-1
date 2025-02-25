using UnityEngine;

// Namespace Enemy
// Namespaces s�o usados para organizar classes e evitar conflitos de nomes.
// Aqui, todas as classes dentro deste namespace est�o relacionadas a inimigos
namespace Enemys
{

    // Classe Enemies
    // Representa um tipo de inimigo no jogo.
    public class Enemies : MonoBehaviour
    {
        // Campo p�blico para a velocidade do inimigo
        public float speed;
        // Campo p�blico para a quantidade de vidas do inimigo
        public float lives;


    }

    // Classe AnotherEnemies
    // Representa outro tipo de inimigo no jogo.
    public class AnotherEnemies : MonoBehaviour
    {
        // Campo p�blico para a velocidade do inimigo
        public float speed;
        // Campo p�blico para a quantidade de vidas do inimigo
        public float lives;


    }

}
