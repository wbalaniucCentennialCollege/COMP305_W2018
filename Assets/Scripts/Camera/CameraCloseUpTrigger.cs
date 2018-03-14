using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCloseUpTrigger : MonoBehaviour {

    public Camera mainCamera;
    public Camera closeUpCamera;

    // Runs on the first frame this object collides with another object
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            mainCamera.enabled = false;
            closeUpCamera.enabled = true;
        }
    }
    // Runs on the last frame this object collides with an object leaving it's area
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            closeUpCamera.enabled = false;
            mainCamera.enabled = true;
        }
    }

    /*
    // Runs on every frame that an object is in the collision area
    void OnTriggerStay2D(Collider2D other)
    {

    }
    */
}
