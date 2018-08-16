using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveBullet : Bullet {
    public float Radius;
	public virtual void Explode()
    {
        //이펙트 생성하는 구문
        //Radius 내의 적들에게 효과미치는 구문
        Destroy(gameObject);
    }
}
