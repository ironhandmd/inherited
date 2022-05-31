using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleclue : MonoBehaviour
{
    [SerializeField]
    GameObject icon;
    player_movement PM;
    void Start()
    {
        PM = FindObjectOfType<player_movement>();
        icon.SetActive(false);
    }

    void OnTriggerEnter2D()
    {

        icon.SetActive(true);
    }

    void OnTriggerExit2D()
    {

        icon.SetActive(false);
    }
   
}
