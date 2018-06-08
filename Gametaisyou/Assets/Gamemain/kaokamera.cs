using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kaokamera : MonoBehaviour {
    public GameObject kurumaPlefab;
    GameObject player2;
	// Use this for initialization
	void Start () {
        this.player2 = GameObject.Find("hasiru&zyannpu_15");
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 playerPos = this.player2.transform.position;
        transform.position = new Vector3(
            playerPos.x -1, playerPos.y+4, transform.position.z);
	}
}
