using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    public int vidaMaxInimigo;
    public int vidaAtualInimigo;
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
            Destroy(this.gameObject);
        }
    }
}
