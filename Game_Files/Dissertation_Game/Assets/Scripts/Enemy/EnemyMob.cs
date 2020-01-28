using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMob : MonoBehaviour
{
    private int Health = 10;

    public Material MatWhite;
    private Material MatDefault;
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        MatDefault = sr.material;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Missile"))
        {
            Destroy(collision.gameObject);
            Health--;
            sr.material = MatWhite;
            if (Health < 0)
            {
                KillSelf();
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

    private void KillSelf()
    {
        Destroy(gameObject);
    }
}
