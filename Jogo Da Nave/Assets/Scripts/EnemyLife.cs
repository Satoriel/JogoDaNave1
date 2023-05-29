using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    public int vidaMaxInimigo;
    public int vidaAtualInimigo;
    public int pontoParaDar;
    public int chanceParaDroppar;

    public GameObject itemDroppavel;
    

    // Start is called before the first frame update
    void Start()
    {
        vidaAtualInimigo = vidaMaxInimigo;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void MachucarInimigo(int danoNoInimigo)
    {
        vidaAtualInimigo -= danoNoInimigo;

        if (vidaAtualInimigo <= 0)
        {
            GameManager.instance.AumentarPontuacao(pontoParaDar);

            int numeroAleatorio = Random.Range(0, 100);

            if(numeroAleatorio <= chanceParaDroppar)
            {
                Instantiate(itemDroppavel, transform.position, Quaternion.Euler(0f, 0f, 0f));
            }

            Destroy(this.gameObject);
        }
    }
}
