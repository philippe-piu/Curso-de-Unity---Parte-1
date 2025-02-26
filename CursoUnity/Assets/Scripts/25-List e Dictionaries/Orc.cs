using UnityEngine;

// Classe que representa um Orc
public class Orc 
{
    // Propriedade para armazenar o nome do Orc
    public string Name;
    // Propriedade para armazenar o n�vel do Orc
    public int Level;

    // Construtor da classe Orc
    // Recebe o nome e o n�vel como par�metros e os atribui �s propriedades
    public Orc(string name, int level)
    {
        Name = name;
        Level = level;
    }   
}
