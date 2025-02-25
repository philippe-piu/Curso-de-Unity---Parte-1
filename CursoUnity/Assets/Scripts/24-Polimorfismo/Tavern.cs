using UnityEngine;

public class Tavern : MonoBehaviour
{
    // Array de personagens (do tipo MyCharacter)
    public MyCharacter[] chars;

    // Método Start é chamado uma vez no início do jogo
    private void Start()
    {
        // Inicializa o array com 2 posições
        chars = new MyCharacter[2];
        // Cria uma instância de ManCharacter e a adiciona ao array
        chars[0] = new ManCharacter();
        // Cria uma instância de OrcCharacter e a adiciona ao array
        chars[1] = new OrcCharacter();

        // Chama o método para simular a entrada dos personagens na taverna
        EnterTaverna();
    }

    // Método para simular a entrada dos personagens na taverna
    public void EnterTaverna()
    {
        // Itera sobre cada personagem no array
        foreach (MyCharacter c in chars) {
            // Chama o método Say do personagem
            // Aqui o polimorfismo entra em ação:
            // - Se o personagem for do tipo ManCharacter, o método Say da classe MyCharacter será chamado.
            // - Se o personagem for do tipo OrcCharacter, o método Say sobrescrito na classe OrcCharacter será chamado.
            c.Say();
        }
    }
}
