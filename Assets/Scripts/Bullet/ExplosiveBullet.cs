using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveBullet : Bullet {
    public float Radius;


	public virtual void Explode()
    {
        //Radius 내의 적들에게 효과미치는 구문
    }
    public override void Active()
    {
        Explode();
        base.Active(); //destroying, basically.
    }
}
