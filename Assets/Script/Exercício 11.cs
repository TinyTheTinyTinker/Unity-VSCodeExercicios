using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;
using UnityEngine.Rendering.VirtualTexturing;

public class Exercício11 : MonoBehaviour

    //11. (Diálogos) Implemente um sistema de diálogos onde o jogador
    //pode interagir com um NPC (personagem não jogável), e o NPC
    //responde com diferentes frases dependendo do estado do jogo.
    //Use switch case para definir as respostas baseadas no estado do
    //jogador.

{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] string estado;

    void Start()
    {
        switch (estado)
        {
            case "Olá":
                print("Olá");
                break;

            case "Tenho Dinheiro":
                print("Perdeu Irmao passa tudo passa tudo!");
                break;

            case "Me Ajuda":
                print("Não");
                break;

            default:
                print("Slá mano kkkkkk");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
