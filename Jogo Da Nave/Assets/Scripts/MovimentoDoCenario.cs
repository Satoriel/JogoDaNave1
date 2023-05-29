using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoDoCenario : MonoBehaviour
{
    public float velocidadeDoCenario;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimentarCeanrio();
        
    }
    private void MovimentarCeanrio()
    {
        Vector2 movimentoDoCenario = new Vector2(Time.time * velocidadeDoCenario, 0f);
        GetComponent<Renderer>().material.mainTextureOffset = movimentoDoCenario;
    }
}
