using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigos : MonoBehaviour
{
    public GameObject laserInimigo;
    public Transform canhaoDeDisparoInimigo;
    public float cronometroDeDisparo;
    public float enemyVelocidade;
    

    
    
    public float tempoAtualDosLasers;
    public bool inimigoAtirador;
    public bool inimigoAtivo;

    // Start is called before the first frame update
    void Start()
    {
        inimigoAtivo = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimentarEnemy();
        if (inimigoAtirador == true && inimigoAtivo == true)
        {
            AtirarLaser();
        }
    }

    public void AtivarInimigo()
    {
        inimigoAtivo = true;
    }

    private void MovimentarEnemy()
    {
        transform.Translate(Vector3.down * enemyVelocidade * Time.deltaTime);
    }

    private void AtirarLaser()
    {
        tempoAtualDosLasers -= Time.deltaTime;

        if (tempoAtualDosLasers <= 0)
        {
            Instantiate(laserInimigo, canhaoDeDisparoInimigo.position, Quaternion.Euler(0f, 0f, 90f));
            tempoAtualDosLasers = cronometroDeDisparo;
        }
    }
}

