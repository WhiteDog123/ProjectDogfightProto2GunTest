using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoEffect : MonoBehaviour {
    [HideInInspector]
    public Group group;
    public float lifeTime;

    protected void Start()
    {
        Destroy(gameObject, lifeTime);
    }
    public virtual void Effect(GameObject effectCauser)
    {
        Destroy(gameObject);
    }
}