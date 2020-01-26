using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    [SerializeField] float changePositionFactor = 3f;
    [SerializeField] Extinguisher extinguisher;

    private Slider slider;

    private void Awake()
    {
        slider = GetComponent<Slider>();
    }

    public void ValueChanged()
    {
        extinguisher.ChangePositionY(-slider.value * changePositionFactor);
    }
}