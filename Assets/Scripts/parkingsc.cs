using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parkingsc : MonoBehaviour
{
    public CountDown countDown;
        public GameObject endgamemenu;
    public Highscore highscore;
    public void OnTriggerEnter(Collider other)
    {
        highscore.Stopscore = true;

        if (other.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0f;
            endgamemenu.SetActive(true);
            countDown.OnTimer = false;
        }
    }

   
}
