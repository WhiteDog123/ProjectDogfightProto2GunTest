using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {
    private Group group;
    protected bool isCanFire = true;

    public GunMasterPart gunToControl;

    [Header("Controller Performance")]
    public float reloadTime;

    protected virtual void Awake()
    {
        group = gameObject.GetComponent<Group>();
    }

    protected virtual void PullTrigger()
    {
        gunToControl.StartFireSequence(group);
    }

    protected virtual IEnumerator Reload()
    {
        isCanFire = false;

        yield return new WaitForSeconds(reloadTime);

        gunToControl.StartReloadSequence();

        isCanFire = true;

        yield return null;
    }
}
