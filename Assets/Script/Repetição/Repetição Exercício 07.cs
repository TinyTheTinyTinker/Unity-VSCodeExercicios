using UnityEngine;

public class RepetiçãoExercício07 : MonoBehaviour
{
    int[] numeros = { 2, 3, 5, 7, 8, 10, 45, 27, 50, 60 };
    int maior = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (var item in numeros)
        {
            if (item > maior)
            {
                maior = item;
            }
        }

        print("O maior número da lista é: " + maior);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
