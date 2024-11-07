using UnityEngine;

public class Exercício07 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    int numeroMaxDado = 7;
    void Start()
    {
        int resultado = Random.Range(1, numeroMaxDado);
        print(resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
