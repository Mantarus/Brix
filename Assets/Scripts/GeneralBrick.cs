using UnityEngine;

public class GeneralBrick : MonoBehaviour
{
    public int lives = 1;
    public float bonusSpawnChance;
    public GameObject bonusPrefab;
    public GameObject gameControllerObject;

    private GameController _gameController;
    private GameObject _bonus;

    private void Start()
    {
        _gameController = gameControllerObject.GetComponent<GameController>();
        _gameController.IncreaseBrickCount();
        if (Random.Range(0, 100) < bonusSpawnChance)
        {
            SpawnBonus();
            _bonus.SetActive(false);
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (LayerMask.LayerToName(other.gameObject.layer) == "Ball")
        {
            _gameController.UpdateScore();
            _gameController.IncreaseScoreMultiplier();
            
            lives--;
            if (lives <= 0)
            {
                _gameController.DecreaseBrickCount();
                if (_bonus != null)
                {
                    _bonus.SetActive(true);
                }
                DestroyBrick();
            }
        }
    }

    private void SpawnBonus()
    {
        _bonus = Instantiate(bonusPrefab, transform.position, transform.rotation);
    }

    private void DestroyBrick()
    {
        gameObject.SetActive(false);
    }

}
