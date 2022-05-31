﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manor_back_exit3 : MonoBehaviour
{
    [SerializeField]
    Transform warpTarget;
    camera_movement CM;

    void Start()
    {
        CM = FindObjectOfType<camera_movement>();
    }




    void OnTriggerEnter2D(Collider2D other)
    {
        CM.moveToAreaManor3();
        other.gameObject.transform.position = warpTarget.transform.position;
    }






}
