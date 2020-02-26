using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Random = System.Random;

public class Enemy_Shooters : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    private Transform Target;
    private int health =  15;
    public Material MatWhite;
    private Material MatDefault;
    SpriteRenderer sr;
    public GameObject bulletPrefab;
    public Transform blaster;
    public float totalTime = 0f;
    public float shotTime = 0f;
    public float nextFire;
    public float randomFire = 1f;
    public float fireRate = 3f;
    public bool isDead = false;
    public Animator death;

    private void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        sr = GetComponent<SpriteRenderer>();
        MatDefault = sr.material;
    }

    private void Update()
    {
        totalTime += Time.deltaTime;
        shotTime += Time.deltaTime;

        if (health > 0)
        {
            Tracked();
        }

        if (death == false)
        {
            fire();
        }

        if (isDead == true)
        {
            destroy();
        }
    }

    private void Tracked()
    {
        {
            if (Vector2.Distance(transform.position, Target.position) > stoppingDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, Target.position, speed * Time.deltaTime);
            }
        }
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

    public void fire()
    {
            Instantiate(bulletPrefab, blaster.position, blaster.rotation);
    }

    void ResetMaterial()
    {
        sr.material = MatDefault;
    }

    public void OnDeath()
    {
        Invoke("ResetMaterial", 0.1f);
        death.SetBool("Dead", true);
    }

    public void destroy()
    {
        PlayerScore.playerpoints = PlayerScore.playerpoints + 15;
        Destroy(gameObject);
    }
}