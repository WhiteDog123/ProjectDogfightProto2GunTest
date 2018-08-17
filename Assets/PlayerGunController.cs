using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGunController : GunController {
    // Update is called once per frame
    protected void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            PullTrigger();
        }
        if(Input.GetButtonDown("Fire2"))
        {
            StartCoroutine("Reload");
        }
    }
}
