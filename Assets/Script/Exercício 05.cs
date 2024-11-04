using UnityEngine;

public class Exercício05 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    int pontuacaoFinal = 50;
    void Start()
    {
        if (pontuacaoFinal >= 50)
        {
            print("Missão Concluída");
        } else
        {
            print("Missão Incompleta");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
