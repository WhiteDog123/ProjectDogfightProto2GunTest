using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airplane : MonoBehaviour, IDamageable {
    [SerializeField]
    float _health = 100f;
    public float Health
    {
        set
        {   
            _health = value;
            if (_health <= 0)
                Destroy(gameObject);
        }
        get
        {
            return _health;
        }
    }

    public void TakeDamage(float amount)
    {
        Health -= amount;
    }
}
