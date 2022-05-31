using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbtarget : MonoBehaviour
{
    scene_manager SceneManager;
    // Start is called before the first frame update
    void Start()
    {
        SceneManager = FindObjectOfType<scene_manager>();
    }

    public void orbHit() 
    {
        StartCoroutine(orbWasHit());
    
    }

    IEnumerator orbWasHit() 
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadEnding1();
    }

}
