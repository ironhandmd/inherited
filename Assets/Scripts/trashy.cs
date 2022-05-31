using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trashy : MonoBehaviour
{
    icon_controller IC;
    inventory Inventory;
    public GameObject itemButton;
    panel_controller PC;
    player_movement PM;
    [SerializeField]
    Collider2D col;
    void Start()
        
    {
        PC = FindObjectOfType<panel_controller>();
        IC = FindObjectOfType<icon_controller>();
        PM = FindObjectOfType<player_movement>();
        Inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<inventory>();
    }

    void OnTriggerEnter2D() 
    {
        IC.activateIconTrsh();
    }
    void OnTriggerExit2D()
    {
        IC.deactivateIconTrsh();
    }

    public void getMatches()
    {
        for (int i = 0; i < Inventory.slots.Length; i++)
        {
            if (Inventory.isFull[i] == false)
            {
                Inventory.isFull[i] = true;
                Instantiate(itemButton, Inventory.slots[i].transform, false);
        //        Destroy(gameObject);
                break;

            }
        }
        PM.nowMove();
        PC.activatePanelTrash2();
        disableCollider();
    }

    private void disableCollider() 
    {
        var col = GetComponent<Collider2D>().enabled = false;
    }

}
