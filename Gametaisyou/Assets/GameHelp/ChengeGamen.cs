using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChengeGamen : MonoBehaviour {
    public int flg;
    public Sprite Help1;
    public Sprite Help2;
    public Sprite Help3;
    Image HelpImage;
    GameObject L;
    GameObject R;

	// Use this for initialization
	void Start () {
        flg = 0;
        HelpImage = GetComponent<Image>();
        L = GameObject.Find("LeftArrow").gameObject;
        R = GameObject.Find("RightArrow").gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        if (flg >= 2)
        {
            flg = 2;
        }
        if(flg <= 0)
        {
            flg = 0;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)&& flg  < 2)
        {
            flg += 1;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && flg > 0)
        {
            flg -= 1;
        }

        if(flg == 0)
        {
            HelpImage.sprite = Help1;
            L.SetActive(false);
        }
        if (flg == 1)
        {
            HelpImage.sprite = Help2;
        }
        if(flg == 2)
        {
            HelpImage.sprite = Help3;
        }
        if(flg != 0)
        {
            L.SetActive(true);
        }
        if(flg == 2)
        {
            R.SetActive(false);
        }
        else
        {
            R.SetActive(true);
        }


	}
}
