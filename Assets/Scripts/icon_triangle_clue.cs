using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icon_triangle_clue : MonoBehaviour
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
        CPM.activateCluePanel3();
    }
}
