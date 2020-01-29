using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovementScript : MonoBehaviour
{
    private bool GamePaused = false;
    public GameObject thruster1;
    public GameObject thruster2;
    private bool thrustersOn = false;

    // Update is called once per frame
    void Update()
    {
        if (GamePaused == false && PlayerHealth.playerHealthNo > 0)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                Debug.Log("Character.Log.1: Moving Down.");
            }

            if (Input.GetKey(KeyCode.S))
            {
                gameObject.transform.Translate(Vector3.right * 0.05f);
            }

            if (Input.GetKeyDown(KeyCode.W))
            {
                Debug.Log("Character.Log.2: Moving Up.");
            }

            if (Input.GetKey(KeyCode.W))
            {
                gameObject.transform.Translate(Vector3.left * 0.05f);
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                Debug.Log("Character.Log.3: Moving Left.");
            }

            if (Input.GetKey(KeyCode.A))
            {
                gameObject.transform.Translate(Vector3.down * 0.05f);
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                Debug.Log("Character.Log.4: Moving Right.");
            }

            if (Input.GetKey(KeyCode.D))
            {
                gameObject.transform.Translate(Vector3.up * 0.05f);
                thrustersOn = true;
                    if (thrustersOn == true)
                    {
                        thruster1.SetActive(true);
                        thruster2.SetActive(true);
                    }

                    else
                    {
                        thrustersOn = false;
                    }
            }

            if (Input.GetKeyDown(KeyCode.P))
            {
                GamePaused = true;
            }
        }

        else if (GamePaused == true)
        {
            return;
        }



        else
        {
            thruster1.SetActive(false);
            thruster2.SetActive(false);
        }

    }

    public void OnPause()
    {
        GamePaused = true;
    }

    public void UnPause()
    {
        GamePaused = false;
    }
}
