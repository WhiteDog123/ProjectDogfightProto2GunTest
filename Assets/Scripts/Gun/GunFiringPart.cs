﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFiringPart : MonoBehaviour {
    public Transform muzzle;
    public GUN_FIRE_ORDER_RESULT Fire(GameObject ammoToSpawn, Group groupOfController)
    {
        var bullet =
              Instantiate(ammoToSpawn,
              muzzle.position,
              muzzle.rotation);
        bullet.GetComponent<AmmoEffect>().group = groupOfController;
        bullet.GetComponent<AmmoPropellant>().Propel(muzzle.forward);

        return GUN_FIRE_ORDER_RESULT.SPAWN_AMMO_SUCCESS;
    }
}
