using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botann : MonoBehaviour
{

    // 長押しフレーム数
    private int presskeyFrames = 0;
    // 長押し判定の閾値（フレーム数）
    private int thresholdLong = 20;
    // 軽く押した判定の閾値（フレーム数）
    private int thresholdShort = 1;

    void Update()
    {
        presskeyFrames += (Input.GetKey("a")) ? 1 : 0;
        if (Input.GetKeyUp("a")) presskeyFrames = 0;

        if (thresholdLong <= presskeyFrames)
        {
            Debug.Log("長押し");
        }
        else if (thresholdShort <= presskeyFrames)
        {
            Debug.Log("軽く押した");
        }
    }
}
