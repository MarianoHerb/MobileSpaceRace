using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPlayer : MonoBehaviour
{
    public Transform spawnPla;
    public GameObject Player;

    void Start()
    {
        Instantiate(Player, spawnPla.position, spawnPla.rotation);
    }

    
}
