using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserSondurucu : MonoBehaviour
{
    public GameObject laser;

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            laser.SetActive(false);
        }
    }
}
