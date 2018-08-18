using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunChamberPart : MonoBehaviour {
    [Header("Connected Barrels")]
    public List<GunFiringPart> connectedBarrels = new List<GunFiringPart>();

    [Header("Chamber")]
    public bool isUnlimited = false;
    public bool isLoadedOnStart = true;
    public int maxLoadedAmmoAmount;
    public int currentLoadedAmmoAmount;
    public GameObject ammoToLoad;

    [Header("Chamber Performance")]
    public float delayOfFire;

    private bool isCanFire = true;


    protected void Awake()
    {
        if (isLoadedOnStart)
            currentLoadedAmmoAmount = maxLoadedAmmoAmount;
    }

    public IEnumerator FireSequence(Group groupOfController)
    {
        if (isCanFire)
        {
            MakeConnectedBarrelsToFire(groupOfController);
            isCanFire = false;
            yield return new WaitForSeconds(delayOfFire);
            isCanFire = true;
        }
        else
        {
            yield return null;
        }
    }
    public void Reload()
    {
        currentLoadedAmmoAmount = maxLoadedAmmoAmount;
    }

    private GUN_FIRE_ORDER_RESULT MakeConnectedBarrelsToFire(Group groupOfController)
    {
        for (int i = 0; i < connectedBarrels.Count; i++)
        {
            if (currentLoadedAmmoAmount > 0 || isUnlimited)
            {
                connectedBarrels[i].Fire(ammoToLoad, groupOfController);
                if (isUnlimited)
                {
                    continue;
                }
                else if (!isUnlimited)
                {
                    currentLoadedAmmoAmount--;
                    continue;
                }
            }
            else
            {
                return GUN_FIRE_ORDER_RESULT.NO_AMMO;
            }
        }
        return GUN_FIRE_ORDER_RESULT.ALL_AMMO_LOAD_SUCCESS;
    }
}
