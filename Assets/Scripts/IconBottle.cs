﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconBottle : MonoBehaviour
{

    panel_controller PC;
    void Start()
    {
        PC = FindObjectOfType<panel_controller>();
    }

    void OnMouseDown()
    {
        PC.activatePanelBottle();
    }




}
