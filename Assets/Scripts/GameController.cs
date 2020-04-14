using UnityEngine;

public class GameController : MonoBehaviour
{

    public BrickCounter brickCounter;
    public UIController uiController;
    public ScoreCounter scoreCounter;

    public int lives = 3;

    private int _livesLeft;

    private void Start()
    {
        _livesLeft = lives;
        uiController.UpdateLives(_livesLeft);
    }

    public void UpdateAfterLose()
    {
        _livesLeft--;
        uiController.UpdateLives(_livesLeft);
        scoreCounter.ResetMultiplier();
        if (_livesLeft <= 0)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        Time.timeScale = 0;
    }

}
