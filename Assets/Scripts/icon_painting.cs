using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icon_painting : MonoBehaviour
{
    camswitcher Camswitcher;
 

    void Start() 
    {
       
        Camswitcher = FindObjectOfType<camswitcher>();
    }


    void OnMouseDown() 
    {
        
        Camswitcher.switchToCam2();
    }

}
