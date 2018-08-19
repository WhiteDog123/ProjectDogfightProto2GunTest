using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPropellant_SingleTime : AmmoPropellant {
    public float force;
    public override void Propel(Vector3 direction)
    {
        gameObject.GetComponent<Rigidbody>().AddForce(direction * force);
    }
}
