using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GUN_FIRE_ORDER_RESULT
{
    SPAWN_AMMO_SUCCESS,
    ALL_AMMO_LOAD_SUCCESS,
    NO_AMMO,
}
public class GunMasterPart : MonoBehaviour
{
    [Header("ConnectedCambers")]
    public List<GunChamberPart> connectedChambers;

    public Transform sight;

    public virtual void StartFireSequence(Group groupOfController)
    {
        for (int i = 0; i < connectedChambers.Count; i++)
        {
            connectedChambers[i].StartCoroutine("FireSequence", groupOfController);
        }
    }

    public virtual void StartReloadSequence()
    {
        for (int i = 0; i < connectedChambers.Count; i++)
        {
            connectedChambers[i].Reload();
        }
    }
}
