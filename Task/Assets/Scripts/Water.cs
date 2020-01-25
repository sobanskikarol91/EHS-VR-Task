using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Water : MonoBehaviour
{
    [SerializeField] float power = 2f;
    [SerializeField] float lifeTime = 2f;

    ParticleSystem particles;

    private void Awake()
    {
        particles = GetComponent<ParticleSystem>();
    }

    private void Update()
    {
        lifeTime-= Time.deltaTime;

        if (lifeTime <= 0)
            StopExtinguisher();
    }

    private void StopExtinguisher()
    {
        particles.Stop();
    }

    private void OnParticleCollision(GameObject other)
    {
        FireableObject fireable = other.GetComponent<FireableObject>();

        if (fireable)
            fireable.DecreaseHealth(power);
    }
}