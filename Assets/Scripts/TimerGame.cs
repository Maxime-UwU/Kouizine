using System;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // Ajout de l'espace de noms pour gérer les scènes

public class TimerGame : MonoBehaviour
{
    float StartTime = 0;
    public TMP_Text timertext;

    // Ajout d'une référence à l'écran de fin (assurez-vous d'assigner un objet Canvas à cette variable dans l'éditeur Unity)
    public GameObject endScreen;

    // Start is called before the first frame update
    void Start()
    {
        StartTime = Time.time;
        // Assurez-vous que l'écran de fin est désactivé au début du jeu
        if (endScreen != null)
        {
            endScreen.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        TimeSpan t = TimeSpan.FromSeconds(10 - (Time.time - StartTime));


        timertext.text = t.Minutes.ToString("00") + ":" + t.Seconds.ToString("00") + "" + " secondes";

        TimeOut(t.TotalSeconds);
    }

    void TimeOut(double t)
    {
        if (t <= 0)
        {
            //Debug.Log("Terminé");
            timertext.text = " Time Out";

            // Arrêter le jeu
            StopGame();
        }
        else
        {
           // Debug.Log("Plus vite !");
        }
    }

    void StopGame()
    {
        // Arrêter le temps dans le jeu
        Time.timeScale = 0f;

        // Activer l'écran de fin
        if (endScreen != null)
        {
            endScreen.SetActive(true);
        }
        else
        {
            Debug.LogWarning("L'écran de fin n'est pas assigné à la variable 'endScreen'");
        }
    }

    // Ajouter une méthode pour redémarrer le jeu (cette méthode peut être appelée depuis un bouton sur l'écran de fin, par exemple)
    public void RestartGame()
    {
        Time.timeScale = 1f; // Remettre la vitesse du temps à 1 pour redémarrer le jeu
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Recharger la scène actuelle
    }
}
