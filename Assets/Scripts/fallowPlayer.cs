﻿using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class fallowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
