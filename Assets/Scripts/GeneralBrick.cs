using UnityEngine;

public class GeneralBrick : MonoBehaviour
{
    public int lives = 1;
    
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
        Destroy(gameObject);
    }

}
