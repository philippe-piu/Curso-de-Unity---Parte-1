using UnityEngine;

public class Variaveis : MonoBehaviour
{
    //Como declarar uma vari�vel
    public int valorInteiro;
    private int valorInt = 15;
    public float numerosDecimais = 3.2f;
    public string texto = "Oi";
    public GameObject gameOb;
    public Transform gameObTransform;

    //Declara��o de vari�vel da unity
    public Rigidbody rbd;
    //Tem varios colliders
    public Collider colli;


    //Chamado uma vez ao in�cio do script/jogo
    void Start()
    {
     
        //Mensagem para vizualizar no console da unity
        Debug.Log("Valor publico = " + valorInteiro);
        Debug.Log("Valor privado = "+valorInt);
    }

    // Chamado a cada frame do jogo
    void Update()
    {
        
    }
}
