using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public bool pEscudo;
    public bool pTiro;
    public bool pVida;

    public int vidaParaDar;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            if(pEscudo == true)
            {
                other.gameObject.GetComponent<PlayerLife>().AtivarEscudoDoPlayer();
                Destroy(this.gameObject);
            }
            if(pTiro == true)
            {
               other.gameObject.GetComponent<PlayerController>().laserDuploVerif = false;

               other.gameObject.GetComponent<PlayerController>().tempoAtualDosLasersDuplos = other.gameObject.GetComponent<PlayerController>().tempoDeLaserDuplo;

                other.gameObject.GetComponent<PlayerController>().laserDuploVerif = true;
                Destroy(this.gameObject);
            }
            if(pVida == true)
            {
                  other.gameObject.GetComponent<PlayerLife>().GanharVida(vidaParaDar);
                Destroy(this.gameObject);
            }
        }
    }
}
