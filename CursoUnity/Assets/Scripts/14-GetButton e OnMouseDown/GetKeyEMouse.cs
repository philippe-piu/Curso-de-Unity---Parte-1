using UnityEngine;

public class GetKeyEMouse : MonoBehaviour
{
    //Chamado uma vez ao início do script/jogo
    void Start()
    {

    }

    //Chamado a cada frame do jogo
    void Update()
    {
        //Verifica se a tecla "A" está sendo pressionada continuamente
        // Enquanto a tecla estiver pressionada, a mensagem "Tecla A Ativa" será exibida
        // Caso contrário, será exibida "Tecla A Desativada"
        //if (Input.GetKey(KeyCode.A))
        //        {
        //            Debug.Log("Tecla A Ativa");
        //        }
        //        else
        //        {
        //            Debug.Log("Tecla A Desativada");
        //        }

        // Verifica se a tecla "B" foi pressionada **apenas uma vez**
        // Esse evento acontece apenas **no momento** que a tecla é pressionada
        //if (Input.GetKeyDown(KeyCode.B))
        //{
        //    Debug.Log("Tecla B Ativa");
        //}

        // Verifica se a tecla "C" foi solta depois de ser pressionada
        // O evento acontece **apenas no momento que a tecla é liberada**
        //if (Input.GetKeyUp(KeyCode.C))
        //{
        //    Debug.Log("Tecla C Ativa");
        //}


    }

    // ==========================================
    // EVENTOS DO MOUSE SOBRE O GAMEOBJECT
    // ==========================================

    // Detecta quando o mouse é **pressionado** sobre o GameObject que tem esse script
    //public void OnMouseDown()
    //{
    //    Debug.Log("Clicou !");
    //}

    // Detecta quando o botão do mouse está pressionado e arrastado sobre o GameObject
    //public void OnMouseDrag()
    //{
    //    Debug.Log("Está Clicado e Segurado!");
    //}

    // Detecta quando o mouse **entra** na área do GameObject na cena
    //public void OnMouseEnter()
    //{
    //    Debug.Log("Mouse encima do GameObject na Cena !");
    //}

    // Detecta quando o mouse **sai** da área do GameObject
    //public void OnMouseExit()
    //{
    //    Debug.Log("Mouse não está encima do GameObject na Cena !");
    //}

    // Detecta se o mouse **está sobre** o GameObject **durante todo o tempo**
    // Diferente do `OnMouseEnter()`, esse método **é chamado repetidamente** enquanto o mouse estiver sobre o objeto
    //public void OnMouseOver()
    //{
    //    //Enquanto o mouse estiver encima do objeto ele não para de mandar a mensagem
    //    Debug.Log("O mouse está sobre o objeto!");
    //}

    // Detecta quando o botão do mouse **não está mais pressionando** o GameObject
    //public void OnMouseUp()
    //{

    //    Debug.Log("O mouse não está mais clicando sobre o objeto!");
    //}

    // Detecta se o botão do mouse **foi pressionado e solto sobre o mesmo objeto**
    // Funciona de maneira semelhante a um botão de UI
    //public void OnMouseUpAsButton()
    //{

    //    Debug.Log("O objeto foi clicado e solto corretamente!");
    //}
}
