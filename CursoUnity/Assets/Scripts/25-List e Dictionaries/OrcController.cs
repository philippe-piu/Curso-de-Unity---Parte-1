using System.Collections.Generic;
using UnityEngine;

// Classe que controla a lista e o dicion�rio de Orcs
public class OrcController : MonoBehaviour
{
    // Lista p�blica para armazenar objetos do tipo Orc
    public List<Orc> OrcList = new List<Orc>();

    // Dicion�rio para armazenar Orcs com uma chave do tipo string
    Dictionary<string, Orc> orc = new Dictionary<string, Orc>();

    // M�todo Start � chamado automaticamente pelo Unity quando o jogo inicia
    public void Start()
    {
        // Chama o m�todo para usar a lista de Orcs
        UsingList();
        // Chama o m�todo para usar o dicion�rio de Orcs
        UsingDictionary();
    }

    // M�todo para demonstrar o uso de uma lista de Orcs
    public void UsingList()
    {
        // Adiciona novos Orcs � lista
        OrcList.Add(new Orc("Orc Bravo", 10));
        OrcList.Add(new Orc("Orc Feliz", 20));
        OrcList.Add(new Orc("Orc Chefe", 30));

        // Itera sobre a lista de Orcs e exibe o nome de cada um no console
        foreach (Orc orc in OrcList)
        {
            Debug.Log(orc.Name);
        }
    }

    // M�todo para demonstrar o uso de um dicion�rio de Orcs
    public void UsingDictionary()
    {
        // Cria novos objetos Orc
        Orc orc1 = new Orc("Zacu", 50);
        Orc orc2 = new Orc("Elfo", 60);
        Orc orc3 = new Orc("FDogo", 70);

        // Adiciona os Orcs ao dicion�rio, associando cada um a uma chave �nica
        orc.Add("Guerreiro", orc1 );
        orc.Add("Shaman", orc2);
        orc.Add("Arqueiro", orc3);
        // Recupera um Orc do dicion�rio usando a chave "Arqueiro"
        Orc orc4 = orc["Arqueiro"];
        // Vari�vel para armazenar um Orc temporariamente (inicializada como null)
       // Orc orc5 = null;

        // Tenta recuperar um Orc do dicion�rio usando a chave "Fazendeiro"
        // Se a chave existir, orc4 recebe o valor correspondente
        // Caso contr�rio, o bloco else � executado
        if (orc.TryGetValue("Fazendeiro", out orc4))
        {
            //SE VERDADEIRO
            Debug.Log("Existe");
        }
        else
        {
            //SE FALSO
            Debug.Log("N�o Existe");
        }
    }
}
