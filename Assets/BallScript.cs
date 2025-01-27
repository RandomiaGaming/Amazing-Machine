using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {
    public static bool playing = false;
    private Rigidbody2D rb;
    private Vector3 start;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        start = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            playing = !playing;
        }
        if (!playing)
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
            transform.position = start;
            transform.rotation = Quaternion.identity;
        }
        else
        {
            rb.constraints = RigidbodyConstraints2D.FreezePosition;
        }
	}
    private void OnBecameInvisible()
    {
        //playing = false;
    }
}
