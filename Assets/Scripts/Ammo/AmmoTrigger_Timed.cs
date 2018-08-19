using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoTrigger_Timed : AmmoTrigger {
    public float time;

    void Start()
    {
        StartCoroutine("IgniteAfterTime");
    }
    public IEnumerator IgniteAfterTime()
    {
        yield return new WaitForSeconds(time);
        ammoEffect.Effect(null);
    }
}
