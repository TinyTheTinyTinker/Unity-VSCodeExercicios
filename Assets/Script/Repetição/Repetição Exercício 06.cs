using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class RepetiçãoExercício06 : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int numero = 0; numero <= 10000; numero++)
        {
            if (numero % 5 == 0 && numero % 3 == 0)
            {
            print("Fizz Buzz");
            }
            else
            {
                if (numero % 5 == 0)
                {
                    print("Fizz");
                }
                if (numero % 3 == 0)
                {
                    print("Buzz");
                }
                if (numero % 5 != 0 && numero % 3 != 0)
                {
                    print(numero);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
