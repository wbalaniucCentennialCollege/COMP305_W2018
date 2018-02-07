using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombLitCountdown : MonoBehaviour {
    public GameObject explosion;

	// Use this for initialization
	void Start () {
        Invoke("Explode", 3);
	}
	
	void Explode()
    {
        // Create explosion at this point
        // Debug.Log("BOOOM!!!!");
        Instantiate(explosion, this.transform.position, this.transform.rotation);
        Destroy(this.gameObject);
    }
}
