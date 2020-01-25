using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed = 10f;


    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 offset = new Vector3(horizontal, vertical, 0).normalized * speed * Time.deltaTime;
        transform.position += offset ;
    }
}