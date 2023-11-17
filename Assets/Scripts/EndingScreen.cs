using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class EndingScreen : MonoBehaviour
{
    public TMP_Text scoreText;

    public Score scoreScript;


    // Start is called before the first frame update
    void Start()
    {
        // Appeler la m�thode GetScore() du script Score pour r�cup�rer le score
        int currentScore = scoreScript.GetScore();
        // Faites quelque chose avec la valeur du score, par exemple, l'afficher

        scoreText.text = "Score: " + currentScore;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}

