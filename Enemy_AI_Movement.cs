using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public float speed = 2.0f;

public class Enemy_AI_Movement
{
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        transform.Translate((direction * moveSpeed) * Time.deltaTime);
    }
}
