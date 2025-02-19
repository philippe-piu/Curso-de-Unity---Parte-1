using UnityEngine;

public class ManipulandoGetComponentsEGameObects : MonoBehaviour
{
    //Ativar e desativar 
    // Vari�vel p�blica para armazenar um GameObject que ser� ativado ou desativado
    public GameObject objeto;

     //Chamado uma vez ao in�cio do script/jogo
    void Start()
    {


        // Desativando o GameObject da cena (comenta/descomenta para testar)
        //objeto.SetActive(false);

        // Outra forma de desativar um componente espec�fico dentro do GameObject
        //objeto.GetComponent<Light>().enabled = false;

        // Verifica se o GameObject est� ativo na cena
        if (objeto.activeSelf)
        {
            // Se estiver ativo, desativa o objeto
            objeto.SetActive(false);

            Debug.Log(objeto.activeSelf);
        }
        else
        {
            // Se estiver desativado, ativa o objeto
            objeto.SetActive(true);
            Debug.Log(objeto.activeSelf);
        }
    }

    // Chamado a cada frame do jogo
    void Update()
    {
        
    }
}
