using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnCanvas : MonoBehaviour
{
    
    [SerializeField] public GameObject canvasToEnable;   // El canvas que quiero prender
    [SerializeField] public GameObject canvasToDisable;
    public void SwitchCanvas()
    {
        if (canvasToEnable != null)
            canvasToEnable.SetActive(true);

        if (canvasToDisable != null)
            canvasToDisable.SetActive(false);
    }
}
