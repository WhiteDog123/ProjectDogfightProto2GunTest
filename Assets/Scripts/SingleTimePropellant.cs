using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleTimePropellant : Propellant {
    public float force;
    public override void Propel()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(muzzle.forward * force);
    }
}
