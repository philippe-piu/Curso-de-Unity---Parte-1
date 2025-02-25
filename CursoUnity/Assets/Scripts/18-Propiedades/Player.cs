using UnityEngine;
using UnityEngine.Rendering;

public class Player : MonoBehaviour
{
    // Campo privado para armazenar a experi�ncia do jogador
    private int exp;

    // Propriedade p�blica para acessar e modificar a experi�ncia do jogador
    public int Experience
    {

        //GET - Retorna um valor
        get
        {

            return exp;
        }

        //SET - Atribui um valor
        set
        {

            exp = value;
        }
    }

    // Propriedade p�blica para calcular a vida do jogador com base na experi�ncia
    public int Life
    {
        // GET - Retorna a vida do jogador, que � calculada como a experi�ncia dividida por 10
        get
        {

            return exp / 10;
        }
        // SET - Define a experi�ncia do jogador com base na vida desejada (vida * 10)
        set
        {

            exp = value * 10;

        }
    }

    // Propriedade autoimplementada para as vidas do jogador
    // O compilador cria automaticamente um campo privado e os m�todos get/set
    public int Lives { set; get; }
   
}




