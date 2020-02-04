using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 30;
    public float lifetime;
    public GameObject impactEffect;

    private void Start()
    {
        rb.velocity = Vector3.right * speed;
        Disappear();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag ("Player"))
        {
            return;
        }

        if (collision.CompareTag("Enemy"))
        {
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
