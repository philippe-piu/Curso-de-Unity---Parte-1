using UnityEngine;

public class MétodosEVariáveisEstáticas : MonoBehaviour
{
    // Criando uma variável estática do próprio tipo da classe
    // Isso permite que qualquer outro script acesse essa instância diretamente
    public static MétodosEVariáveisEstáticas estaticos;

    // Variável pública de vida do personagem
    public int life = 5;

    //Chamado uma vez ao início do script/jogo
    void Start()
    {
        // Definimos que esta instância da classe será referenciada pela variável estática
        estaticos = this;
    }

    // Chamado a cada frame do jogo
    void Update()
    {
        
    }

    // Método público que exibe a quantidade de vidas do personagem no console
    public void LifePersonagens()
    {
        //Mensagem no console de vidas
        Debug.Log("Tal personagem tem " + life + " vidas");
    }
}




//Explicação do static
//Em C#, a palavra-chave static define que um membro (variável ou método) pertence à classe e não a uma instância específica dela. Isso significa que:

// 1.Não é necessário criar um objeto da classe para acessar membros static.
// 2.O valor de uma variável static é compartilhado entre todas as instâncias da classe.
// 3.Um método static só pode acessar outros membros static da classe. 


//O que acontece nesse código?

// 1 - A classe MétodosEVariáveisEstáticas

// .Possui uma variável estática estaticos que armazena a instância da própria classe.
// .No método Start(), ela define estaticos = this;, ou seja, a própria instância do script é atribuída à variável estática.
// .Isso permite que qualquer outro script acesse essa instância usando MétodosEVariáveisEstáticas.estaticos.

// 2 -A classe ChamadaEstaticos

// .No método Start(), chama MétodosEVariáveisEstáticas.estaticos.LifePersonagens();, o que acessa a instância armazenada e executa LifePersonagens().
// .Isso exibe no console a quantidade de vidas do personagem.

//Por que usar static nesse caso?
// .Permite que a classe ChamadaEstaticos acesse MétodosEVariáveisEstáticas sem precisar criar um objeto explicitamente.
// .Facilita a comunicação entre scripts, evitando a necessidade de procurar e armazenar referências manualmente.

