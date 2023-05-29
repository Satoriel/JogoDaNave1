using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeInimigos : MonoBehaviour
{
    public GameObject[] objetosParaCriar;
    public Transform[] pontosDeCriacao;

    public float tempoMaxDeCriacao;
    public float tempoAtualDeCriacao;
    
    // Start is called before the first frame update
    void Start()
    {
        tempoAtualDeCriacao = tempoMaxDeCriacao;       
    }

    // Update is called once per frame
    void Update()
    {
        tempoAtualDeCriacao -= Time.deltaTime;

        if(tempoAtualDeCriacao <= 0)
        {
            CriarObjeto();
        }
        
    }
    private void CriarObjeto()
    {
        int objetoAleatorio = Random.Range(0, objetosParaCriar.Length);
        int pontoAleatorio = Random.Range(0, pontosDeCriacao.Length);

        Instantiate(objetosParaCriar[objetoAleatorio], pontosDeCriacao[pontoAleatorio].position, Quaternion.Euler(0f, 0f, -90f));
        tempoAtualDeCriacao = tempoMaxDeCriacao;
    }
}
