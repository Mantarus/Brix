using UnityEngine;

public class BrickCounter : MonoBehaviour
{
    public GameController gameController;
    public UIController uiController;
    
    private int _brickCount;

    public int GetBrickCount()
    {
        return _brickCount;
    }
    
    public void IncreaseBrickCount()
    {
        _brickCount++;
        uiController.UpdateBricksLeft(_brickCount);
    }

    public void DecreaseBrickCount()
    {
        _brickCount--;
        uiController.UpdateBricksLeft(_brickCount);

        if (_brickCount <= 0)
        {
            gameController.GameOver();
        }
    }

}
