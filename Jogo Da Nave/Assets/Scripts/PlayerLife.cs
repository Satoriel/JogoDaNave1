using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    public Slider barraDeVidaDoJogador;

    public GameObject escudoDoJogador;

    public int vidaMaximaPlayer;
    public int vidaAtualPlayer;
    public int vidaMaximaDoEscudo;
    public int vidaAtualEscudo;

    public bool escudoPlayer;

    // Start is called before the first frame update
    void Start()
    {
        vidaAtualPlayer = vidaMaximaPlayer;
        barraDeVidaDoJogador.maxValue = vidaMaximaPlayer;
        barraDeVidaDoJogador.value = vidaAtualPlayer;
        vidaAtualEscudo = vidaMaximaDoEscudo;

        escudoDoJogador.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AtivarEscudoDoPlayer()
    {
        vidaAtualEscudo = vidaMaximaDoEscudo;
       escudoDoJogador.SetActive(true);
       escudoPlayer = true;
    }
    public void GanharVida(int vidaParaReceber)
    {
        if(vidaAtualPlayer + vidaParaReceber <= vidaMaximaPlayer)
        {
            vidaAtualPlayer += vidaParaReceber;
        }
        else
        {
            vidaAtualPlayer = vidaMaximaPlayer;
        }

        barraDeVidaDoJogador.value = vidaAtualPlayer;
    }

    public void DanoaoPlayer(int danoParaReceber)
    {
        if(escudoPlayer == false)
        {
            vidaAtualPlayer -= danoParaReceber;
            barraDeVidaDoJogador.value = vidaAtualPlayer;

            
        if(vidaAtualPlayer <= 0)
        {
            Debug.Log("Game Over");
        }
            
        }
        else
        {
            vidaAtualEscudo -= danoParaReceber;
            
            if(vidaAtualEscudo <= 0)
            {
                escudoDoJogador.SetActive(false);
                escudoPlayer = false;
            }
        }
        
    }
}
