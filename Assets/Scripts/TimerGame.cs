using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TimerGame : MonoBehaviour
{
    float StartTime = 0;
    public TMP_Text timertext;
    // Start is called before the first frame update
    void Start()
    {
        StartTime = Time.time;
        
    }

    // Update is called once per frame
    void Update()
    {
       
       

        TimeSpan t = TimeSpan.FromSeconds(30 - (Time.time - StartTime));

        Debug.Log(t.Minutes.ToString ("00") + ":" + t.Seconds.ToString ("00") + " secondes");

        timertext.text = t.Minutes.ToString("00") + ":" + t.Seconds.ToString("00") + "" + " secondes";

        TimeOut(t.TotalSeconds);



    }
    void TimeOut(double t)
    {
        if (t <= 0)
        {
            
            Debug.Log("Terminé");

            timertext.text = " Time Out";
            
        }
        else
        {
            Debug.Log("Plus vite !");
        }
    }
}
