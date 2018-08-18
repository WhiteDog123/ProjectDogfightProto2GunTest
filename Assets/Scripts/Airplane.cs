using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airplane : MonoBehaviour, IDamageable
{ 
    private Health _health;
    [Header("Speed")]
    public float forwardSpeed;
    public float rotateSpeed;

    protected void Awake()
    {
        _health = GetComponent<Health>();
        _health.healthEvent = EventByCurrentHealth;
    }

    public void TakeDamage(float amount)
    {
        _health.CurrentHelath -= amount;
    }

    protected void EventByCurrentHealth()
    {
        if (_health.CurrentHelath <= 0)
        {
            Destroy(gameObject);
        }
    }
    public virtual void Rotate(float axis)
    {
        transform.Rotate(axis * rotateSpeed * Time.deltaTime, 0, 0, Space.Self);
    }
    public virtual void KeepGoingForward()
    {
        transform.position = transform.position + transform.forward * forwardSpeed * Time.deltaTime;
    }
}
