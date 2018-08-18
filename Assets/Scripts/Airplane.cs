using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airplane : MonoBehaviour, IDamageable
{ 
    private Health _health;

    void Awake()
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
}
