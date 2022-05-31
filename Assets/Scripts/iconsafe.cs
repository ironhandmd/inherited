using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iconsafe : MonoBehaviour
{
    [SerializeField]
    GameObject SafePanel;
    player_movement PM;




    void Start()
    {
        PM = FindObjectOfType<player_movement>();
        SafePanel.SetActive(false);
    }

    void OnMouseDown() 
    {
        PM.dontMove();
        SafePanel.SetActive(true);
    }

    public void safeOut() 
    {
        PM.nowMove();
        SafePanel.SetActive(false);
    }

}
