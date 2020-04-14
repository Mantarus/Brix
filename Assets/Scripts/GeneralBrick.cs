using UnityEngine;

public class GeneralBrick : MonoBehaviour
{
    public int lives = 1;
    public float bonusSpawnChance;
    public GameObject bonusPrefab;

    public ScoreCounter scoreCounter;
    public BrickCounter brickCounter;
    
    private GameObject _bonus;

    private void Start()
    {
        brickCounter.IncreaseBrickCount();
        SetupBonus();
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            scoreCounter.AddScore();
            scoreCounter.IncreaseMultiplier();
            
            lives--;
            if (lives <= 0)
            {
                DestroyBrick();
            }
        }
    }

    private void SetupBonus()
    {
        if (Random.Range(0, 100) < bonusSpawnChance)
        {
            _bonus = Instantiate(bonusPrefab, transform.position, transform.rotation);
            _bonus.SetActive(false);
        }
    }

    private void DestroyBrick()
    {
        if (_bonus != null) _bonus.SetActive(true);
        brickCounter.DecreaseBrickCount();
        gameObject.SetActive(false);
    }

}
