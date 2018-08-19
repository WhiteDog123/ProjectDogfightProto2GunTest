using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoTrigger_CollisionWithEnemyGroup : AmmoTrigger {
    protected virtual void OnCollisionEnter(Collision collision)
    {
        Group otherGroup = collision.gameObject.GetComponent<Group>();
        if (otherGroup == null)
        {
            return;
        }
        else
        {
            if (ammoEffect.group.Relationship[(int)ammoEffect.group.Kind, (int)otherGroup.Kind] == -1)
            {
                ammoEffect.Effect(collision.gameObject);
            }
        }
    }
}
