using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class Thermometer : MonoBehaviour
{
    [SerializeField] Text text;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Zone zone = collision.gameObject.GetComponent<Zone>();

        if (zone)
            text.text = zone.Temperature.ToString();
    }
}