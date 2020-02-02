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

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (gameObject.tag == "player")
        {
            return;
        }

        if (gameObject.tag == "Enemy")
        {
            Debug.Log(hitInfo.name);
            Instantiate(impactEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }

    }

    private void Disappear()
    {
        Destroy(gameObject, lifetime);
    }

}
