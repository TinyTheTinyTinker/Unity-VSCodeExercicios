using UnityEngine;
using UnityEngine.Video;

public class Exercício01 : MonoBehaviour
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
