using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーンマネジメントを有効にする

public class GameClearflg : MonoBehaviour {
    static public bool Clearflg = false;
	// Use this for initialization
	void Start () {
        Clearflg = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("クーリア");
            Clearflg = true;
        }
    }
}
