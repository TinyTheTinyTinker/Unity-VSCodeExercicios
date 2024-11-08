using System;
using Unity.VisualScripting;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class Exercício09 : MonoBehaviour

    //(Placar final) Crie um script que lê o placar de uma partida entre
    //time A e time B.Depois, escreva no console qual dos três
    //resultados possíveis aconteceu: vitória do time A, vitória do time B
    //ou empate. Se o empate teve mais de 3 pontos para cada lado,
    //escreva que foi “um empate emocionante”.
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] int placarTimeA;
    [SerializeField] int placarTimeB;
    void Start()
    {
        placarTimeA = UnityEngine.Random.Range(1, 7);
        placarTimeB = UnityEngine.Random.Range(1, 7);

        if (placarTimeA > placarTimeB)
        {
            print("Vitória Do Time A!");
        }
        else if (placarTimeB > placarTimeA)
        {
            print("Vitória Do Time B!");
        }
        else
        {
            if (placarTimeA > 3 && placarTimeB > 3)
            {
                print("Empate Emocionante!");
            }
            else
            {
                print("Empate!");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
