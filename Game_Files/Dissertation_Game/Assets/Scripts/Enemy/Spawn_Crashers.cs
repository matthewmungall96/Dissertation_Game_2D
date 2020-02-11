﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Crashers : MonoBehaviour
{
    public GameObject Suicider;
    public float spawnTime;
    public float spawnDelay;
    public bool spawn;
    public bool stopSpawning = false;
    public Animator spawner;
    private int health = 15;
    public Material MatWhite;
    private Material MatDefault;
    SpriteRenderer sr;

    private void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
        sr = GetComponent<SpriteRenderer>();
        MatDefault = sr.material;
        Instantiate(Suicider, transform.position, transform.rotation);
    }

    public void SpawnObject()
    {
        if (stopSpawning == false && spawn_crashers.isAlive == false)
        {
            Instantiate(Suicider,transform.position, transform.rotation);
        }

        else
        {
            return;
        }
    }

    private void Instantiate(Vector3 position)
    {
        throw new NotImplementedException();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Missile"))
        {
            Destroy(collision.gameObject);
            health = health - 3;
            sr.material = MatWhite;
            if (health < 0)
            {
                Debug.Log("Shot Down");
                OnDeath();
            }

            else
            {
                Invoke("ResetMaterial", 0.1f);
            }
        }
    }

    void ResetMaterial()
    {
        sr.material = MatDefault;
    }

    public void OnDeath()
    {
        Invoke("ResetMaterial", 0.1f);
        spawner.SetBool("Dead", true);
        StartCoroutine(DeathWait());
    }

    IEnumerator DeathWait()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}

public static class spawn_crashers
{
    public static bool isAlive = true;
}