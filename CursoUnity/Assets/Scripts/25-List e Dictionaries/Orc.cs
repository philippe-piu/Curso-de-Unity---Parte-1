using UnityEngine;

// Classe que representa um Orc
public class Orc 
{
    // Propriedade para armazenar o nome do Orc
    public string Name;
    // Propriedade para armazenar o nível do Orc
    public int Level;

    // Construtor da classe Orc
    // Recebe o nome e o nível como parâmetros e os atribui às propriedades
    public Orc(string name, int level)
    {
        Name = name;
        Level = level;
    }   
}
