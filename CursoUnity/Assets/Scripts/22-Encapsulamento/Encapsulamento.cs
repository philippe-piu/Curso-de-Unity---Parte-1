using UnityEngine;

public class Encapsulamento : MonoBehaviour
{
    /* ENCAPSULAMENTO */
    // O encapsulamento � um dos pilares da Programa��o Orientada a Objetos (POO).
    // Ele permite controlar o acesso aos dados de uma classe, protegendo-os de modifica��es indevidas
    // e garantindo que as regras de neg�cio sejam respeitadas.

    /*ENCAPSULAMOS COM SUCESSO O VALOR 'HEALTH' PRIVADO E AO FAZER ISSO, PROTEGEMOS
     O 'WARRIOR' DE TER UM 'HEALT' ABAIXO DE ZERO*/

    // Defini��o da classe Warrior (Guerreiro)

    public class Warrior
    {
        // Campo privado para armazenar a sa�de (vida) do guerreiro
        // O campo � privado para que n�o possa ser acessado ou modificado diretamente de fora da classe.
        private int helth;
        // Propriedade p�blica para acessar e modificar a sa�de do guerreiro
        // A propriedade usa "get" e "set" para controlar como o valor � lido e atribu�do.
        public int Helth
        {
            // GET - Retorna o valor atual da sa�de
            get
            {
                return helth;
            }
            // SET - Define o valor da sa�de
            // Aqui � onde o encapsulamento � aplicado, pois podemos adicionar l�gica personalizada.
            set
            {
                // Subtrai o valor recebido da sa�de atual
                // Isso simula, por exemplo, o guerreiro recebendo dano.
                helth -= value;
                // Verifica se a sa�de chegou a zero ou menos
                if (helth <= 0)
                {
                    // Se a sa�de for menor ou igual a zero, define a sa�de como zero
                    // Isso evita valores negativos de sa�de.
                    helth = 0;

                    // Chama o m�todo Die() para executar a��es relacionadas � morte do guerreir
                    Die();
                }
            }
        }
        // M�todo privado que executa a��es quando o guerreiro morre
        // O m�todo � privado porque s� deve ser chamado internamente pela classe
        private void Die()
        {
            //A��O A SER EXERCIDA QUANDO O PERSONAGEM MORRE 
            //POR EXEMPLO GAMEOVER
            // ou qualquer outra l�gica relacionada � morte.
            Debug.Log("O guerreiro morreu!");
        }
    }

    
}
