using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountDown : MonoBehaviour
{
     float currtime = 0f;
     float strttime = 4f;
    [SerializeField] private TextMeshProUGUI countDown;
    public bool Gocar= false;
    public carspawner carspawner;
    public Text timer;
    private float starttimer;
    public bool OnTimer = false;



    private void Start()
    {

            currtime = strttime;
            starttimer = Time.time;
    }

    public void Update()
    {
        if (carspawner.gotimer == true)
        {
            currtime -= 1 * Time.deltaTime;
            countDown.text = currtime.ToString("0");
            if (currtime <= 0)
            {
                currtime = 0;
                Gocar = true;
                countDown.gameObject.SetActive(false);
                OnTimer = true;
            }

        }
        if (OnTimer == true)
        {

            float t = Time.time - starttimer;
            string minutes = ((int)t / 60).ToString();
            string seconds = (t % 60-4).ToString("0");
            timer.text = "Time:" + minutes + ":" + seconds;
        }
        
    }

    
}
