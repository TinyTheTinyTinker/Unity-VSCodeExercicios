using UnityEngine;

public class Exercício04 : MonoBehaviour
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
