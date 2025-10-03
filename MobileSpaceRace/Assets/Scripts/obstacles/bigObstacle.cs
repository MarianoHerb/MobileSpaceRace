using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigObstacle : generalObstacles
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Iinteract damage = other.GetComponent<Iinteract>();
        if(damage != null)
        {
            print("choque");
        }
    }
}
