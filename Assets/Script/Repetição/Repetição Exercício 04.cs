using UnityEngine;

public class RepetiçãoExercício04 : MonoBehaviour
{

    [SerializeField] int combos = 0;
    [SerializeField] int pontos = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        while (combos < 9)
        {
            if (combos < 8)
            {
                combos++;
                pontos = pontos + 10;
            }
            if (combos == 9)
            {
                print("Pontuação Total: " + pontos);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
