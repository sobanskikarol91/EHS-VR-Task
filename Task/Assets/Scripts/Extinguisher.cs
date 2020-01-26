using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Extinguisher : MonoBehaviour 
{
    private Vector3 startPosition;

    private void Awake()
    {
        startPosition = transform.position;
    }

    public void ChangePositionY(float posY)
    {
        transform.position = startPosition + new Vector3(0, posY, 0);
    }
}