using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndingScreen : MonoBehaviour
{
    public TMP_Text scoreText;

    public Score scoreScript;


    // Start is called before the first frame update
    void Start()
    {
        // Appeler la méthode GetScore() du script Score pour récupérer le score
        int currentScore = scoreScript.GetScore();

        // Faites quelque chose avec la valeur du score, par exemple, l'afficher
        Debug.Log("Le score actuel est : " + currentScore);

        scoreText.text = "Score: " + currentScore;
    }
}

