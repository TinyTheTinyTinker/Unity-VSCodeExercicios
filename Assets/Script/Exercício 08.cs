using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System;
using Unity.Collections;
using UnityEditor;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;
using static UnityEngine.EventSystems.EventTrigger;
public class Exercício08 : MonoBehaviour

    //(Contador de horas e dias) Crie um script que em que uma
    // variável inteira hora seja incrementada de uma unidade a cada 10
    // segundos e volte a ser 0 quando alcançar o valor 24. Quando
    // completar um ciclo, incremente uma variável dias e escreva o
    // número de dias que se passaram no console. (Coloque o código
    // dentro da função-evento Update).
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] int horas;
    [SerializeField] int dias;
    [SerializeField] float segundos;
    float segundo;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        segundo += Time.deltaTime;
        if(segundo >= 10f)
        {
            segundo = 0;
            horas ++;
            if (horas >= 24)
            {
                horas = 0;
                dias += 1;
            }
        }
    }
}
