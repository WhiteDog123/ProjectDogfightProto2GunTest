using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGunController : GunController {
    protected void Update()
    {
        if (isCanFire && Input.GetButton("Fire1"))
        {
            PullTrigger();
        }
        if(Input.GetButtonDown("Fire2"))
        {
            StartCoroutine("Reload");
        }
    }
}
