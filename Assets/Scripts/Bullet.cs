using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public float lifeTime;
    public Group group;
    
    protected void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    public virtual void Active()
    {
        Destroy(gameObject);
    }

    public int CompareTo(Group other)
    {
        int hostile = group.Relationship[(int)group.Kind, (int)other.Kind];
        return hostile;
    }
}