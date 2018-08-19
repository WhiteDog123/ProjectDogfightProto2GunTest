using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIGunController : GunController
{
    public float fireGunRange;

    /*
     * 시야에 적이 들어오는지 관찰
     * 관찰 방법은 레이케스팅
     */
    public virtual GameObject Observing() // 적이 있는지 관찰
    {
        GameObject observedTarget = null;

        Debug.DrawRay(gunToControl.sight.transform.position, 
            gunToControl.sight.transform.TransformDirection(Vector3.forward)* fireGunRange, 
            Color.red);

        RaycastHit hit;
        if (Physics.Raycast(gunToControl.sight.transform.position,
            gunToControl.sight.transform.TransformDirection(Vector3.forward),
            out hit, fireGunRange))
        {
            observedTarget = hit.transform.gameObject;
        }

        return observedTarget;
    }
    public virtual bool JudgingEnemy(GameObject targetToJudge) // 적이 맞는지, 지금 쏘면 터지겠는지 등을 판단
    {
        Group groupOfHit = targetToJudge.GetComponent<Group>();
        if (groupOfHit == null)
        {
            return false;
        }
        else
        {
            if (group.Relationship[(int)group.Kind, (int)groupOfHit.Kind] <= -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
