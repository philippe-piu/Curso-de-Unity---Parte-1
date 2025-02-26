using System.Collections.Generic;
using UnityEngine;

// Classe que controla a lista e o dicionário de Orcs
public class OrcController : MonoBehaviour
{
    // Lista pública para armazenar objetos do tipo Orc
    public List<Orc> OrcList = new List<Orc>();

    // Dicionário para armazenar Orcs com uma chave do tipo string
    Dictionary<string, Orc> orc = new Dictionary<string, Orc>();

    // Método Start é chamado automaticamente pelo Unity quando o jogo inicia
    public void Start()
    {
        // Chama o método para usar a lista de Orcs
        UsingList();
        // Chama o método para usar o dicionário de Orcs
        UsingDictionary();
    }

    // Método para demonstrar o uso de uma lista de Orcs
    public void UsingList()
    {
        // Adiciona novos Orcs à lista
        OrcList.Add(new Orc("Orc Bravo", 10));
        OrcList.Add(new Orc("Orc Feliz", 20));
        OrcList.Add(new Orc("Orc Chefe", 30));

        // Itera sobre a lista de Orcs e exibe o nome de cada um no console
        foreach (Orc orc in OrcList)
        {
            Debug.Log(orc.Name);
        }
    }

    // Método para demonstrar o uso de um dicionário de Orcs
    public void UsingDictionary()
    {
        // Cria novos objetos Orc
        Orc orc1 = new Orc("Zacu", 50);
        Orc orc2 = new Orc("Elfo", 60);
        Orc orc3 = new Orc("FDogo", 70);

        // Adiciona os Orcs ao dicionário, associando cada um a uma chave única
        orc.Add("Guerreiro", orc1 );
        orc.Add("Shaman", orc2);
        orc.Add("Arqueiro", orc3);
        // Recupera um Orc do dicionário usando a chave "Arqueiro"
        Orc orc4 = orc["Arqueiro"];
        // Variável para armazenar um Orc temporariamente (inicializada como null)
       // Orc orc5 = null;

        // Tenta recuperar um Orc do dicionário usando a chave "Fazendeiro"
        // Se a chave existir, orc4 recebe o valor correspondente
        // Caso contrário, o bloco else é executado
        if (orc.TryGetValue("Fazendeiro", out orc4))
        {
            //SE VERDADEIRO
            Debug.Log("Existe");
        }
        else
        {
            //SE FALSO
            Debug.Log("Não Existe");
        }
    }
}
