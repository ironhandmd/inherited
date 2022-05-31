using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hammer_to_use : MonoBehaviour
{

    private bool isDraggingHammer;
    private Vector2 initPos;

    panel_controller PC;

    void Start() 
    {
        PC = FindObjectOfType<panel_controller>();
    }

    public void OnMouseDown()
    {

        initPos = transform.position;
        isDraggingHammer = true;

    }

    public void OnMouseUp()
    {
        snapBack();
        isDraggingHammer = false;

    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {



        Globe gl = hitInfo.GetComponent<Globe>();

        if (gl != null)
        {

            gl.getGlobe();
           Destroy(gameObject);

           



          

        }

        snake SN = hitInfo.GetComponent<snake>();

        if (SN != null) 
        {
            SN.tauntDocSnake();
            PC.activateDontHitSnake();
        }
    
    
    }


    void Update()
    {
        if (isDraggingHammer)
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
