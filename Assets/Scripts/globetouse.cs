using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globetouse : MonoBehaviour
{
    private bool isDraggingGlobe;
    private Vector2 initPos;

    public void OnMouseDown()
    {

        initPos = transform.position;
        isDraggingGlobe = true;

    }

    public void OnMouseUp()
    {
        snapBack();
        isDraggingGlobe = false;

    }

    //  private void OnTriggerEnter2D(Collider2D other)  // rigidbody 2d as static, collider 2d as trigger
    // chest rigidbody 2d as kinematic collider 2d as trigger
    // {

    //    if (other.gameObject == crystal)
    //   {
    //       Destroy(other.gameObject);
    //       Destroy(gameObject);
    //   }
    //  }





    void Update()
    {
        if (isDraggingGlobe)
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
