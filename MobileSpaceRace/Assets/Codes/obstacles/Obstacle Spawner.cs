using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public Transform spawnObst;
    public GameObject[] selected;

 /*   public GameObject goUp;
    public GameObject goDown;
    public GameObject avoid;
    public GameObject ignore; */

    private void Start()
    {
        StartCoroutine(SpawnObstacle());
    }
    IEnumerator SpawnObstacle()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            RandomizerSpawn();
        }
    }
    void RandomizerSpawn()
    {
        int randomIndex = Random.Range(0, selected.Length);

        switch (randomIndex)
        {
            case 0:
                Instantiate(selected[0], spawnObst.position, spawnObst.rotation);
                break;
            case 1:
                Instantiate(selected[1], spawnObst.position, spawnObst.rotation);
                break;
            case 2:
                Instantiate(selected[2], spawnObst.position, spawnObst.rotation);
                break;
            case 3:
                Instantiate(selected[3], spawnObst.position, spawnObst.rotation);
                break;
            default:
                
                break;


        }


    }


    //Instantiate(selected, spawnObst.position, spawnObst.rotation);

}
