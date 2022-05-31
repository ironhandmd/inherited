using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icon_Codex : MonoBehaviour
{


    [SerializeField]
    GameObject codexPanel;
    panel_controller PC;
    void Start() 
    {
        PC = FindObjectOfType<panel_controller>();
        codexPanel.SetActive(false);
    }

    void OnMouseDown() 
    {
        codexPanel.SetActive(true);
    }

    public void closeCodex() 
    {
        PC.activatePanelCdx();
        codexPanel.SetActive(false);
    }
}
