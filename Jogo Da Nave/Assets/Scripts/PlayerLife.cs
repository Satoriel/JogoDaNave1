using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    public Slider barraDeVidaDoJogador;

    public int vidaMaximaPlayer;
    public int vidaAtualPlayer;

    public bool escudoPlayer;

    // Start is called before the first frame update
    void Start()
    {
        vidaAtualPlayer = vidaMaximaPlayer;
        barraDeVidaDoJogador.maxValue = vidaMaximaPlayer;
        barraDeVidaDoJogador.value = vidaAtualPlayer;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DanoaoPlayer(int danoParaReceber)
    {
        if(escudoPlayer == false)
        {
            vidaAtualPlayer -= danoParaReceber;
            barraDeVidaDoJogador.value = vidaAtualPlayer;
        }

        if(vidaAtualPlayer <= 0)
        {
            Debug.Log("Game Over");
        }
    }
}
