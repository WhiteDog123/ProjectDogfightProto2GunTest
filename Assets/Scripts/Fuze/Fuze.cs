using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuze : MonoBehaviour {
    public virtual IEnumerator Ignite() { yield return null; }
}
