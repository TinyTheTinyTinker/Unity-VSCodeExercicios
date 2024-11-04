using UnityEngine;

public class Exercício06 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] string personagem = "Guerreiro";
    void Start()
    {
        switch (personagem)
        {
            case "Guerreiro":
                print("Guerreiro Escolhido");
                break;

            case "Mago":
                print("Mago Escolhido");
                break;

            default:
                print("Personagem Não Existe");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
