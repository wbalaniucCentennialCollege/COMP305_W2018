using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowFixedY : MonoBehaviour {

    public Transform playerPosition;
    public float size = 5;

	// Use this for initialization
	void Start () {
        this.GetComponent<Camera>().orthographicSize = size;
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = new Vector3(playerPosition.position.x, this.transform.position.y, this.transform.position.z);
	}
}
