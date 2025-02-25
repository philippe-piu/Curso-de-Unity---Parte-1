using UnityEngine;

// Classe OrcCharacter herda de MyCharacter
public class OrcCharacter : MyCharacter
{
    // Método Start é chamado uma vez no início do jogo
    void Start()
    {
        // Chama o método Say da classe OrcCharacter (comportamento sobrescrito)
        Say();
    }

    // Sobrescreve o método Say da classe MyCharacter
    // A palavra-chave 'override' indica que este método substitui o método virtual da classe base.
    public override void Say()
    {
        // Comportamento personalizado: exibe uma mensagem específica para o Orc
        Debug.Log("Olá Humano!!!");
    }

}
