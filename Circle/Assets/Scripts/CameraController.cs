﻿using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerTransform;
    void Update()
    {
        transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, -10);
    }
}
