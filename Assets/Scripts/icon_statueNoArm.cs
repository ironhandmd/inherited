using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icon_statueNoArm : MonoBehaviour
{
    panel_controller PC;
    

    void Start() 
    {
       
        PC = FindObjectOfType<panel_controller>();
    }
    public void OnMouseDown() 
    {
        PC.activateNoArmPanel();
       
    }





}
