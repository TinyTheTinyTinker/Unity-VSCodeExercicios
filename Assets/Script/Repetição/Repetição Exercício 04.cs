using UnityEngine;

public class RepetiçãoExercício04 : MonoBehaviour
{

    
    [SerializeField] int pontos = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //for ( inicializa ; condições ; incremento ou decremento) 
        for (int combos = 1; combos <= 7; combos++)
        {
            pontos = pontos + 10;
        }

        print(pontos);
        
        //for (pontos = 0; combos < 7; pontos = pontos + 10)
        //{

        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
