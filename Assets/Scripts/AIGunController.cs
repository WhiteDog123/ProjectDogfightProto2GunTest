using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIGunController : GunController {
    /*protected void Start()
    {
        StartCoroutine("PullTrigger");
    }
    protected  override IEnumerator PullTrigger()
    {
        while (gunsToControl[0].currentLoadedAmmoAmount >= 0)
        {
           StartCoroutine(base.PullTrigger());
           yield return new WaitForSeconds(gunsToControl[0].delayOfFire);
        }
        //성능을 위하여, 업데이트에서 계속 부를 필요없이, 딱 그 딜레이 시간 만큼만 쏜다.
    }*/
}
