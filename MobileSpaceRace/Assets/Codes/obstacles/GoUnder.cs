using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoUnder : generalObstacles
{
    public Player player;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Iinteract damage = other.GetComponent<Iinteract>();
        if (damage != null)
        {
            if (player.ground == false)
            {
                print("Chocaste");
            }
            else
            {
                print("No pasa nada");
            }
        }
    }
}
