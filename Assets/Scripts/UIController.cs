using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Text scoreText;
    public Text scoreMultiplierText;
    public Text livesText;
    public Text bricksLeftText;

    public void UpdateScore(float score)
    {
        scoreText.text = $"SCORE: {score:0}";
    }

    public void UpdateScoreMultiplier(float scoreMultiplier)
    {
        scoreMultiplierText.text = $"x{scoreMultiplier:0}";
    }

    public void UpdateLives(int lives)
    {
        livesText.text = $"LIVES: {lives}";
    }

    public void UpdateBricksLeft(int bricksLeft)
    {
        bricksLeftText.text = $"LEFT: {bricksLeft}";
    }

}
