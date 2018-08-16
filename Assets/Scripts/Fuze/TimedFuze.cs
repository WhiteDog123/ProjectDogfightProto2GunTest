using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedFuze : Fuze {
    public ExplosiveBullet bullet;
    public float time;

    void Start()
    {
        StartCoroutine("Ignite");
    }
    public override IEnumerator Ignite()
    {
        yield return new WaitForSeconds(time);
        bullet.Explode();
    }
}
