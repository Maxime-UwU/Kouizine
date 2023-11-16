using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private int score = 0;
    public TMP_Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        // Exemple : Augmenter le score si la condition est remplie
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            IncreaseScore(10);
        }

        // Exemple : Diminuer le score si la condition est remplie
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            DecreaseScore(5);
        }
    }
    public int GetScore()
    {
        return score;
    }

    void IncreaseScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    void DecreaseScore(int amount)
    {
        score -= amount;
        // Assurez-vous que le score ne devient pas négatif
        score = Mathf.Max(0, score);
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        // Mettez à jour le texte d'affichage du score
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }
}

