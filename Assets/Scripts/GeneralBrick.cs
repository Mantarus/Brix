using UnityEngine;

public class GeneralBrick : MonoBehaviour
{
    public int lives = 1;
    public GameObject gameControllerObject;

    private GameController _gameController;

    private void Start()
    {
        _gameController = gameControllerObject.GetComponent<GameController>();
    }

    private void OnCollisionExit(Collision other)
    {
        if (LayerMask.LayerToName(other.gameObject.layer) == "Ball")
        {
            lives--;
            if (lives <= 0)
            {
                DestroyBrick();
            }
        }
    }

    private void DestroyBrick()
    {
        _gameController.UpdateScore();
        Destroy(gameObject);
    }

}
