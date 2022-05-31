using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cluepanelmanager : MonoBehaviour
{
    [SerializeField]
    GameObject cluePanel1, cluePanel2, cluePanel3,cluePanel4,cluePanel5;
    player_movement PM;

    void Start()
    {
        PM = FindObjectOfType<player_movement>();
        cluePanel1.SetActive(false);
        cluePanel2.SetActive(false);
        cluePanel3.SetActive(false);
        cluePanel4.SetActive(false);
        cluePanel5.SetActive(false);

    }

    public void activateCluePanel1()
    {
        PM.dontMove();
        cluePanel1.SetActive(true);
    }
    public void deactivateCluePanel1()
    {
        PM.nowMove();
        cluePanel1.SetActive(false);
    }

    public void activateCluePanel2()
    {
        PM.dontMove();
        cluePanel2.SetActive(true);
    }

    public void deactivateCluePanel2()
    {
        PM.nowMove();
        cluePanel2.SetActive(false);
    }

    public void activateCluePanel3()
    {
        PM.dontMove();
        cluePanel3.SetActive(true);
    }
    public void deactivateCluePanel3()
    {
        PM.nowMove();
        cluePanel3.SetActive(false);
    }

    public void activateCluePanel4()
    {
        PM.dontMove();
        cluePanel4.SetActive(true);
    }
    public void deactivateCluePanel4()
    {
        PM.nowMove();
        cluePanel4.SetActive(false);
    }
    public void activateCluePanel5()
    {
        PM.dontMove();
        cluePanel5.SetActive(true);
    }
    public void deactivateCluePanel5()
    {
        PM.nowMove();
        cluePanel5.SetActive(false);
    }
}
