using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoEffect_SingleTargetDamage : AmmoEffect{
    public float damage = 0f;
    public override void Effect(GameObject effectCauser)
    {
        IDamageable inf = effectCauser.GetComponent<IDamageable>();
        if (inf != null)
        {
            inf.TakeDamage(damage);
        }
        base.Effect(effectCauser);
    }
}
