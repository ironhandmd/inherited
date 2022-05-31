using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icon_controller : MonoBehaviour
{

    [SerializeField] GameObject icon_StatNoArm,iconTrash,icon_painting,icon_pwill,icon_LDog,icon_Bottle,icon_Cdx,
       // icon_toyMouse
       iconButter;

    void Start() 
    {
        icon_StatNoArm.SetActive(false);
        
        iconTrash.SetActive(false);
        icon_painting.SetActive(false);
        icon_pwill.SetActive(false);
        icon_LDog.SetActive(false);
        icon_Bottle.SetActive(false);
       
        icon_Cdx.SetActive(false);
       
      
        iconButter.SetActive(false);
    }

    public void activateIconStatNoArm()
    {
        icon_StatNoArm.SetActive(true);
    }
    public void deactivateIconStatNoArm()
    {
        icon_StatNoArm.SetActive(false);
    }

  

    public void activateIconTrsh() 
    {
        iconTrash.SetActive(true);
    }

    public void deactivateIconTrsh() 
    {
        iconTrash.SetActive(false);
    }

    public void activateIconPainting() 
    {
        icon_painting.SetActive(true);
    }

    public void deactivateIconPainting()
    {
        icon_painting.SetActive(false);
    }

    public void activateIconWil() 
    {
        icon_pwill.SetActive(true);
    }

    public void deactivateIconWil()
    {
        icon_pwill.SetActive(false);
    }

    public void activateIconLD() 
    {
        icon_LDog.SetActive(true);
    }

    public void deactivateIconLD()
    {
        icon_LDog.SetActive(false);
    }
    public void activateIconBottle() 
    {
        icon_Bottle.SetActive(true);
    }
    public void deactivateIconBottle()
    {
        icon_Bottle.SetActive(false);
    }

   

 

 //   public void activateIconToyMouse() 
 //   {
  //      icon_toyMouse.SetActive(true);
 //   }
 //   public void deactivateIconToyMouse()
 //   {
 //       icon_toyMouse.SetActive(false);
 //   }
    public void activateIconButter() 
    
    {
        iconButter.SetActive(true);
    }

    public void deactivateIconButter()
    {
        iconButter.SetActive(false);
    }

    public void activateIconCdx() 
    {
        icon_Cdx.SetActive(true);
    }

    public void deactivateIconCdx()
    {
        icon_Cdx.SetActive(false);
    }
}
