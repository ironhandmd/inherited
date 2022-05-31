using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_movement : MonoBehaviour
{

    public Transform target,target2,target3,target4, manor1,manor2,manor3,manor4,manor5,secretRoom,finalRoom;
    public float smoothing;


    public void moveToArea1()
    {
        Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
    }
    public void moveToArea2()
    {
        Vector3 targetPosition = new Vector3(target2.position.x, target2.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
    }
    public void moveToArea3()
    {
        Vector3 targetPosition = new Vector3(target3.position.x, target3.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
    }

    public void moveToArea4()
    {
        Vector3 targetPosition = new Vector3(target4.position.x, target4.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
    }

    public void moveToAreaManor1()
    {
        Vector3 targetPosition = new Vector3(manor1.position.x, manor1.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
    }

    public void moveToAreaManor2()
    {
        Vector3 targetPosition = new Vector3(manor2.position.x, manor2.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
    }

    public void moveToAreaManor3()
    {
        Vector3 targetPosition = new Vector3(manor3.position.x, manor3.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
    }

    public void moveToAreaManor4()
    {
        Vector3 targetPosition = new Vector3(manor4.position.x, manor4.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
    }

    public void moveToAreaManor5()
    {
        Vector3 targetPosition = new Vector3(manor5.position.x, manor5.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
    }
    public void moveToSecretRoom()
    {
        Vector3 targetPosition = new Vector3(secretRoom.position.x, secretRoom.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
    }
    public void moveToFinal()
    {
        Vector3 targetPosition = new Vector3(finalRoom.position.x, finalRoom.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
    }


}
