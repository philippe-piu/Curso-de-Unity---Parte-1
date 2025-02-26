using UnityEngine;

// Classe que demonstra o uso de Quaternions para manipula��o de rota��es
public class QuaternionScript : MonoBehaviour
{
    // Refer�ncia para o objeto alvo (usado para calcular rota��es)
    public Transform target;
    // Refer�ncia para outro objeto (usado para interpolar rota��es)
    public Transform anotherObject;
    // Vari�vel para contar o tempo, usada na interpola��o de rota��es
    float timeCount = 0;
    // M�todo Start � chamado automaticamente pelo Unity quando o jogo inicia
    public void Start()
    {
        // Exibe no console a rota��o identidade (sem rota��o)
        Debug.Log(Quaternion.identity);

        

    }

    // M�todo Update � chamado uma vez por frame
    private void Update()
    {
        // Exemplo de como calcular uma rota��o para olhar para o objeto alvo
        //Vector3 Pos = target.position - transform.position;

        //transform.rotation = Quaternion.LookRotation(Pos);

        // Interpola��o suave (Spherical Linear Interpolation - Slerp) entre as rota��es de "target" e "anotherObject"
        // Quanto maior o valor de timeCount, mais pr�xima a rota��o ser� de "anotherObject"
        transform.rotation = Quaternion.Slerp(target.rotation, anotherObject.rotation, timeCount);
        // Incrementa timeCount com o tempo passado desde o �ltimo frame
        // Isso faz com que a interpola��o avance ao longo do tempo
        timeCount += Time.deltaTime ;
    }
}
