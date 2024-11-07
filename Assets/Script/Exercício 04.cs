using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class Exercício04 : MonoBehaviour

    //(Verificar item de inventário) Um jogador possui itens limitados
    //no inventário.Verifique se o jogador possui uma "Poção de Vida".
    //Se possuir, exiba "Usando Poção de Vida"; caso contrário, "Poção
    //indisponível".
{
    string inventarioJogador1 = "Nada";
    string inventarioJogador2 = "Poção de Vida";
    void Start()
    {
        if (inventarioJogador1 == "Poção de Vida" || inventarioJogador2 == "Poção de Vida")
        {
            print("Usando Poção de Vida");
        }
        else
        {
            print("Poção Indisponível");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
