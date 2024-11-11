using UnityEngine;

public class RepetiçãoExercício05 : MonoBehaviour
{
    [SerializeField] int fases = 0;
    [SerializeField] int dificuldade;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        while (fases <= 7)
        {
            dificuldade = dificuldade + 5;
            fases++;
            if (fases == 7)
            {
                print("Dificuldade: " + dificuldade);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
