using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iconpaper : MonoBehaviour
{

    cluepanelmanager CPM;

    void Start()
    {
        CPM = FindObjectOfType<cluepanelmanager>();
       
    }

    void OnMouseDown() 
    {
        CPM.activateCluePanel2();
    }
}
