using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public Animator asteroid;
    public float damage = 10;
    private Rigidbody2D rigidBody;
    public bool destroyPrep = false;
    public bool doesDamage = true;
    // Update is called once per frame
    void Update()
    {
        rigidBody = GetComponent<Rigidbody2D>();

        if (destroyPrep == true)
        {
            prepareToDestroy();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && doesDamage == true)
        {
            Destroy(rigidBody);
            asteroid.SetBool("Explosion", true);
            PlayerHealth.playerHealthNo = PlayerHealth.playerHealthNo - damage;
        }

        if (collision.CompareTag("Obstacle"))
        {
            Destroy(rigidBody);
            asteroid.SetBool("Explosion", true);
        }
    }

    void prepareToDestroy()
    {
        StartCoroutine(Destroy());
    }

    public IEnumerator Destroy()
    {
        yield return new WaitForSeconds(0);
        Destroy(gameObject);
    }
}
