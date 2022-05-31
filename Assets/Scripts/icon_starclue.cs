using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icon_starclue : MonoBehaviour
{

    [SerializeField]
    GameObject cluePanel;
    cluepanelmanager CPM;
    player_movement PM;

    void Start()
    {
        PM = FindObjectOfType<player_movement>();
        CPM = FindObjectOfType<cluepanelmanager>();
    }

    void OnMouseDown() 
    {
        PM.dontMove();
        CPM.activateCluePanel1();
    }
}
