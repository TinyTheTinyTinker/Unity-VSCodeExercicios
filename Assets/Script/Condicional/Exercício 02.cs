using Unity.VisualScripting;
using UnityEngine;

public class Exercício02 : MonoBehaviour

    // (Detecção de power-up) Ao coletar um power-up, o
    // personagem aumenta sua velocidade.Se o jogador encontrar um
    // power-up, exiba "Power-up Coletado". Caso contrário, exiba
    // "Nenhum power-up encontrado".
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
