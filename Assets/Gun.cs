using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
    public Transform muzzle;

    [Header("Reload")]
    public bool isUnlimited = false;
    public bool isLoadedOnStart = true;
    public int maxLoadedAmmoAmount;
    public int currentLoadedAmmoAmount;

    [Header("Fire")]
    public GameObject bulletToSpawn;
    public float delayOfFire;
    private bool isCanFire = true;

    [SerializeField]
    private Group group;

    protected void Awake()
    {
        group = gameObject.GetComponent<Group>();
        if (isLoadedOnStart)
            currentLoadedAmmoAmount = maxLoadedAmmoAmount;
    }

    protected virtual IEnumerator OnPullTrigger()
    {
        if (isCanFire)
        {
            Fire();
            isCanFire = false;
            yield return new WaitForSeconds(delayOfFire);
            isCanFire = true;
        }
        else
        {
            yield return null;
        }
    }

    public virtual void Fire()
    {
        if (currentLoadedAmmoAmount > 0 || isUnlimited)
        {
            var bullet =
                  Instantiate(bulletToSpawn,
                  muzzle.position,
                  muzzle.rotation);
            bullet.GetComponent<Bullet>().group = this.group;
            bullet.GetComponent<Propellant>().Propel(muzzle.forward);

            if (!isUnlimited)
            {
                currentLoadedAmmoAmount--;
            }
        }
        else
        {
            return;
        }
    }
}
