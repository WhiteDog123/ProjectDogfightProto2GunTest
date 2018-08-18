using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirplaneController : MonoBehaviour {
    protected Airplane airplane;
    protected virtual void Awake()
    {
        airplane =  GetComponent<Airplane>();
    }
}
