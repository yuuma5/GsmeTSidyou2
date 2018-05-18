using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orgel : MonoBehaviour {
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
        if (Input.GetKeyDown(KeyCode.S) && OrgelFlg == 0)
        {
            OrgelFlg = 1;

        }
        if (OrgelFlg == 1)
        {
            OrgelTime += Time.deltaTime;
            if (OrgelTime >= Orgel6Time)
            {
               GameObject.Find("Face").GetComponent<Face>().FaceGauge -= 2;
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

    }
}
