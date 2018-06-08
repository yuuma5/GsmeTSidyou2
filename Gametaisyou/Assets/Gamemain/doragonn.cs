using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doragonn : MonoBehaviour {
    Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        transform.Rotate(new Vector3(0.0f, 0.0f, 0.0f));
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        var v = new Vector2(0.6f, rb.velocity.x);
        transform.Translate(v);
	}
}
