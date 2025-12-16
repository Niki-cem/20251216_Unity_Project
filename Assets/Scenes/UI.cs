using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WindowController : MonoBehaviour
{
    public GameObject window1;
    public GameObject window1_2;

    void Start()
    {
        window1.SetActive(false);
        window1_2.SetActive(false);
    }

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            if(!window1.activeSelf)
            {
                window1.SetActive(true);
                window1_2.SetActive(false);
            }
            else if(window1_2.activeSelf)
            {
                window1.SetActive(true);
                window1_2.SetActive(false);

            }
            else
            {
                window1.SetActive(false);
            }
        }
    }
    public void OnClickNext()
    {
        if (window1.activeSelf && !window1_2.activeSelf)
            {
                window1_2.SetActive(true);
                window1.SetActive(false);
            }
    }
    public void OnClickClose()
    {
        if (!window1.activeSelf && window1_2.activeSelf)
            {
                window1_2.SetActive(false);
            }
    }
}

