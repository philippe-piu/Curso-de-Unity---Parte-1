using System;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    // Declaração de uma classe chamada 'Inimigos', que será usada para armazenar as informações dos inimigos
    [Serializable]  // Atributo que permite que a classe seja serializada pelo Unity (visualizada no Inspector)
    public class Inimigos //Classe Inimigos
    {
        public string name; // Nome do inimigo
        public float velocidade; // Velocidade do inimigo
        public int dano; // Dano causado pelo inimigo

        // Construtor da classe Inimigos, que permite a criação de objetos Inimigos com valores específicos
        public Inimigos(string name, float velocidade, int dano)
        {
            this.name = name; // Atribui o valor do parâmetro 'name' ao campo 'name' da classe
            this.velocidade = velocidade; // Atribui o valor de 'velocidade' ao campo 'velocidade'
            this.dano = dano; // Atribui o valor de 'dano' ao campo 'dano'
        }
    }

    // Declaração de uma lista chamada 'inimigos', que vai armazenar objetos da classe 'Inimigos'
    // A lista pode ser acessada e manipulada diretamente, e é do tipo genérico 'List<Inimigos>'
    public List<Inimigos> inimigos = new List<Inimigos>();

    // Método Start é chamado uma vez quando o script é iniciado ou o jogo começa
    public void Start()
    {
        // Adiciona novos inimigos à lista usando o construtor da classe 'Inimigos' quando o jogo se iniciar
        inimigos.Add(new Inimigos("Oi", 10f, 15));
        inimigos.Add(new Inimigos("Oi", 15f, 153));
    }
}
