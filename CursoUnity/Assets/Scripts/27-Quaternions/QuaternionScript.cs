using UnityEngine;

// Classe que demonstra o uso de Quaternions para manipulação de rotações
public class QuaternionScript : MonoBehaviour
{
    // Referência para o objeto alvo (usado para calcular rotações)
    public Transform target;
    // Referência para outro objeto (usado para interpolar rotações)
    public Transform anotherObject;
    // Variável para contar o tempo, usada na interpolação de rotações
    float timeCount = 0;
    // Método Start é chamado automaticamente pelo Unity quando o jogo inicia
    public void Start()
    {
        // Exibe no console a rotação identidade (sem rotação)
        Debug.Log(Quaternion.identity);

        

    }

    // Método Update é chamado uma vez por frame
    private void Update()
    {
        // Exemplo de como calcular uma rotação para olhar para o objeto alvo
        //Vector3 Pos = target.position - transform.position;

        //transform.rotation = Quaternion.LookRotation(Pos);

        // Interpolação suave (Spherical Linear Interpolation - Slerp) entre as rotações de "target" e "anotherObject"
        // Quanto maior o valor de timeCount, mais próxima a rotação será de "anotherObject"
        transform.rotation = Quaternion.Slerp(target.rotation, anotherObject.rotation, timeCount);
        // Incrementa timeCount com o tempo passado desde o último frame
        // Isso faz com que a interpolação avance ao longo do tempo
        timeCount += Time.deltaTime ;
    }
}
