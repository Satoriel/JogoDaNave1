using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaser : MonoBehaviour
{
    public float laserVelocidade;

    public int danoDoLaserInimigo;

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
        transform.Translate(Vector3.up * laserVelocidade * Time.deltaTime);
    }

   void OnCollisionEnter2D(Collision2D other)
   {
        if(other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerLife>().DanoaoPlayer(danoDoLaserInimigo);
            Destroy(this.gameObject);
        }
   }

}
