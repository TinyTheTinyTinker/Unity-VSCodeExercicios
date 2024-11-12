using System;
using System.Linq;
using UnityEngine;

public class RepetiçãoExercício08 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] string palavra;
    string invertida = "";

    void Start()
    {
        for (int tamanhopalavra = palavra.Length -1; tamanhopalavra >= 0; tamanhopalavra--)
        {
            invertida += palavra[tamanhopalavra];
        }
        print("String Invertida: " + invertida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
