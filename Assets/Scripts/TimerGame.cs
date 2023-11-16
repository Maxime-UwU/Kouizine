using System;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // Ajout de l'espace de noms pour g�rer les sc�nes

public class TimerGame : MonoBehaviour
{
    float StartTime = 0;
    public TMP_Text timertext;

    // Ajout d'une r�f�rence � l'�cran de fin (assurez-vous d'assigner un objet Canvas � cette variable dans l'�diteur Unity)
    public GameObject endScreen;

    // Start is called before the first frame update
    void Start()
    {
        StartTime = Time.time;
        // Assurez-vous que l'�cran de fin est d�sactiv� au d�but du jeu
        if (endScreen != null)
        {
            endScreen.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        TimeSpan t = TimeSpan.FromSeconds(120 - (Time.time - StartTime));


        timertext.text = t.Minutes.ToString("00") + ":" + t.Seconds.ToString("00") + "" + " secondes";

        TimeOut(t.TotalSeconds);
    }

    void TimeOut(double t)
    {
        if (t <= 0)
        {
            timertext.text = " Time Out";

            // Arr�ter le jeu
            StopGame();
        }
        else
        {
        }
    }

    void StopGame()
    {
        // Arr�ter le temps dans le jeu
        Time.timeScale = 0f;

        // Activer l'�cran de fin
        if (endScreen != null)
        {
            endScreen.SetActive(true);
        }
    }

    // Ajouter une m�thode pour red�marrer le jeu (cette m�thode peut �tre appel�e depuis un bouton sur l'�cran de fin, par exemple)
    public void RestartGame()
    {
        Time.timeScale = 1f; // Remettre la vitesse du temps � 1 pour red�marrer le jeu
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Recharger la sc�ne actuelle
    }
}
