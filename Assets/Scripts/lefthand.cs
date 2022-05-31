using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lefthand : MonoBehaviour
{
    private bool isDraggingLeftHand;
    private Vector2 initPos;
    
   

    public void OnMouseDown()
    {

        initPos = transform.position;
        isDraggingLeftHand = true;

    }

    public void OnMouseUp()
    {
        snapBack();
        isDraggingLeftHand = false;

    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {



        statueNoArm SNR = hitInfo.GetComponent<statueNoArm>();

        if (SNR != null)
        {

          
            Destroy(gameObject);
            SNR.addArm();
        
        }


    }


    void Update()
    {
        if (isDraggingLeftHand)
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
