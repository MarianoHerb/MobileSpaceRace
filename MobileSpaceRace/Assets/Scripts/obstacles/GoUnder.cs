using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoUnder : generalObstacles
{
    public Player player;
    public bool abajo = false;
    private void Start()
    {
        player = FindObjectOfType<Player>(); 
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Iinteract damage = other.GetComponent<Iinteract>();
        if (damage != null)
        {
            if (player.ground == true)
            {
                print("no pasa nada");
            }
            else
            {
                print("chocaste");
                abajo = true;
            }
        }
    }
}
