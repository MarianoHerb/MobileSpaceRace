using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawner : MonoBehaviour
{
    public Transform spawnF;
    public GameObject flor;

    private void Start()
    {
        StartCoroutine(SpawnFloor());
    }
    IEnumerator SpawnFloor()
    {
        while (true)
        {
            yield return new WaitForSeconds (1.5f);
            Instantiate(flor, spawnF.position, spawnF.rotation);
        }
    }

}
