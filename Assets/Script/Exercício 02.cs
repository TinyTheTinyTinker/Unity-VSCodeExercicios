using UnityEngine;

public class Exercício02 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    string playerPowerUp = "Tomate";
    void Start()
    {
        if (playerPowerUp != "Nenhum")
        {
            print("Power-Up Coletado");
        }
        else
        {
            print("Nenhum Power-Up Encontrado");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
