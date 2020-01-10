using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 30;
    public float lifetime;



    private void Start()
    {
        rb.velocity = Vector3.right * speed;
        Disappear();
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);
        Destroy(gameObject);
    }

    private void Disappear()
    {
        Destroy(gameObject, lifetime);
    }

}
