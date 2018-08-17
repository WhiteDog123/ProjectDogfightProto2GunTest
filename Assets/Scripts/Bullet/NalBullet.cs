using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NalBullet : Bullet {
    public override void Active()
    {
        IDamageable inf = collideTarget.GetComponent<IDamageable>();
        if (inf != null)
        {
            inf.TakeDamage(damage);
        }
        base.Active();
    }
}
