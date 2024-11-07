using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;
using static Unity.Burst.Intrinsics.X86;

public class Exercício01 : MonoBehaviour

    // (Verificação de pontos de vida) Um personagem perde pontos
    // de vida após uma batalha.Verifique se ele ainda está vivo.Caso
    // tenha mais de 0 pontos de vida, exiba "Personagem Vivo", caso
    // contrário, "Game Over".
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    int vidaPersonagem = 2;
    
    void Start()
    {
        if (vidaPersonagem > 0)
        {
            print("Personagem Vivo");
        }
        else
        {
            print("Game Over");
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
