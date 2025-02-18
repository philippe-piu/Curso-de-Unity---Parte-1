using System;
using UnityEngine;

public class ClassesEConstrutores : MonoBehaviour
{
    // Define uma classe chamada "ClassesEConstrutores" que herda de MonoBehaviour
    // Isso permite que ela seja anexada a um GameObject dentro do Unity

    [Serializable]
    public class Cachorro //Classe "Cachorro"
    {
        // Declara��o de atributos da classe "Cachorro"
        public string raca; // Representa a ra�a do cachorro
        public int idade; // Representa a idade do cachorro
        public int tamanho; // Representa o tamanho do cachorro

        // Construtor da classe "Cachorro"
        // Um construtor � um m�todo especial que � chamado quando um objeto da classe � criado
        public Cachorro(string Raca, int Idade, int Tamanho)
        {
            // Atribui os valores recebidos aos atributos da classe
            raca = Raca;
            idade = Idade;
            tamanho = Tamanho;
        }

    }

    // Criando um objeto da classe Cachorro (Comentado no c�digo original)
    //public Cachorro Dog = new Cachorro("Pitbull", 5, 80);

    // Declara��o de um objeto do tipo Cachorro, mas sem inicializ�-lo no c�digo
    public Cachorro Dog;

    // O m�todo Start() � chamado automaticamente uma vez quando o jogo inicia
    public void Start()
    {
        // Exibe informa��es do cachorro no Console do Unity
        Debug.Log("A Racha do cachorro � "+Dog.raca);
        Debug.Log("A idade do cachorro � " + Dog.idade);
        Debug.Log("O tamanho do cachorro � " + Dog.tamanho);
    }

   
}

/*Explica��o sobre Classes e Construtores
1 - O que � uma classe?

Uma classe � um modelo que define as propriedades e comportamentos de um objeto.
No c�digo, a classe Cachorro representa um cachorro com atributos como ra�a, idade e tamanho.

2 - O que � um construtor?

Um construtor � um m�todo especial de uma classe que � chamado automaticamente quando um novo objeto dessa classe � criado.
Ele geralmente inicializa os atributos da classe.
No c�digo, o construtor de Cachorro recebe tr�s par�metros (Raca, Idade, Tamanho) e os atribui �s vari�veis da classe.

 Identifica��o no C�digo
    Classe:
        public class Cachorro

    Aqui, Cachorro � uma classe que define um modelo para criar objetos do tipo cachorro.

    Construtor:
        public Cachorro(string Raca, int Idade, int Tamanho)
    Esse � o construtor da classe Cachorro. Ele recebe tr�s par�metros e os atribui aos atributos correspondentes.

O que o c�digo faz?
 1 - Define a classe Cachorro com os atributos raca, idade e tamanho.
 2 - Cria um construtor que inicializa esses atributos quando um objeto Cachorro � criado.
 3 - Declara um objeto Dog do tipo Cachorro, mas sem inicializ�-lo no c�digo.
 4 - No m�todo Start(), tenta acessar os atributos do objeto Dog.
    Como o objeto Dog n�o foi inicializado, o c�digo pode gerar um erro de refer�ncia nula (NullReferenceException).
    Para evitar isso, o objeto Dog deveria ser criado com o construtor antes de ser usado:
    public Cachorro Dog = new Cachorro("Pitbull", 5, 80);

 */