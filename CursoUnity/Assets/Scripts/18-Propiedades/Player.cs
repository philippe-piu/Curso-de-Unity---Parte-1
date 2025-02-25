using UnityEngine;
using UnityEngine.Rendering;

public class Player : MonoBehaviour
{
    // Campo privado para armazenar a experiência do jogador
    private int exp;

    // Propriedade pública para acessar e modificar a experiência do jogador
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

    // Propriedade pública para calcular a vida do jogador com base na experiência
    public int Life
    {
        // GET - Retorna a vida do jogador, que é calculada como a experiência dividida por 10
        get
        {

            return exp / 10;
        }
        // SET - Define a experiência do jogador com base na vida desejada (vida * 10)
        set
        {

            exp = value * 10;

        }
    }

    // Propriedade autoimplementada para as vidas do jogador
    // O compilador cria automaticamente um campo privado e os métodos get/set
    public int Lives { set; get; }
   
}




