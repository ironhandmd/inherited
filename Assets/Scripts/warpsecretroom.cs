using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warpsecretroom : MonoBehaviour
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
        CM.moveToSecretRoom();
        other.gameObject.transform.position = warpTarget.transform.position;
    }

}
