﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Look : MonoBehaviour
{

    [SerializeField] Transform playerPosition;

    [SerializeField] float smoothVelocity;
    private Vector3 camaraVelocity = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        smoothVelocity = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(playerPosition);
        //Estas líneas de código hacen que la cámara siga al objeyivo (targetPosition) con suavidad (smoothVelocity)
        Vector3 targetPosition = new Vector3(playerPosition.position.x, playerPosition.position.y + 0.5f, transform.position.z);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref camaraVelocity, smoothVelocity);
    }
}
