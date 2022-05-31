using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key_to_use : MonoBehaviour
{

    private bool isDraggingKey;
    private Vector2 initPos;
    panel_controller PC;


    void Start() 
    {
        PC = FindObjectOfType<panel_controller>();
    }
    public void OnMouseDown()
    {

        initPos = transform.position;
        isDraggingKey = true;

    }

    public void OnMouseUp()
    {
        snapBack();
        isDraggingKey = false;

    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {



        chest Chst = hitInfo.GetComponent<chest>();

        if (Chst != null)
        {

            PC.activatePanelOpenChest();
          //  Snake.feedSnake();
            Destroy(gameObject);


        }


    }






    void Update()
    {
        if (isDraggingKey)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);

        }


    }

    private void snapBack()
    {
        transform.position = initPos;
    }














}
