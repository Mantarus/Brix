using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarriageMover : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    private void Update()
    {
        Move();
    }

    private void Move()
    {
        var value = Input.GetAxis("Horizontal");
        transform.position += new Vector3(value * speed * Time.deltaTime, 0, 0);
    }
}
