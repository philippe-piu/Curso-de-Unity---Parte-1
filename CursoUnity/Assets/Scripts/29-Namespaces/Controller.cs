using UnityEngine;
using Enemys; // Importa o namespace Enemy para acessar suas classes

// Classe Controller
// Responsável por controlar a lógica do jogo, como a criação de inimigos.
public class Controller : MonoBehaviour
{
    // Método Start é chamado uma vez no início do jogo
    private void Start()
    {
        // Cria uma instância da classe Enemies do namespace Enemy
        // Note que o nome completo da classe é Enemy.Enemies, mas como o namespace foi importado,
        // podemos usar apenas Enemies.
        Enemys.Enemies enemy_1 = new Enemys.Enemies();
        // Cria uma instância da classe AnotherEnemies do namespace Enemy
        Enemys.AnotherEnemies enemy_2 = new Enemys.AnotherEnemies();
    }
}
