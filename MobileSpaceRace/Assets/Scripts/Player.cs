using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, Iinteract, Idamage
{
    //cambiar air y ground y probar a hacerlos estados para ver si asi funciona con los obstaculos que spawnean (no hizo falta)

    public float moveSpeed = 5f; 
    private Rigidbody2D rb;
    private Vector2 movement;
    public bool air = false;
    public bool ground = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Capturar entrada del jugador (WASD)
        movement.x = Input.GetAxisRaw("Horizontal"); 
        movement.y = Input.GetAxisRaw("Vertical");   

        
        movement = movement.normalized;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            air = true;
            StartCoroutine(NormalHeigh(0.01f));
            print("Volando");
            ground = false;
        }
        if(Input.GetKeyDown(KeyCode.O))
        {
            ground = true;
            StartCoroutine(NormalHeigh(0.01f));
            print("Al piso");
            air = false;
        }
       
    }

    void FixedUpdate()
    {
        rb.velocity = movement * moveSpeed;
    }

    IEnumerator NormalHeigh(float up)
    {
        yield return new WaitForSeconds(4f);
        air = false;
        ground = false;
        print("Aterrice");
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
