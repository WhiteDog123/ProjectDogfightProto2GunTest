using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public float lifeTime;
    public Group group;
    public float damage;
    protected GameObject collideTarget;

    protected void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    protected virtual void OnCollisionEnter(Collision collision)
    {
        Group otherGroup = collision.gameObject.GetComponent<Group>();
        if (otherGroup == null)
        {
            return;
        }
        else
        {
            //적대 관계이라면
            if (CompareTo(otherGroup) == -1)
            {
                collideTarget = collision.gameObject;
                Active();
            }
        }
    }

    public virtual int CompareTo(Group other)
    {
        int hostile = group.Relationship[(int)group.Kind, (int)other.Kind];
        return hostile;
    }

    /*
     * Active안에 Destroy 있음! 
     */
    public virtual void Active()
    {
        Destroy(gameObject);
    }
}