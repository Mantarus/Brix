﻿using System;
using System.Linq;
using UnityEngine;

public class BallMover : MonoBehaviour
{
    public float initialSpeed;
    public float speedIncrement;
    public float minimalYSpeed = 0.5f;
    
    private Rigidbody _rb;
    private float _speed;
    private Vector3 _initialPosition;
    private Vector3 _initialVelocity;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.velocity = (Vector3.up + Vector3.right).normalized * initialSpeed;
        _speed = initialSpeed;
        
        _initialPosition = transform.position;
        _initialVelocity = _rb.velocity;
    }

    private void OnCollisionExit(Collision other)
    {
        var collisionLayer = LayerMask.LayerToName(other.gameObject.layer);
        string[] allowedLayers = {"Carriage", "Wall", "Brick"};

        if (allowedLayers.Contains(collisionLayer))
        {
            var velocity = _rb.velocity;

            if (Mathf.Abs(velocity.y) <= minimalYSpeed)
            {
                velocity.y = minimalYSpeed * Mathf.Sign(velocity.y);
            }
            
            _speed += speedIncrement;
            _rb.velocity = velocity.normalized * _speed;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (LayerMask.NameToLayer("Level") == other.gameObject.layer)
        {
            _speed = initialSpeed;
            _rb.velocity = _initialVelocity;
            transform.position = _initialPosition;
        }
    }
}
