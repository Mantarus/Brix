using UnityEngine;

public class CarriageMover : MonoBehaviour
{
    public float speed;
    public float xLimit;
    
    private void Update()
    {
        Move();
    }

    private void Move()
    {
        var value = Input.GetAxis("Horizontal");
        var pos = transform.position;
        var xMovement = value * speed * Time.deltaTime;
        transform.position = new Vector3(
            Mathf.Clamp(pos.x + xMovement, -xLimit, xLimit), pos.y, pos.z);
    }
}
