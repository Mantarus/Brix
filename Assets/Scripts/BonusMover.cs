using UnityEngine;

public class BonusMover : MonoBehaviour
{
    public float initialVelocity;
    public float rotationSpeed;
    
    private Rigidbody _rb;

    private void OnTriggerExit(Collider other)
    {
        if (LayerMask.NameToLayer("Level") == other.gameObject.layer)
        {
            gameObject.SetActive(false);
        }
    }

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.velocity = Vector3.down * initialVelocity;
        _rb.angularVelocity = new Vector3(0, rotationSpeed, 0);
    }
}
