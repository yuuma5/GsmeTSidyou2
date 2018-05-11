using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    GameObject player;

    // Use this for initialization
    void Start()
    {
        this.player = GameObject.Find("hasiru&zyannpu_15");

    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 playerPos = this.player.transform.position;
        transform.position = new Vector3(
            playerPos.x+7, playerPos.y, transform.position.z);

    }
}