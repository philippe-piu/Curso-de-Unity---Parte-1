using System;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    // Declara��o de uma classe chamada 'Inimigos', que ser� usada para armazenar as informa��es dos inimigos
    [Serializable]  // Atributo que permite que a classe seja serializada pelo Unity (visualizada no Inspector)
    public class Inimigos //Classe Inimigos
    {
        public string name; // Nome do inimigo
        public float velocidade; // Velocidade do inimigo
        public int dano; // Dano causado pelo inimigo

        // Construtor da classe Inimigos, que permite a cria��o de objetos Inimigos com valores espec�ficos
        public Inimigos(string name, float velocidade, int dano)
        {
            this.name = name; // Atribui o valor do par�metro 'name' ao campo 'name' da classe
            this.velocidade = velocidade; // Atribui o valor de 'velocidade' ao campo 'velocidade'
            this.dano = dano; // Atribui o valor de 'dano' ao campo 'dano'
        }
    }

    // Declara��o de uma lista chamada 'inimigos', que vai armazenar objetos da classe 'Inimigos'
    // A lista pode ser acessada e manipulada diretamente, e � do tipo gen�rico 'List<Inimigos>'
    public List<Inimigos> inimigos = new List<Inimigos>();

    // M�todo Start � chamado uma vez quando o script � iniciado ou o jogo come�a
    public void Start()
    {
        // Adiciona novos inimigos � lista usando o construtor da classe 'Inimigos' quando o jogo se iniciar
        inimigos.Add(new Inimigos("Oi", 10f, 15));
        inimigos.Add(new Inimigos("Oi", 15f, 153));
    }
}
