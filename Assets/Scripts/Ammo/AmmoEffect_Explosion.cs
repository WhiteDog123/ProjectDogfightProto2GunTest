using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoEffect_Explosion : AmmoEffect{
    public float radius;
    public float centerDamage;
    public GameObject explosionEffect;

	public virtual void Explode()
    {
        var particle = Instantiate(explosionEffect,transform.position,transform.rotation);
        Destroy(particle, particle.GetComponent<ParticleSystem>().main.startLifetime.constant);
        //Radius 내의 적들에게 효과미치는 구문
    }
    public override void Effect(GameObject effectCauser)
    {
        Explode();
        base.Effect(effectCauser);
    }
}
