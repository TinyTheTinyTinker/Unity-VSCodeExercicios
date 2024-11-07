using Unity.VisualScripting;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class Exercício05 : MonoBehaviour

    //(Pontuação de missão) Após completar uma missão, o jogador
    //recebe pontos.Verifique se ele ganhou mais de 50 pontos.Se sim,
    //exiba "Missão bem-sucedida"; caso contrário, "Missão
    //incompleta".
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
