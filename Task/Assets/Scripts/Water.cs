using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Water : MonoBehaviour
{
    [SerializeField] float power = 2f;
    [SerializeField] float lifeTime = 2f;

    private ParticleSystem particles;

    private bool isUsing;
    private Vector3 startPosition;


    private void Awake()
    {
        startPosition = transform.position;
        particles = GetComponent<ParticleSystem>();
    }

    public void Use()
    {
        if (isUsing)
            Stop();
        else
            StartCoroutine(IEUse());
    }


    IEnumerator IEUse()
    {
        isUsing = true;
        particles.Play();

        while (lifeTime > 0)
        {
            lifeTime -= Time.deltaTime;

            yield return null;
        }

        Stop();
    }


    private void Stop()
    {
        isUsing = false;
        particles.Stop();
        StopAllCoroutines();
    }

    private void OnParticleCollision(GameObject other)
    {
        FireableObject fireable = other.GetComponent<FireableObject>();

        if (fireable)
            fireable.DecreaseHealth(power);
    }


}