using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public bool isUsingDefaultHealth;

    public float maxHealth;
    public float defaultHealth;

    [SerializeField]
    private float _currentHealth = 0.0f;
    public float CurrentHelath
    {
        get
        {
            return _currentHealth;
        }
        set
        {
            _currentHealth = value;
            if (healthEvent != null)
            {
                healthEvent();
            }
        }
    }

    public delegate void EventOccouredBySettingCurrentHealth();
    public EventOccouredBySettingCurrentHealth healthEvent;
    private void Awake()
    {
        if(isUsingDefaultHealth)
            CurrentHelath = defaultHealth;
    }
}
