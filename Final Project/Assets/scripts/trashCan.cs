﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trashCan : MonoBehaviour
{
    
    public trashCan can;
    public float strength = 2000;


    void OnTriggerStay(Collider other)
    {

        if (other.tag == "ball") {
            Vector3 positionOfTrash = gameObject.transform.position;
            Vector3 positionOfBall = other.transform.position;
            Vector3 dir = positionOfTrash - positionOfBall;
            float mag = dir.magnitude;
            dir = dir.normalized;
            dir = dir * strength * (1 / (mag));
            //print(mag);

            other.GetComponent<Rigidbody>().AddForce(dir, ForceMode.Force);
        }
         
    }
    void Start()
    {

    }
    void Update()
    {

    }
}
