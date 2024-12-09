using System;
using UnityEngine;

public class River : MonoBehaviour
{
    [SerializeField] float _pushForce;
    
    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.TryGetComponent<Rigidbody>(out Rigidbody rb))
        {
            var newVel = rb.velocity;
            newVel.x = _pushForce;
            rb.velocity = newVel;
        }
    }
}
