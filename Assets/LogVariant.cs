﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogVariant : MonoBehaviour
{
    private float speed = 3;
    private float despawnTimer = 20f;

    private void Start()
    {
        Destroy(gameObject, despawnTimer);
    }

    // Update is called once per frame
    private void Update()
    {
        //Moves object backward along the z axis
        transform.Translate((Vector3.forward*-1) * speed * Time.deltaTime);

    }
}
