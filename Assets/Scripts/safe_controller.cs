using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class safe_controller : MonoBehaviour
{
    // public static bool isSafeOpened = false;
    [SerializeField]
    GameObject codePanel, closedSafe;



    public void activatePanelSafe()
    {

        codePanel.SetActive(true);
        closedSafe.SetActive(true);

    }

    // void Update() 
    // {
    //  if (isSafeOpened) 

    //{
    public void openTheSafe()
    {

        codePanel.SetActive(false);
        closedSafe.SetActive(false);



    }
    
}
