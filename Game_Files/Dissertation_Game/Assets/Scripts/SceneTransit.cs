using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneTransit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReturntoMenu()
    {
        SceneManager.LoadScene("1. Main Menu");
    }

    public void Mars1()
    {
        SceneManager.LoadScene("2.1. Mars 1");
    }

    public void Jupiter1()
    {
        SceneManager.LoadScene("3.1 Jupiter 1");
    }

    public void Venus1()
    {
        SceneManager.LoadScene("4.1 Venus 1");
    }
}
