using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLaser : MonoBehaviour
{
    public float laserVelocidadePlayer;
    
    public int danoParaDar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       MovimentarLaser(); 
    }

    private void MovimentarLaser()
    {
      transform.Translate(Vector3.up * laserVelocidadePlayer * Time.deltaTime);
    }

   void OnCollisionEnter2D(Collision2D other)
   {
        if(other.gameObject.CompareTag("Inimigo"))
        {
           other.gameObject.GetComponent<EnemyLife>().MachucarInimigo(danoParaDar);
           Destroy(this.gameObject);
        }
   }
}

           
