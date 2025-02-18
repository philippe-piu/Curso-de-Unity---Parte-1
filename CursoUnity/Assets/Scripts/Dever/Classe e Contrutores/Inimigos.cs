using System;
using UnityEngine;
/*1 - Faça um Classe e Controtores de inimigos com 3 inimigos diferentes*/
public class Inimigos : MonoBehaviour
{
    // Atributo [Serializable] permite que a classe Inimigo apareça no inspetor do Unity
    // (apenas se você criar uma instância pública de Inimigo).
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

    // Instância pública da classe Inimigo que pode ser definida no inspetor do Unity
    public Inimigo Ini;
    public Inimigo Ini2;
    public Inimigo Ini3;

    // Método Start é chamado ao iniciar o script
    public void Start()
    {
        // Exibe as informações do inimigo no console do Unity
        Debug.Log("Nome do Inimigo é: " + Ini.name);
        Debug.Log("Vida do Inimigo é: " + Ini.life);
        Debug.Log("Dano do Inimigo de ataque é: " + Ini.damage);

        // Exibe as informações do inimigo no console do Unity
        Debug.Log("Nome do Inimigo é: " + Ini2.name);
        Debug.Log("Vida do Inimigo é: " + Ini2.life);
        Debug.Log("Dano do Inimigo de ataque é: " + Ini2.damage);

        // Exibe as informações do inimigo no console do Unity
        Debug.Log("Nome do Inimigo é: " + Ini3.name);
        Debug.Log("Vida do Inimigo é: " + Ini3.life);
        Debug.Log("Dano do Inimigo de ataque é: " + Ini3.damage);
    }
}
