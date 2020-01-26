using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class Thermometer : MonoBehaviour
{
    [SerializeField] Text text;

    List<Zone> zones = new List<Zone>();


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Zone zone = collision.gameObject.GetComponent<Zone>();

        if (zone)
        {
            zones.Add(zone);
            UpdateTemperature();
        }
    }

    private void UpdateTemperature()
    {
        float result = zones.Sum(z => z.Temperature);
        text.text = result.ToString();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Zone zone = collision.gameObject.GetComponent<Zone>();

        if (zone)
        {
            zones.Remove(zone);
            UpdateTemperature();
        }
    }
}