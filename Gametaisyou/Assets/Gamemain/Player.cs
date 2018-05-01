using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーンマネジメントを有効にする

public class Player : MonoBehaviour {

	// Use this for initialization
    void Start()
    {
    }
    public void LButtonDown()
    {
        transform.Translate(-3, 0, 0);
    }
    public void RButtonDown()
    {
        transform.Translate(3, 0, 0);
    }


    // Update is called once per frame
    void Update()
    {
	//　aキーを押している間ずっとコンソールに表示
        if(Input.GetKey("a")) {
            Debug.Log("A-String");
            SceneManager.LoadScene("GameClear");//シーン切替
        }
        if (Input.GetKey("z"))
        {
            Debug.Log("z-String");
            SceneManager.LoadScene("GameOver");//シーン切替
        }
        //左矢印が押されたとき
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-3, 0, 0);//左に「３」動かす
        }
        //右矢印が押されたとき
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(3, 0, 0);//右に「３」動かす
        }

    }

}

