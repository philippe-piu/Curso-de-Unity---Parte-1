using UnityEngine;

public class POO : MonoBehaviour
{
    /*PROGRAMAÇÃO ORIENTADA A OBJETOR*/
    /*TODO SCRIPT NA UNITY É UMA CLASSE LOGO EM SUA ESSENCIA, TODO PROJETO
     CRIADO NA UNITY É OBRIGATORIAMENTE ORIENTADO A OBJETOS*/
    public class Personagem
    {
        //CARACTERISTICAS DESSE OBJETO
        float life;
        float power;
        float Exp;

        //COMPOTAMENTO DESSE OBJETO
        void aumentarVida()
        {
            //FAZ ALGO
        }

        //PERSONALIZAR OBJETO
        Personagem(float exp)
        {
            Exp = exp;
        }
    }

    //OBJETO INSTÂNCIA DA CLASSE PERSONAGEM
    private Personagem p1;

    private void Start()
    {
        //p1 = new Personagem(50f);
    }





}
