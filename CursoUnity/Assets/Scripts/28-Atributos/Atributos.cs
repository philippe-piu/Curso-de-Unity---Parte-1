using UnityEngine;

public class Atributos : MonoBehaviour
{
    
    [HideInInspector]//Oculta vari�veis publicas do inspector
    public int Score;

    [SerializeField]//Mostra vari�veis privada no inspector
    private int point;


    [Header("Life do Player")]//Cria um cabe�alho no inspector na Unity
    public int Life;


    [Tooltip("Vari�veis que n�o s�o numerica")]
    public string Name;

    [Range(-5 , 5)] //Cria uma barra no inspector da unity de -5 at� 5
    public float BarraVida;

    [Space]// Cria um espa�o entre as vari�veis no inspector

    [TextArea]// Cria um campo de texto maior para escrever no inspector;
    public string textArea;



}
