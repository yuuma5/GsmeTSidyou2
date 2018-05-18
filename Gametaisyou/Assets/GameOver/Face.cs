using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Face : MonoBehaviour {
    public Sprite BlueFace;
    public Sprite YellowFace;
    public Sprite RedFace;
    public Sprite BlackFace;
    public int  FaceGauge;
    public float OrgelTime;
    public int Orgel6Time;
    public int OrgelOutTime;
    public int OrgelFlg;
	// Use this for initialization
	void Start () {
        OrgelTime = 0;
        OrgelFlg = 0;
        Orgel6Time = 6;
	}
	
	// Update is called once per frame
	void Update () {
        if(FaceGauge < 0)
        {
            FaceGauge = 0;
        }
        if(FaceGauge > 100)
        {
            FaceGauge = 100;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            FaceGauge += 10;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FaceGauge -= 5;
        }
        if(FaceGauge == 0)
        {
            this.gameObject.GetComponent<Image>().sprite = BlueFace;
        }
        if (70>= FaceGauge&& FaceGauge > 30)
        {
            this.gameObject.GetComponent<Image>().sprite = YellowFace;
        }
        if (100 >FaceGauge && FaceGauge > 70)
        {
            this.gameObject.GetComponent<Image>().sprite = RedFace;
        }
        if (FaceGauge == 100)
        {
            this.gameObject.GetComponent<Image>().sprite = BlackFace;
        }
        Debug.Log(FaceGauge);
        if (Input.GetKeyDown(KeyCode.S) && OrgelFlg == 0 )
        {
            OrgelFlg = 1;

        }
        if(OrgelFlg == 1)
        {
            OrgelTime += Time.deltaTime;
            if (OrgelTime >= Orgel6Time )
            {
                FaceGauge -= 2;
                Debug.Log("入った！");
                OrgelOutTime += 6;
                OrgelTime = 0.0f;
            }
            if (OrgelOutTime >= 30)
            {
                OrgelOutTime = 0;
                OrgelFlg = 0;
            }

        }
 
      //  Debug.Log(OrgelFlg);
	}
}
