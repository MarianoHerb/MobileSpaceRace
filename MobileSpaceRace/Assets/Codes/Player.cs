using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, Iinteract, Idamage
{
    public float moveSpeed = 5f; // Velocidad del personaje
    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Capturar entrada del jugador (WASD)
        movement.x = Input.GetAxisRaw("Horizontal"); // A (-1) / D (+1)
        movement.y = Input.GetAxisRaw("Vertical");   // W (+1) / S (-1)

        // Normalizar el vector para evitar velocidad diagonal mayor
        movement = movement.normalized;
    }

    void FixedUpdate()
    {
        // Aplicar movimiento usando Rigidbody2D
        rb.velocity = movement * moveSpeed;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        Iinteract interact = other.GetComponent<Iinteract>();
        
        if (interact != null)
        {
            interact.interact();
            
        }
        Idamage damage = other.GetComponent<Idamage>();
        if (damage != null)
        {
            
            damage.damage();
        }

    }
    public void interact()
    {
        Debug.Log("Interacción con el jugador.");
    }

    public void damage()
    {
        Debug.Log("El jugador ha recibido daño.");
    }
}
