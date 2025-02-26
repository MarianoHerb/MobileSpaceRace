using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoOver : generalObstacles
{
    public Player player;

    private void Start()
    {
        player = FindObjectOfType<Player>(); 
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Iinteract damage = other.GetComponent<Iinteract>();
        if (damage != null)
        {
            if(player.air == true)
            {
                print("no pasa nada");
            }
            else
            {
                print("chocaste");
            }
        }
    }

}
