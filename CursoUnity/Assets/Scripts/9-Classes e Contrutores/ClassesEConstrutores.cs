using System;
using UnityEngine;

public class ClassesEConstrutores : MonoBehaviour
{
    // Define uma classe chamada "ClassesEConstrutores" que herda de MonoBehaviour
    // Isso permite que ela seja anexada a um GameObject dentro do Unity

    [Serializable]
    public class Cachorro //Classe "Cachorro"
    {
        // Declaração de atributos da classe "Cachorro"
        public string raca; // Representa a raça do cachorro
        public int idade; // Representa a idade do cachorro
        public int tamanho; // Representa o tamanho do cachorro

        // Construtor da classe "Cachorro"
        // Um construtor é um método especial que é chamado quando um objeto da classe é criado
        public Cachorro(string Raca, int Idade, int Tamanho)
        {
            // Atribui os valores recebidos aos atributos da classe
            raca = Raca;
            idade = Idade;
            tamanho = Tamanho;
        }

    }

    // Criando um objeto da classe Cachorro (Comentado no código original)
    //public Cachorro Dog = new Cachorro("Pitbull", 5, 80);

    // Declaração de um objeto do tipo Cachorro, mas sem inicializá-lo no código
    public Cachorro Dog;

    // O método Start() é chamado automaticamente uma vez quando o jogo inicia
    public void Start()
    {
        // Exibe informações do cachorro no Console do Unity
        Debug.Log("A Racha do cachorro é "+Dog.raca);
        Debug.Log("A idade do cachorro é " + Dog.idade);
        Debug.Log("O tamanho do cachorro é " + Dog.tamanho);
    }

   
}

/*Explicação sobre Classes e Construtores
1 - O que é uma classe?

Uma classe é um modelo que define as propriedades e comportamentos de um objeto.
No código, a classe Cachorro representa um cachorro com atributos como raça, idade e tamanho.

2 - O que é um construtor?

Um construtor é um método especial de uma classe que é chamado automaticamente quando um novo objeto dessa classe é criado.
Ele geralmente inicializa os atributos da classe.
No código, o construtor de Cachorro recebe três parâmetros (Raca, Idade, Tamanho) e os atribui às variáveis da classe.

 Identificação no Código
    Classe:
        public class Cachorro

    Aqui, Cachorro é uma classe que define um modelo para criar objetos do tipo cachorro.

    Construtor:
        public Cachorro(string Raca, int Idade, int Tamanho)
    Esse é o construtor da classe Cachorro. Ele recebe três parâmetros e os atribui aos atributos correspondentes.

O que o código faz?
 1 - Define a classe Cachorro com os atributos raca, idade e tamanho.
 2 - Cria um construtor que inicializa esses atributos quando um objeto Cachorro é criado.
 3 - Declara um objeto Dog do tipo Cachorro, mas sem inicializá-lo no código.
 4 - No método Start(), tenta acessar os atributos do objeto Dog.
    Como o objeto Dog não foi inicializado, o código pode gerar um erro de referência nula (NullReferenceException).
    Para evitar isso, o objeto Dog deveria ser criado com o construtor antes de ser usado:
    public Cachorro Dog = new Cachorro("Pitbull", 5, 80);

 */