using UnityEngine;
using System.Threading.Tasks;

public class RepetiçãoExercício01 : MonoBehaviour

    // (Contagem regressiva de tempo) Crie uma contagem
    // regressiva de 5 a 1 e exiba "Início da partida!" ao final.

{

    [SerializeField] int contagem = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        while (contagem > 0)
        {

            contagem--;

            if (contagem <= 1)
            {
                print("Início da Partida!");

            }
        }

    }

    // Update is called once per frame
    void Update()
    {
    }
}
