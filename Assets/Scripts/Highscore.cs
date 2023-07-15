using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Highscore : MonoBehaviour
{
    [SerializeField] private int time = -4;
    public Text timer;
    public TextMeshProUGUI highscore;
    public bool Stopscore = false;
    public bool gotimer = false;
    void Start()
    {
        if (PlayerPrefs.HasKey("Highscore") == true)
        {
            highscore.text ="Highscore:" + PlayerPrefs.GetInt("Highscore").ToString();
        }
        else
        {
            highscore.text = "No High Scores Yet";
        }
    }
    public void  gobull()
    {
        gotimer = true;
    }

    public void StartTimer()
    {
        if (gotimer == true)
        {
            time = 0;
            InvokeRepeating("IncrimentTime", 1, 1);
        }
        
    }
    private void Update()
    {
        if (Stopscore == true)
        {
            CancelInvoke();
            if (PlayerPrefs.GetInt("Highscore") > time)
            {
                SetHighscore();
            }
        }
    }
    

    public void SetHighscore()
    {
        PlayerPrefs.SetInt("Highscore", time);
        highscore.text = PlayerPrefs.GetInt("Highscore").ToString();

    }

    public void ClearHighscores()
    {
        PlayerPrefs.DeleteKey("Highscore");
        highscore.text = "No High Scores Yet";
    }

    void IncrimentTime()
    {
        time += 1;
        timer.text = "Time: " + time;

    }
}
