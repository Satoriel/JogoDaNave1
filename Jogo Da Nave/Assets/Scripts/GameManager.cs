using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text textoDoScoreAtual;
    public static GameManager instance;
    public int pontuacaoAtual;

    void Awake()
    {
        instance = this;
        pontuacaoAtual = 0;
        textoDoScoreAtual.text = "SCORE: " + pontuacaoAtual;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AumentarPontuacao(int pontoParaReceber)
    {
      pontuacaoAtual += pontoParaReceber;
      textoDoScoreAtual.text = "SCORE: " + pontuacaoAtual;     
    }
}
