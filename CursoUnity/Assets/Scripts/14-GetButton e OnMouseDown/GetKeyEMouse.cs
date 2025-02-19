using UnityEngine;

public class GetKeyEMouse : MonoBehaviour
{
    //Chamado uma vez ao in�cio do script/jogo
    void Start()
    {

    }

    //Chamado a cada frame do jogo
    void Update()
    {
        //Verifica se a tecla "A" est� sendo pressionada continuamente
        // Enquanto a tecla estiver pressionada, a mensagem "Tecla A Ativa" ser� exibida
        // Caso contr�rio, ser� exibida "Tecla A Desativada"
        //if (Input.GetKey(KeyCode.A))
        //        {
        //            Debug.Log("Tecla A Ativa");
        //        }
        //        else
        //        {
        //            Debug.Log("Tecla A Desativada");
        //        }

        // Verifica se a tecla "B" foi pressionada **apenas uma vez**
        // Esse evento acontece apenas **no momento** que a tecla � pressionada
        //if (Input.GetKeyDown(KeyCode.B))
        //{
        //    Debug.Log("Tecla B Ativa");
        //}

        // Verifica se a tecla "C" foi solta depois de ser pressionada
        // O evento acontece **apenas no momento que a tecla � liberada**
        //if (Input.GetKeyUp(KeyCode.C))
        //{
        //    Debug.Log("Tecla C Ativa");
        //}


    }

    // ==========================================
    // EVENTOS DO MOUSE SOBRE O GAMEOBJECT
    // ==========================================

    // Detecta quando o mouse � **pressionado** sobre o GameObject que tem esse script
    //public void OnMouseDown()
    //{
    //    Debug.Log("Clicou !");
    //}

    // Detecta quando o bot�o do mouse est� pressionado e arrastado sobre o GameObject
    //public void OnMouseDrag()
    //{
    //    Debug.Log("Est� Clicado e Segurado!");
    //}

    // Detecta quando o mouse **entra** na �rea do GameObject na cena
    //public void OnMouseEnter()
    //{
    //    Debug.Log("Mouse encima do GameObject na Cena !");
    //}

    // Detecta quando o mouse **sai** da �rea do GameObject
    //public void OnMouseExit()
    //{
    //    Debug.Log("Mouse n�o est� encima do GameObject na Cena !");
    //}

    // Detecta se o mouse **est� sobre** o GameObject **durante todo o tempo**
    // Diferente do `OnMouseEnter()`, esse m�todo **� chamado repetidamente** enquanto o mouse estiver sobre o objeto
    //public void OnMouseOver()
    //{
    //    //Enquanto o mouse estiver encima do objeto ele n�o para de mandar a mensagem
    //    Debug.Log("O mouse est� sobre o objeto!");
    //}

    // Detecta quando o bot�o do mouse **n�o est� mais pressionando** o GameObject
    //public void OnMouseUp()
    //{

    //    Debug.Log("O mouse n�o est� mais clicando sobre o objeto!");
    //}

    // Detecta se o bot�o do mouse **foi pressionado e solto sobre o mesmo objeto**
    // Funciona de maneira semelhante a um bot�o de UI
    //public void OnMouseUpAsButton()
    //{

    //    Debug.Log("O objeto foi clicado e solto corretamente!");
    //}
}
