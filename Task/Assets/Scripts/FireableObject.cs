using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class FireableObject : MonoBehaviour
{
    [SerializeField] float maxHealth = 10000;
    [SerializeField] ParticleSystem particles;

    private float startFireLength;
    private float currentHealth;
    private float increaseHealthWithTime = 0.5f;


    private void Awake()
    {
        currentHealth = maxHealth;
        startFireLength = particles.startLifetime;
    }

    private void Update()
    {
        if (particles.isPlaying)
            IncreaseHealth(increaseHealthWithTime);
    }

    public void IncreaseHealth(float amount)
    {
        currentHealth += amount;
        UpdateParticles();
    }

    public void DecreaseHealth(float amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
            particles.Stop();

        UpdateParticles();
    }

    private void UpdateParticles()
    {
        particles.startLifetime = currentHealth / maxHealth * startFireLength;
        Debug.Log(currentHealth + " " + particles.startLifetime);
    }
}