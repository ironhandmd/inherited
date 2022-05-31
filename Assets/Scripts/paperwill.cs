using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paperwill : MonoBehaviour
{
    [SerializeField]
    GameObject will;
    icon_controller IC;
    inventory Inventory;
    public GameObject itemButton;
    player_movement PM;
    panel_controller PC;

    void Start()
    {
        PM = FindObjectOfType<player_movement>();
        PC = FindObjectOfType<panel_controller>();
        will.SetActive(true);
        IC = FindObjectOfType<icon_controller>();
        Inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<inventory>();
    }


    void OnTriggerEnter2D() 
    {
        IC.activateIconWil();
    }

    void OnTriggerExit2D()
    {
        IC.deactivateIconWil();
    }

    public void removeWill() 
    {
        will.SetActive(false);
    }


    public void getWill()
    {
        for (int i = 0; i < Inventory.slots.Length; i++)
        {
            if (Inventory.isFull[i] == false)
            {
                Inventory.isFull[i] = true;
                Instantiate(itemButton, Inventory.slots[i].transform, false);
                Destroy(gameObject);
                break;

            }
        }
        PM.nowMove();
        PC.deactivatePanelPprWill();
        removeWill();
    }
}
