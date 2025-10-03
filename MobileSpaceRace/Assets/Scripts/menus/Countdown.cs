using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Countdown : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI countdownText; // Texto UI donde se mostrará la cuenta
    [SerializeField] private float countdownTime = 3f; // Tiempo inicial

    private void Start()
    {
        StartCoroutine(StartCountdown());
    }

    IEnumerator StartCountdown()
    {
        float time = countdownTime;

        while (time > 0)
        {
            countdownText.text = Mathf.Ceil(time).ToString(); // Muestra 3, 2, 1
            yield return new WaitForSeconds(1f);
            time--;
        }

        countdownText.text = "GO!"; // Mensaje final
        yield return new WaitForSeconds(1f);

        countdownText.gameObject.SetActive(false); // Oculta el texto después
    }
}
