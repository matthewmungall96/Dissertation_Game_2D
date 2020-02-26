using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Projectile : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 40;
    public float lifetime;
    public GameObject impactEffect;

    private void Start()
    {
        rb.velocity = Vector3.left * speed;
        Disappear();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag ("Enemy"))
        {
            return;
        }

        if (collision.CompareTag("Player"))
        {
            PlayerHealth.playerHealthNo = PlayerHealth.playerHealthNo - damage;
            Instantiate(impactEffect, transform.position, transform.rotation);
            StartCoroutine(DeathWait());
        }

    }

    IEnumerator DeathWait()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }

    private void Disappear()
    {
        Destroy(gameObject, lifetime);
    }

}
