using UnityEngine;

public class InstantiateEDestroy : MonoBehaviour
{
    // Prefab do objeto que será instanciado na cena
    public GameObject prefab;

    // Objeto pai onde o prefab será instanciado
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
            // Instancia o prefab na cena sem especificar posição e rotação (irá aparecer na posição padrão)
            //Instantiate(prefab);

            // Instancia o prefab na posição (0,0,0) com rotação padrão
            //Instantiate(prefab, new Vector3(0,0,0), Quaternion.identity);

            // Instancia o prefab na mesma posição e rotação do objetoPai
            Instantiate(prefab, objetoPai.transform.position, objetoPai.transform.rotation);
        }

        
        
    }
}
