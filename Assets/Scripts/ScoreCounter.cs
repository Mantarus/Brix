using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public int maxScoreMultiplier = 5;

    public UIController uiController;

    private int _multiplier = 1;
    private int _score = 0;

    void Start()
    {
        uiController.UpdateScore(_score);
        uiController.UpdateScoreMultiplier(_multiplier);
    }

    public void AddScore()
    {
        _score += _multiplier;
        uiController.UpdateScore(_score);
    }

    public void IncreaseMultiplier()
    {
        if (_multiplier < maxScoreMultiplier) _multiplier++;
        uiController.UpdateScoreMultiplier(_multiplier);
    }

    public void DecreaseMultiplier()
    {
        if (_multiplier > 1 ) _multiplier--;
        uiController.UpdateScoreMultiplier(_multiplier);
    }

    public void ResetMultiplier()
    {
        _multiplier = 1;
        uiController.UpdateScoreMultiplier(_multiplier);
    }
}
