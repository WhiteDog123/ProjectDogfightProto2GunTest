using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {
    public List<Gun> gunsToControl = new List<Gun>();
    public float reloadTime;

    protected virtual void PullTrigger()
    {
        for(int i = 0; i<gunsToControl.Count; i++)
        {
            gunsToControl[i].StartCoroutine("OnPullTrigger");
        }
    }

    protected virtual IEnumerator Reload()
    {
        yield return new WaitForSeconds(reloadTime);

        for (int i = 0; i < gunsToControl.Count; i++)
        {
            gunsToControl[i].currentLoadedAmmoAmount = gunsToControl[i].maxLoadedAmmoAmount;
        }

        yield return null;
    }
}
