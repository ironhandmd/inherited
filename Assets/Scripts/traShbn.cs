using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class traShbn : MonoBehaviour
{
    icon_controller IC;
   
    void Start()
    {
        IC = FindObjectOfType<icon_controller>();
    }

    void OnTriggerEnter2D() 
    {
        IC.activateIconTrsh();
    }
    void OnTriggerExit2D()
    {
        IC.deactivateIconTrsh();
    }

}
