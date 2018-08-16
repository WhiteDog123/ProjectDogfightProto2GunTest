using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour, IComparable<Group> {
   // public float damage;
    public float lifeTime;
    public Group group;

    protected void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    public int CompareTo(Group other)
    {
        int hostile = group.Relationship[(int)group.Kind, (int)other.Kind];
        return hostile;
    }
}