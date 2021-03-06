﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour {
    public float speed;
    public float range;
    public GameObject Target;
    private Vector2 TargetPos;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.down * speed, Space.World);
        TargetPos = Target.transform.position;

        float dist = Vector2.Distance(TargetPos, transform.position);

        if (dist > range)
        {
            Destroy(gameObject);
        }
    }
}
