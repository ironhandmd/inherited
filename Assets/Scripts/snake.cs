using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snake : MonoBehaviour
{
    [SerializeField]Animator anim;
    scene_manager SceneManager;
    [SerializeField]
    GameObject drsnake;
    panel_controller PC;
    icon_controller IC;
    [SerializeField]
    GameObject iconSnake;
    Globe globe;
    private int tauntSnake;


    void Start()
    {
        tauntSnake = 0;
        globe = FindObjectOfType<Globe>();
      //  iconSnake.SetActive(false);
        PC = FindObjectOfType<panel_controller>();
        drsnake.SetActive(true);
        SceneManager = FindObjectOfType<scene_manager>();
    }
    public void snakeAwake()
    {
       
        StartCoroutine(wakeTheSnake());

    }

    IEnumerator wakeTheSnake()
    {
        anim.SetBool("snakeIsWake", true);
       yield return new WaitForSeconds(1.5f);
       
        SceneManager.LoadSnake();
    }

    public void feedSnake()
    {
        globe.enableGlobe();
        Destroy(iconSnake);
        drsnake.SetActive(false);
    }
   


   
    void OnTriggerEnter2D()
    {
        iconSnake.SetActive(true);
    }

    void OnTriggerExit2D()
    {
        iconSnake.SetActive(false);

    }

    public void tauntDocSnake() 
    {
        tauntSnake++;
        if (tauntSnake == 2) 
        {
            snakeAwake();
        }
    }

}
