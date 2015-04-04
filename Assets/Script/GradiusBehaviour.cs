﻿using UnityEngine;
using System.Collections;

public class GradiusBehaviour : Default {
    public float speed;
    public float hp;
    public string stats;
    public GameObject Bullet;
	// Use this for initialization
	void Awake () {
        
	}
	
	// Update is called once per frame
	void Update () {
        rigidbody.velocity = Vector4.zero;
        if ((Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) && transform.position.z < 60) 
        {
            transform.position += new Vector3(0, 0, speed * Time.deltaTime);
            transform.Rotate(0, 0, 1f);
        }

        if ((Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) && transform.position.z > 52)
        {
            transform.position += new Vector3(0, 0, -speed * Time.deltaTime);
            transform.Rotate(0, 0, -1f);
        }

        if ((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) && transform.position.x > 49)
        {
            transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }

        if ((Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) && transform.position.x < 72)
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Bullet, transform.position + new Vector3(1.5f, 0, 0), Quaternion.identity);
        }

        if(hp <= 0)
        {
            Destroy(gameObject);
        }

	}
}
