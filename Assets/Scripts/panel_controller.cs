using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panel_controller : MonoBehaviour
{
    [SerializeField]
    GameObject panel_noArm, panel_snake, panel_trash, panel_trash2, panel_Paint, panel_paperwil, panel_LDPaperWt, panel_Bottle, panel_Key, panel_Chest,
    panel_Complete,panel_toyMouse,panel_butter,panel_buttered_mouse,panel_fedSnake,panel_broken,panel_HitSnake,panel_openChest,panel_openedSafe,panel_cdx,panel_lawyertalk,panel_snakeSwallowMan;
    player_movement PlayerMovement;



    void Start()
    {
        PlayerMovement = FindObjectOfType<player_movement>();
        panel_noArm.SetActive(false);
        panel_snake.SetActive(false);
        panel_trash.SetActive(false);
        panel_trash2.SetActive(false);
        panel_Paint.SetActive(false);
        panel_paperwil.SetActive(false);
        panel_LDPaperWt.SetActive(false);
        panel_Bottle.SetActive(false);
        panel_Key.SetActive(false);
        panel_Chest.SetActive(false);
        panel_Complete.SetActive(false);
        panel_toyMouse.SetActive(false);
        panel_butter.SetActive(false);
        panel_buttered_mouse.SetActive(false);
        panel_fedSnake.SetActive(false);
        panel_broken.SetActive(false);
        panel_HitSnake.SetActive(false);
        panel_openChest.SetActive(false);
        panel_openedSafe.SetActive(false);
        panel_cdx.SetActive(false);
        panel_lawyertalk.SetActive(false);
        panel_snakeSwallowMan.SetActive(false);
    }

    public void activateNoArmPanel() 
    {
        PlayerMovement.dontMove();
        panel_noArm.SetActive(true);
    }

    public void deactivateNoArmPanel()
    {
        PlayerMovement.nowMove();
        panel_noArm.SetActive(false);
    }

    public void activatePanelSnake()
    {
        PlayerMovement.dontMove();
        panel_snake.SetActive(true);
    }
    public void deactivatePanelSnake()
    {
        PlayerMovement.nowMove();
        panel_snake.SetActive(false);
    }
    public void activatePanelTrash()
    {
        PlayerMovement.dontMove();
        panel_trash.SetActive(true);
    }
    public void activatePanelTrash2()
    {
        PlayerMovement.dontMove();
        panel_trash.SetActive(false);
        panel_trash2.SetActive(true);
    }

    public void deactivatePanelTrash()
    {
        PlayerMovement.nowMove();
        panel_trash2.SetActive(false);
        panel_trash.SetActive(false);
    }

    public void activatePanelPnt()
    {
        PlayerMovement.dontMove();
        panel_Paint.SetActive(true);
    }
    public void deactivatePanelPnt()
    {
        PlayerMovement.nowMove();
        panel_Paint.SetActive(false);
    }

    public void activatePanelPprWill()
    {
        PlayerMovement.dontMove();
        panel_paperwil.SetActive(true);
    }
    public void deactivatePanelPprWill()
    {
        PlayerMovement.nowMove();
        panel_paperwil.SetActive(false);
    }
    public void activatePwt()
    {
        PlayerMovement.dontMove();
        panel_LDPaperWt.SetActive(true);
    }
    public void deactivatePwt()
    {
        PlayerMovement.nowMove();
        panel_LDPaperWt.SetActive(false);
    }
    public void activatePanelBottle() 
    {
        PlayerMovement.dontMove();
        panel_Bottle.SetActive(true);
    }

    public void deactivatePanelBottle()
    {
        PlayerMovement.nowMove();
        panel_Bottle.SetActive(false);
    }

    public void activatePanelKey()
    {
        PlayerMovement.dontMove();
        panel_Key.SetActive(true);
    }
    public void deactivatePanelKey()
    {
        PlayerMovement.nowMove();
        panel_Key.SetActive(false);
    }
    public void activateChestPanel()
    {
        PlayerMovement.dontMove();
        panel_Chest.SetActive(true);
    }

    public void deactivateChestPanel()
    {
        PlayerMovement.nowMove();
        panel_Chest.SetActive(false);
    }

    public void activateCompleteStatue()
    {
        PlayerMovement.dontMove();
        panel_Complete.SetActive(true);
    }

    public void deactivateCompleteStatue()
    {
        PlayerMovement.nowMove();
        panel_Complete.SetActive(false);
    }

    public void activateToyMousePanel()
    {
        PlayerMovement.dontMove();
        panel_toyMouse.SetActive(true);
    }

    public void deactivateToyMousePanel()
    {
        PlayerMovement.nowMove();
        panel_toyMouse.SetActive(false);
    }

    public void activateButterPanel()
    {
        PlayerMovement.dontMove();
        panel_butter.SetActive(true);
    }

    public void deactivateButterPanel()
    {
        PlayerMovement.nowMove();
        panel_butter.SetActive(false);
    }


    public void activateButteredMouse()
    {
        PlayerMovement.dontMove();
        panel_buttered_mouse.SetActive(true);
    }

    public void deactivateButteredMouse()
    {
        PlayerMovement.nowMove();
        panel_buttered_mouse.SetActive(false);
    }


    public void activatePanelFedSnake()
    {
        PlayerMovement.dontMove();
        panel_fedSnake.SetActive(true);
    }
    public void deactivatePanelFedSnake()
    {
        PlayerMovement.nowMove();
        panel_fedSnake.SetActive(false);
    }

    public void activateBrokenGlobe()
    {
        PlayerMovement.dontMove();
        panel_broken.SetActive(true);
    }
    public void deactivateBrokenGlobe()
    {
        PlayerMovement.nowMove();
        panel_broken.SetActive(false);
    }

    public void activateDontHitSnake()
    {
        PlayerMovement.dontMove();
        panel_HitSnake.SetActive(true);
    }
    public void deactivateDontHitSnake()
    {
        PlayerMovement.nowMove();
        panel_HitSnake.SetActive(false);
    }

    public void activatePanelOpenChest()
    {
        PlayerMovement.dontMove();
        panel_openChest.SetActive(true);
    }
    public void deactivatePanelOpenChest()
    {
        PlayerMovement.nowMove();
        panel_openChest.SetActive(false);
    }


    public void activateOpenedSafe()
    {
        PlayerMovement.dontMove();
        panel_openedSafe.SetActive(true);
    }

    public void deactivateOpenedSafe()
    {
        PlayerMovement.nowMove();
        panel_openedSafe.SetActive(false);
    }

    public void activatePanelCdx()
    {
        PlayerMovement.dontMove();
        panel_cdx.SetActive(true);
    }
    public void deactivatePanelCdx()
    {
        PlayerMovement.nowMove();
        panel_cdx.SetActive(false);
    }


    public void activateLawyerTalk()
    {
        PlayerMovement.dontMove();
        panel_lawyertalk.SetActive(true);
    }
    public void deactivateLawyerTalk()
    {
        PlayerMovement.nowMove();
        panel_lawyertalk.SetActive(false);
    }

    public void activateManSwallowed()
    {
        panel_snakeSwallowMan.SetActive(true);
    }

    public void deactivateManSwallowed()
    {
        panel_snakeSwallowMan.SetActive(false);
    }

     
}




