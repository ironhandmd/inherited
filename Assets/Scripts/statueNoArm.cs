using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statueNoArm : MonoBehaviour
{

    [SerializeField]
    SpriteRenderer spriteRenderer;
    [SerializeField]
    Sprite newsprite;
    [SerializeField]
    Sprite newsprite2;
    public int insertedArm;
    icon_controller IC;
    panel_controller PC;
    [SerializeField]
    GameObject secretDoorAppears;
    void Start() 
    {
        secretDoorAppears.SetActive(false);
        PC = FindObjectOfType<panel_controller>();
        IC = FindObjectOfType<icon_controller>();
    }

    void OnTriggerEnter2D() 
    {
        IC.activateIconStatNoArm();
    }

    void OnTriggerExit2D()
    {
        IC.deactivateIconStatNoArm();
    }

    public void addOneArm() 
    {
        spriteRenderer.sprite = newsprite;
    }

    public void addAnotherArm() 
    {
        spriteRenderer.sprite = newsprite2;
    }

    public void addArm() 
    {
        insertedArm++;
        addOneArm();
       if (insertedArm == 2) 
        {
            addAnotherArm();
            PC.activateCompleteStatue();
            secretDoorAppears.SetActive(true);
       }
    
    
    }






}
