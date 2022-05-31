using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iconLionDogPW : MonoBehaviour
{
    panel_controller PC;
    void Start()
    {
        PC = FindObjectOfType<panel_controller>();
    }


    void OnMouseDown() 
    {
        PC.activatePwt();
    }


}
