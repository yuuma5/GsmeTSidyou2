﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーンマネジメントを有効にする

public class GameClear : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("a"))
        {
            Debug.Log("A-String");
            SceneManager.LoadScene("GameTitle");//シーン切替
        }
	}
}
