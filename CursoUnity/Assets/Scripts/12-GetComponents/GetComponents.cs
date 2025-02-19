using UnityEngine;

public class GetComponents : MonoBehaviour
{
    // Declaração das variáveis públicas que armazenarão os componentes do GameObject
    public Rigidbody rbd;
    public BoxCollider box;

    //Chamado uma vez ao início do script/jogo
    void Start()
    {
        // Obtém o componente Rigidbody do mesmo GameObject e armazena na variável rbd
        rbd = GetComponent<Rigidbody>();
        // Obtém o componente BoxCollider do mesmo GameObject e armazena na variável box
        box = GetComponent<BoxCollider>();
    }

    // Chamado a cada frame do jogo
    void Update()
    {
        
    }
}
