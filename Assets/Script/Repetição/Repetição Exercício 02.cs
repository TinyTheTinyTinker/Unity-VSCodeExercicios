using UnityEngine;

public class RepetiçãoExercício02 : MonoBehaviour

    //2. (Multiplicação de dano) Um personagem ataca cinco vezes, e o
    //dano do ataque aumenta em 2 a cada vez.Exiba o dano a cada
    //ataque.

{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] int danoFinal;
    [SerializeField] int danoInicial;
    [SerializeField] int golpes = 1;

    void Start()
    {
        danoFinal = danoInicial;
        while (golpes < 6)
        {
            print("Dano do Golpe " + golpes + ": " + danoFinal);
            golpes++;
            danoFinal = danoFinal * 2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
