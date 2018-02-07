using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionHandler : MonoBehaviour {

    public GameObject scoreIndicator;

    void Explode()
    {
        Instantiate(scoreIndicator, this.transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
