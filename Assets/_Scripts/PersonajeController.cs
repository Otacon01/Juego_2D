using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeController : MonoBehaviour
{
    public float VelMovement = 5f; // Velocidad de movimiento del personaje
    public float fuerzaJum = 7f; //Fuerza dle salto dle personaje 

    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
