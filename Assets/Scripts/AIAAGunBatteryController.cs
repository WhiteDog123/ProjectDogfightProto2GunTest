using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIAAGunBatteryController : AIGunController {
    public GunPlatform gunPlatform;
    public GameObject target;

    protected void Update()
    {
        TowardsToTarget();
    }
    public virtual void TowardsToTarget()
    {
        if (target != null)
        {
            Vector3 targetDir = target.transform.position - gunPlatform.rotatePivot.transform.position;

            float step = gunPlatform.rotateSpeed * Time.deltaTime;

            Vector3 newDir = Vector3.RotateTowards(gunPlatform.rotatePivot.transform.forward, targetDir, step, 0.0f);

            gunPlatform.rotatePivot.transform.rotation = Quaternion.LookRotation(newDir);
        }
        return;
    }
}
