using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    public GameObject ammo;
    public GameObject ammoDisplayBox;

    void OnTriggerEnter(Collider other) {
        ammoDisplayBox.SetActive(true);
        GlobalAmmo.ammoCount += 7;
        ammo.SetActive(false);

        
    }
}
