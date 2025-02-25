using UnityEngine;

// Classe OrcCharacter herda de MyCharacter
public class OrcCharacter : MyCharacter
{
    // M�todo Start � chamado uma vez no in�cio do jogo
    void Start()
    {
        // Chama o m�todo Say da classe OrcCharacter (comportamento sobrescrito)
        Say();
    }

    // Sobrescreve o m�todo Say da classe MyCharacter
    // A palavra-chave 'override' indica que este m�todo substitui o m�todo virtual da classe base.
    public override void Say()
    {
        // Comportamento personalizado: exibe uma mensagem espec�fica para o Orc
        Debug.Log("Ol� Humano!!!");
    }

}
