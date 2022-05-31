using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    [SerializeField]
    GameObject Key;
    icon_controller IC;
    inventory Inventory;
    public GameObject itemButton;
    player_movement PM;
    panel_controller PC;

    void Start()
    {
        PM = FindObjectOfType<player_movement>();
        PC = FindObjectOfType<panel_controller>();
        Key.SetActive(true);
        IC = FindObjectOfType<icon_controller>();
        Inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<inventory>();
    }


  

    public void removeKey()
    {
        Key.SetActive(false);
    }


    public void getKey()
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
        PC.deactivatePanelKey();
     removeKey();
    }





}
