using UnityEngine;
using Enemys; // Importa o namespace Enemy para acessar suas classes

// Classe Controller
// Respons�vel por controlar a l�gica do jogo, como a cria��o de inimigos.
public class Controller : MonoBehaviour
{
    // M�todo Start � chamado uma vez no in�cio do jogo
    private void Start()
    {
        // Cria uma inst�ncia da classe Enemies do namespace Enemy
        // Note que o nome completo da classe � Enemy.Enemies, mas como o namespace foi importado,
        // podemos usar apenas Enemies.
        Enemys.Enemies enemy_1 = new Enemys.Enemies();
        // Cria uma inst�ncia da classe AnotherEnemies do namespace Enemy
        Enemys.AnotherEnemies enemy_2 = new Enemys.AnotherEnemies();
    }
}
