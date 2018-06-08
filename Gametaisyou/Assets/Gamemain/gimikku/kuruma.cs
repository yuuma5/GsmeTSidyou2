using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーンマネジメントを有効にする


public class kuruma : MonoBehaviour {
    static public bool kietaflg = false;
    static public bool sineflg = false;
    Rigidbody2D rb;
    public GameObject kurumaPlefab;
	// Use this for initialization
	void Start () {
        transform.Rotate(new Vector3(0.0f, 0.0f, 90.0f));
        kietaflg = false;
        rb = GetComponent<Rigidbody2D>();
        sineflg = false;
	}
	// Update is called once per frame
	void Update () {
        var v = new Vector2(0.1f, rb.velocity.x);
        transform.Translate(v);
        if(sineflg == true){
            SceneManager.LoadScene("GameOver");
        }
	}
    
 void OnBecameInvisible()
 {
     kietaflg = true;
   Destroy(this.gameObject);
   Debug.Log("（ブロックを）づぐりだぁい！！");
 }
 void OnTriggerStay2D(Collider2D other)
 {
     if (other.tag == "Player")
     {
         Debug.Log("殺した");
         sineflg = true;
     }
 }
}
