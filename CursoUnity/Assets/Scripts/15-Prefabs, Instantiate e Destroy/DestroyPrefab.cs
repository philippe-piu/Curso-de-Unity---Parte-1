using UnityEngine;

public class DestroyPrefab : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Verifica se a tecla "Z" foi pressionada
        if (Input.GetKeyDown(KeyCode.Z))
        {
            // Destroi o objeto que cont�m este script (gameObject � uma refer�ncia ao objeto atual)
            Destroy(gameObject);
            
        }
    }
}
