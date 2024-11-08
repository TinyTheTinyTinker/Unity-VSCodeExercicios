using UnityEngine;
using static UnityEditor.Progress;

public class Exercício10 : MonoBehaviour

    // 10. (Itens do inventário) Crie um script onde o jogador pode coletar
    // diferentes tipos de itens (como moedas, poções, ou power-ups)
    // que têm efeitos diferentes dependendo do tipo coletado.Use um
    // switch case para determinar o efeito de cada tipo de item.

{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] string tipoItem;
    [SerializeField] int moedas = 10;
    [SerializeField] bool escudo = false;
    [SerializeField] bool pacoca = false;
    [SerializeField] bool pocaoVida = false;

    void Start()
    {
        switch (tipoItem)
        {
            case "Moeda":
                moedas++;
                print("Moeda coletada: " + moedas);
                break;

            case "Escudo":
                escudo = true;
                print("Escudo Ativo!");
                break;

            case "Paçoca":
                pacoca = true;
                print("Paçoca Adiquirida!");
                break;

            case "Poção De Vida":
                pocaoVida = true;
                print("Poção de Vida Adiquirida!");
                break;

            default:
                Debug.Log("Item Desconhecido.");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
