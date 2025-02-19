using UnityEngine;

public class GetComponents : MonoBehaviour
{
    // Declara��o das vari�veis p�blicas que armazenar�o os componentes do GameObject
    public Rigidbody rbd;
    public BoxCollider box;

    //Chamado uma vez ao in�cio do script/jogo
    void Start()
    {
        // Obt�m o componente Rigidbody do mesmo GameObject e armazena na vari�vel rbd
        rbd = GetComponent<Rigidbody>();
        // Obt�m o componente BoxCollider do mesmo GameObject e armazena na vari�vel box
        box = GetComponent<BoxCollider>();
    }

    // Chamado a cada frame do jogo
    void Update()
    {
        
    }
}
