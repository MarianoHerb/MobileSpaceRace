using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveDown : MonoBehaviour
{
    public float speed = 3;



    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        StartCoroutine(Die());
    }

    IEnumerator Die ()
    {
        yield return new WaitForSeconds(6f);
        Destroy(gameObject);
    }
}
