using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManorWarpExit3 : MonoBehaviour
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
        CM.moveToAreaManor4();
        other.gameObject.transform.position = warpTarget.transform.position;
    }
}
