using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {
    [SerializeField]
    private Group group;
    //컨트롤하는 Gun들은 모두 같은 종류, 같은 탄창을 가지고 있다.
    public List<Gun> gunsToControl = new List<Gun>();
    public float reloadTime;

    protected virtual void Awake()
    {
        group = gameObject.GetComponent<Group>();
        for (int i = 0; i < gunsToControl.Count; i++)
        {
            gunsToControl[i].group = group;
        }
    }

    protected virtual IEnumerator PullTrigger()
    {
        for(int i = 0; i<gunsToControl.Count; i++)
        {
            gunsToControl[i].StartCoroutine("OnPullTrigger");
        }
        yield return null;
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

    public void AddNewGunToControl(Gun newGun)
    {
        newGun.group = this.group;
        gunsToControl.Add(newGun);
    }
}
