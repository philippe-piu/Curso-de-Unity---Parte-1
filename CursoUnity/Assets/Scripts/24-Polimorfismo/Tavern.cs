using UnityEngine;

public class Tavern : MonoBehaviour
{
    // Array de personagens (do tipo MyCharacter)
    public MyCharacter[] chars;

    // M�todo Start � chamado uma vez no in�cio do jogo
    private void Start()
    {
        // Inicializa o array com 2 posi��es
        chars = new MyCharacter[2];
        // Cria uma inst�ncia de ManCharacter e a adiciona ao array
        chars[0] = new ManCharacter();
        // Cria uma inst�ncia de OrcCharacter e a adiciona ao array
        chars[1] = new OrcCharacter();

        // Chama o m�todo para simular a entrada dos personagens na taverna
        EnterTaverna();
    }

    // M�todo para simular a entrada dos personagens na taverna
    public void EnterTaverna()
    {
        // Itera sobre cada personagem no array
        foreach (MyCharacter c in chars) {
            // Chama o m�todo Say do personagem
            // Aqui o polimorfismo entra em a��o:
            // - Se o personagem for do tipo ManCharacter, o m�todo Say da classe MyCharacter ser� chamado.
            // - Se o personagem for do tipo OrcCharacter, o m�todo Say sobrescrito na classe OrcCharacter ser� chamado.
            c.Say();
        }
    }
}
