using UnityEngine;

public class POO : MonoBehaviour
{
    /*PROGRAMA��O ORIENTADA A OBJETOR*/
    /*TODO SCRIPT NA UNITY � UMA CLASSE LOGO EM SUA ESSENCIA, TODO PROJETO
     CRIADO NA UNITY � OBRIGATORIAMENTE ORIENTADO A OBJETOS*/
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

    //OBJETO INST�NCIA DA CLASSE PERSONAGEM
    private Personagem p1;

    private void Start()
    {
        //p1 = new Personagem(50f);
    }





}
