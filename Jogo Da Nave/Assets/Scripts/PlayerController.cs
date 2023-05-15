using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D oRigidbody2D;
    public GameObject laserPlayer;
    public Transform canhaoDisparoUnico;

    public float velocidadeNave;

    public bool laserDuploVerif;

    private Vector2 teclas;

    // Start is called before the first frame update
    void Start()
    {
       laserDuploVerif = false; 
    }

    // Update is called once per frame
    void Update()
    {
        movimentoPlayer();
        AtirarLaser();
    }

    private void movimentoPlayer()
    {
        teclas = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        oRigidbody2D.velocity = teclas.normalized * velocidadeNave;
    }

    private void AtirarLaser()
    {
      if(Input.GetButtonDown("Fire1"))
      {
        if(laserDuploVerif == false)
        {
          Instantiate(laserPlayer, canhaoDisparoUnico.position, canhaoDisparoUnico.rotation);
        }
      }
    }
}
