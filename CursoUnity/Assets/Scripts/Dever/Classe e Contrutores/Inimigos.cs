using System;
using UnityEngine;
/*1 - Fa�a um Classe e Controtores de inimigos com 3 inimigos diferentes*/
public class Inimigos : MonoBehaviour
{
    // Atributo [Serializable] permite que a classe Inimigo apare�a no inspetor do Unity
    // (apenas se voc� criar uma inst�ncia p�blica de Inimigo).
    [Serializable]
    public class Inimigo // Classe
    {
        public string name; // Nome do inimigo
        public int life; // Vida do inimigo
        public int damage; // Dano que o inimigo causa

        // Construtor da classe Inimigo para inicializar os atributos
        public Inimigo(string Name, int Life, int Damage)
        {
            name = Name; // Inicializa o nome do inimigo
            life = Life; // Inicializa a vida do inimigo
            damage = Damage; // Inicializa o dano do inimigo
        }

    }

    // Inst�ncia p�blica da classe Inimigo que pode ser definida no inspetor do Unity
    public Inimigo Ini;
    public Inimigo Ini2;
    public Inimigo Ini3;

    // M�todo Start � chamado ao iniciar o script
    public void Start()
    {
        // Exibe as informa��es do inimigo no console do Unity
        Debug.Log("Nome do Inimigo �: " + Ini.name);
        Debug.Log("Vida do Inimigo �: " + Ini.life);
        Debug.Log("Dano do Inimigo de ataque �: " + Ini.damage);

        // Exibe as informa��es do inimigo no console do Unity
        Debug.Log("Nome do Inimigo �: " + Ini2.name);
        Debug.Log("Vida do Inimigo �: " + Ini2.life);
        Debug.Log("Dano do Inimigo de ataque �: " + Ini2.damage);

        // Exibe as informa��es do inimigo no console do Unity
        Debug.Log("Nome do Inimigo �: " + Ini3.name);
        Debug.Log("Vida do Inimigo �: " + Ini3.life);
        Debug.Log("Dano do Inimigo de ataque �: " + Ini3.damage);
    }
}
