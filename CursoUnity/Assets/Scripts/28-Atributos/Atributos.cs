using UnityEngine;

public class Atributos : MonoBehaviour
{
    
    [HideInInspector]//Oculta variáveis publicas do inspector
    public int Score;

    [SerializeField]//Mostra variáveis privada no inspector
    private int point;


    [Header("Life do Player")]//Cria um cabeçalho no inspector na Unity
    public int Life;


    [Tooltip("Variáveis que não são numerica")]
    public string Name;

    [Range(-5 , 5)] //Cria uma barra no inspector da unity de -5 até 5
    public float BarraVida;

    [Space]// Cria um espaço entre as variáveis no inspector

    [TextArea]// Cria um campo de texto maior para escrever no inspector;
    public string textArea;



}
