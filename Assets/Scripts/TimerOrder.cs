using System;
using UnityEngine;
using TMPro;

public class TimerOrder : MonoBehaviour
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
<<<<<<< Updated upstream
        TimeSpan t = TimeSpan.FromSeconds(10 - (Time.time - StartTime));
=======
        TimeSpan t = TimeSpan.FromSeconds(21 - (Time.time - StartTime));
>>>>>>> Stashed changes

        if (Input.GetKeyDown(KeyCode.Return) && (t.TotalSeconds > 0))  // KeyCode.Return corresponds to the "Enter" key
        {
            // Restart the timer if the Enter key is pressed
            StartTime = Time.time;
            Debug.Log("Timer restarted!");
        }

        

        

        if (t.TotalSeconds >= 0)
        {

            timertext.text = t.Minutes.ToString("00") + ":" + t.Seconds.ToString("00") + "" + " secondes";
        }
    }
}

