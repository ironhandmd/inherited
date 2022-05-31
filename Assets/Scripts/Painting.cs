using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painting : MonoBehaviour
{
    icon_controller IC;
    void Start()
    {
        IC = FindObjectOfType<icon_controller>();  
    }

    void OnTriggerEnter2D() 
    {
        IC.activateIconPainting();
    }
    void OnTriggerExit2D()
    {
        IC.deactivateIconPainting();
    }

}
