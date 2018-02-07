using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombUnlitClickHandler : MonoBehaviour {

    public GameObject bombLit;

    void OnMouseDown() // Requires a collider to work
    {
        Instantiate(bombLit, this.transform.position, this.transform.rotation);
        Destroy(this.gameObject);
    }
}
