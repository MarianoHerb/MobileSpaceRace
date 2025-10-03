using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faithObstacle : generalObstacles
{
    public Player player;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Iinteract damage = other.GetComponent<Iinteract>();
        if (damage != null)
        {
            if (player.ground == true || player.air == true)
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
