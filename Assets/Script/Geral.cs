using UnityEngine;

public class Geral : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField]private int vidaJogador = 10;
    //float velocidadeCarro = 125.5f;
    //double velocidade = 120.2;
    //public string nomeJogador = "Tadola";
    //char apelido = 'T';
    //bool vivo = true;


    int variavelGlobal = 20;


    /*
     *  Operadores relacionais
     *  == (igual)
     *  != (diferente)
     *  < (menor que)
     *  > (maior que)
     *  <= (menor ou igual a)
     *  >= (maior ou igual a)
     */

    [SerializeField] int vidaHeroi = 100;
    [SerializeField] int vidaVilao = 300;
    string resultado;

    void Start()
    {
        Debug.Log("Hello World!");

        int variavelLocal = 10;
        string tutorial;

        print(tutorial);

        print(variavelGlobal);
        print(variavelLocal);

        // resultado = vidaHeroi < vidaVilao ? "Vida Heroi Menor" : "Vida Heroi Igual ou Maior";

        //Estrutura condicional
        if (vidaHeroi < vidaVilao)
        {
            resultado = "Vida Heroi Menor";
            print(resultado);
        }
        else if (vidaHeroi == vidaVilao) 
        {
            resultado = "Vida Heroi Igual a Vida Vilao";
            print(resultado);
        }
        else
        {
            resultado = "Vida Heroi Maior";
            print(resultado);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
