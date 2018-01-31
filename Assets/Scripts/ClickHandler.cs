using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHandler : MonoBehaviour {
    /*
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    // Input
	void Update () {
		
	}

    // Guarenteed to run at a specific interval
    // Physics (i.e. things that are time dependent)
    void FixedUpdate()
    {

    }
    */

    public GameObject captainFalcon;
    public Sprite firstImage;
    public Sprite secondImage;

    private Rigidbody2D rBody;
    private SpriteRenderer sRend;
    
    void Start()
    {
        // Initialization of component references
        rBody = captainFalcon.GetComponent<Rigidbody2D>();
        sRend = captainFalcon.GetComponent<SpriteRenderer>();

        rBody.velocity = new Vector2(5, 0);
    }
    // Executes when a mouse down event occurs on an object with this script.
    void OnMouseDown()
    {
        if(sRend.sprite == firstImage)
        {
            sRend.sprite = secondImage;
        } else
        {
            sRend.sprite = firstImage;
        }

        rBody.velocity *= -1;
    }
}
