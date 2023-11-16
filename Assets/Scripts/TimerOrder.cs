using System;
using UnityEngine;
using TMPro;

public class TimerOrder : MonoBehaviour
{

    public BurgerModel model;
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
        TimeSpan t = TimeSpan.FromSeconds(11 - (Time.time - StartTime));

        if (Input.GetKeyDown(KeyCode.Return) && (t.TotalSeconds > 0))  // KeyCode.Return corresponds to the "Enter" key
        {
            // Restart the timer if the Enter key is pressed
            StartTime = Time.time;
        }

        
        if (t.TotalSeconds >= 0)
        {
            timertext.text = t.Minutes.ToString("00") + ":" + t.Seconds.ToString("00") + "" + " secondes";

        }


        if (t.TotalSeconds < 1)
        {
            Debug.Log("test");
            model.ResetModel();
            StartTime = Time.time;
        }
    }
}

