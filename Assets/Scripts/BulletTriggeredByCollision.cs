using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTriggeredByCollision : BulletTriggerType {
    private void OnCollisionEnter(Collision collision)
    {
        Group otherGroup = collision.gameObject.GetComponent<Group>();
        if (otherGroup == null)
        {
            return;
        }
        else
        {
            if (bullet.CompareTo(otherGroup) == -1)
            {
                bullet.Active();
            }
        }
    }
}
