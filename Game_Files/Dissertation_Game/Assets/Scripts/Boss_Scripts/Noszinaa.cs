using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Noszinaa : MonoBehaviour
{
    private float NoszinaaHealth = 200f;
    private float NoszinaaMaxHealth = 200f;
    public GameObject NoszinaaFightUi;
    public Image NoszinaaHealthBar;
    public Animator NoszinaaAnim;
    public Material MatWhite;
    private Material MatDefault;
    SpriteRenderer sr;
    private bool death = false;
    public UnityEvent onTriggered;
    public bool trigger_once;
    private bool isTriggered;
    public GameObject winScreen;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        MatDefault = sr.material;
    }

    // Update is called once per frame
    void Update()
    {
        updateHealth();
        if (NoszinaaHealth <= 0 && death == false)
        {
            KillSelf();
        }

        else
        {
            Invoke("ResetMaterial", 0.1f);
        }
    }

    private void updateHealth()
    {
        float ratio = NoszinaaHealth / NoszinaaMaxHealth;
        NoszinaaHealthBar.rectTransform.localScale = new Vector3(ratio, 1, 1);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Missile"))
        {
            Destroy(collision.gameObject);
            NoszinaaHealth = NoszinaaHealth - 10;
            sr.material = MatWhite;
            updateHealth();
        }
    }

    void ResetMaterial()
    {
        sr.material = MatDefault;
    }

    private void KillSelf()
    {
            death = true;
            winScreen.SetActive(true);
            NoszinaaAnim.SetBool("Die", true);
            NoszinaaFightUi.SetActive(false);
    }
}
