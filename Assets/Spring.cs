using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour {

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            rb.velocity = transform.up * 10;
        }
    }
}
