using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Slidshow : MonoBehaviour
{
    public GameObject slide1;
    public GameObject slide2;
    public GameObject slide3;
    public GameObject slide4;

    public GameObject Eve;
    public GameObject Freedom;
    public GameObject choices;

    public void Slide2()
    {
        slide1.SetActive(false);
    }

    public void Slide3()
    {
        slide2.SetActive(false);
    }
    public void Slide4()
    {
        slide3.SetActive(false);
    }

    public void StartGame()
    {
        slide4.SetActive(false);

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
       
    }

    public void FreeEve()
    {
        
        Eve.transform.position = Freedom.transform.position;
        choices.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }

    public void DontFree()
    {
        choices.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
