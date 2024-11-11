using UnityEngine;

public class RepetiçãoExercício03 : MonoBehaviour
{

    [SerializeField] int vezes = 10;
    [SerializeField] int moedas;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        while (vezes >= 0)
        {
            moedas = moedas + 3;
            vezes--;
            if (vezes == 0)
            {
                print("Moedas Coletadas: " + moedas);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
