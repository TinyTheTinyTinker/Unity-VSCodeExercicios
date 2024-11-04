using UnityEngine;

public class Exercício03 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    int vidaTotal = 30;
    int vidaAtual = 0;
    bool powerUpReviver = true;
    void Start()
    {
        if (vidaAtual > 0)
        {
            print("Vivo, vida atual: " + vidaAtual);
        }
        else
        {
            if (powerUpReviver == true)
            {
                print("Ainda não, vida atual: " + vidaAtual);
            }
            else
            {
                print("Morreu kkkkkk");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
