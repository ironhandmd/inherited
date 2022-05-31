using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globe : MonoBehaviour
{

    [SerializeField]
    Collider2D col;
    inventory Inventory;
    public GameObject itemButton;
    [SerializeField]
    GameObject gl;
    player_movement PM;
    panel_controller PC;
    void Start()
    {
        PC = FindObjectOfType<panel_controller>();
     //   PM = FindObjectOfType<player_movement>();
        gl.SetActive(true);
        Inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<inventory>();
        var col = GetComponent<Collider2D>().enabled = false;
    }


    public void enableGlobe() 
    {
        var col = GetComponent<Collider2D>().enabled = true;
    }

    public void getGlobe()
    {
        PC.activateBrokenGlobe();
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
       // PM.nowMove();
      
       removeGlobe();
    }

   public  void removeGlobe() 
    {
        gl.SetActive(false);
    }




}
