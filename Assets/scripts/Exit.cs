﻿using System.Collections;
using System.Collections.Generic;
//using System.Runtime.Hosting;
using UnityEngine;

public class Exit : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

    }
}
