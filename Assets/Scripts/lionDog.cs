using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lionDog : MonoBehaviour
{
    [SerializeField]
    GameObject LDG;
    icon_controller IC;
    public GameObject itemButton;
    inventory Inventory;
    player_movement PM;
    panel_controller PC;
    void Start()
     
    {
        PM = FindObjectOfType<player_movement>();
        LDG.SetActive(true);
        PC = FindObjectOfType<panel_controller>();
        IC = FindObjectOfType<icon_controller>();
        Inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<inventory>();
    }


    void OnTriggerEnter2D() 
    {
        IC.activateIconLD();
    }
    void OnTriggerExit2D()
    {
        IC.deactivateIconLD();
    }

    public void removeLionDog() 
    {
        LDG.SetActive(false);
    }
    public void getPaperWt()
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
        PC.deactivatePwt();
        removeLionDog();
    }
}
