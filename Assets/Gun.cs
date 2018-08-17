using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
    public GameObject bulletToSpawn;
    public Transform muzzle;

    [SerializeField]
    private Group group;

    void Awake()
    {
        group = gameObject.GetComponent<Group>();
    }
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetButtonDown("Fire1"))
        {
            var bullet =
              Instantiate(bulletToSpawn, 
              muzzle.position,
              muzzle.rotation);
            bullet.GetComponent<Bullet>().group = this.group;
            bullet.GetComponent<Propellant>().Propel();
        }
	}
}
