using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleaseLilith : MonoBehaviour
{

    public GameObject choice;
    
    private void OnCollisionEnter(Collision collision)
    {
        choice.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    private void OnCollisionExit(Collision collision)
    {
        Destroy(gameObject);
    }
}
