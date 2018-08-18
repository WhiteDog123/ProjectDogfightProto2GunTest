using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAirplaneController : AirplaneController {
	protected void Update () {
        airplane.Rotate(Input.GetAxis("Vertical"));
        airplane.KeepGoingForward();
    }
}
