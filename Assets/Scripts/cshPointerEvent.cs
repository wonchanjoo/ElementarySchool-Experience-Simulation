﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Collider))]

public class cshPointerEvent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void SetGazedAt(bool gazedAt)
    {
        if(gazedAt)
        {
           
        }
        else
        {
            Debug.Log("OUT");
        }
    }
}
