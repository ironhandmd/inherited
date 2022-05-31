using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_to_final : MonoBehaviour
{
    scene_manager SceneManager;
    void Start()
    {
        SceneManager = FindObjectOfType<scene_manager>();
    }

    void OnTriggerEnter2D() 
    {
        SceneManager.LoadNextScene();
    }


}
