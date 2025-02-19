using UnityEngine;

public class InstantiateEDestroy : MonoBehaviour
{
    // Prefab do objeto que ser� instanciado na cena
    public GameObject prefab;

    // Objeto pai onde o prefab ser� instanciado
    public GameObject objetoPai;
  

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Verifica se a tecla "Q" foi pressionada
        if (Input.GetKeyDown(KeyCode.Q)) {
            // Instancia o prefab na cena sem especificar posi��o e rota��o (ir� aparecer na posi��o padr�o)
            //Instantiate(prefab);

            // Instancia o prefab na posi��o (0,0,0) com rota��o padr�o
            //Instantiate(prefab, new Vector3(0,0,0), Quaternion.identity);

            // Instancia o prefab na mesma posi��o e rota��o do objetoPai
            Instantiate(prefab, objetoPai.transform.position, objetoPai.transform.rotation);
        }

        
        
    }
}
