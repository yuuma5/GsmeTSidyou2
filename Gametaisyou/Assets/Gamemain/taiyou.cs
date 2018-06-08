using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taiyou : MonoBehaviour
{
    Rigidbody2D rigid2D;
    GameObject target3;
    public float speed, ratio;
    // Use this for initialization
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
    }
    void OnStart(GameObject target)
    {
        this.target3 = target;
        StartCoroutine(Throw());
        //cnt++;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("d") && this.rigid2D.velocity.y == 0)
        {
            Debug.Log("koiyo");
            Debug.Log("A-String");
            OnStart(GameObject.Find("New Sprite (1)").gameObject);
        }
    }
    IEnumerator Throw()
    {
        float t = 0f;
        float distance = Vector3.Distance(transform.position, target3.transform.position);

        Vector3 offset = transform.position;
        Vector3 P2 = target3.transform.position - offset;

        //高度設定
        float angle = 45f;
        float base_range = 5f;
        float max_angle = 50f;

        angle = angle * distance / base_range;
        if (angle > max_angle)
        {
            angle = max_angle;
        }
        float P1x = P2.x * ratio;
        //angle * Mathf.Deg2Rad 角度からラジアンへ変換
        float P1y = Mathf.Sin(angle * Mathf.Deg2Rad) * Mathf.Abs(P1x) / Mathf.Cos(angle * Mathf.Deg2Rad);
        Vector3 P1 = new Vector3(P1x, P1y, 0);

        Vector3 look = P1;
        //transform.rotation = Quaternion.FromToRotation(Vector3.up, look);
        float slerp_start_point = ratio * 0.5f;

        while (t <= 1 && target3)
        {
            float Vx = 2 * (1f - t) * t * P1.x + Mathf.Pow(t, 2) * P2.x + offset.x;
            float Vy = 2 * (1f - t) * t * P1.y + Mathf.Pow(t, 2) * P2.y + offset.y;
            transform.position = new Vector3(Vx, Vy, 0);

            if (t > slerp_start_point)
            {
                look = target3.transform.position - transform.position;
                //Quaternion to = Quaternion.FromToRotation(Vector3.up, look);
                //transform.rotation = Quaternion.Slerp(transform.rotation, to, speed * 0.5f * Time.deltaTime);
            }
            t += speed / distance * Time.deltaTime;
            yield return null;
        }
    }

}