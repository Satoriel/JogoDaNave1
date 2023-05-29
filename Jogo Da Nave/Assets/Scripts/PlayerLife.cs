using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    public Slider barraDeVidaDoJogador;
    public Slider barraDeVidaDoEscudo;

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

        barraDeVidaDoEscudo.maxValue = vidaMaximaDoEscudo;
        barraDeVidaDoEscudo.value = vidaAtualEscudo;
        barraDeVidaDoEscudo.gameObject.SetActive(false);

        escudoDoJogador.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AtivarEscudoDoPlayer()
    {
        barraDeVidaDoEscudo.gameObject.SetActive(true);
        vidaAtualEscudo = vidaMaximaDoEscudo;
       escudoDoJogador.SetActive(true);
       escudoPlayer = true;
       barraDeVidaDoEscudo.value = vidaAtualEscudo;
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
            barraDeVidaDoEscudo.value = vidaAtualEscudo;
            
            if(vidaAtualEscudo <= 0)
            {
                escudoDoJogador.SetActive(false);
                escudoPlayer = false;
                barraDeVidaDoEscudo.gameObject.SetActive(false);
            }
        }
        
    }
}
