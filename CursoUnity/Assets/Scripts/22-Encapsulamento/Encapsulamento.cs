using UnityEngine;

public class Encapsulamento : MonoBehaviour
{
    /* ENCAPSULAMENTO */
    // O encapsulamento é um dos pilares da Programação Orientada a Objetos (POO).
    // Ele permite controlar o acesso aos dados de uma classe, protegendo-os de modificações indevidas
    // e garantindo que as regras de negócio sejam respeitadas.

    /*ENCAPSULAMOS COM SUCESSO O VALOR 'HEALTH' PRIVADO E AO FAZER ISSO, PROTEGEMOS
     O 'WARRIOR' DE TER UM 'HEALT' ABAIXO DE ZERO*/

    // Definição da classe Warrior (Guerreiro)

    public class Warrior
    {
        // Campo privado para armazenar a saúde (vida) do guerreiro
        // O campo é privado para que não possa ser acessado ou modificado diretamente de fora da classe.
        private int helth;
        // Propriedade pública para acessar e modificar a saúde do guerreiro
        // A propriedade usa "get" e "set" para controlar como o valor é lido e atribuído.
        public int Helth
        {
            // GET - Retorna o valor atual da saúde
            get
            {
                return helth;
            }
            // SET - Define o valor da saúde
            // Aqui é onde o encapsulamento é aplicado, pois podemos adicionar lógica personalizada.
            set
            {
                // Subtrai o valor recebido da saúde atual
                // Isso simula, por exemplo, o guerreiro recebendo dano.
                helth -= value;
                // Verifica se a saúde chegou a zero ou menos
                if (helth <= 0)
                {
                    // Se a saúde for menor ou igual a zero, define a saúde como zero
                    // Isso evita valores negativos de saúde.
                    helth = 0;

                    // Chama o método Die() para executar ações relacionadas à morte do guerreir
                    Die();
                }
            }
        }
        // Método privado que executa ações quando o guerreiro morre
        // O método é privado porque só deve ser chamado internamente pela classe
        private void Die()
        {
            //AÇÃO A SER EXERCIDA QUANDO O PERSONAGEM MORRE 
            //POR EXEMPLO GAMEOVER
            // ou qualquer outra lógica relacionada à morte.
            Debug.Log("O guerreiro morreu!");
        }
    }

    
}
