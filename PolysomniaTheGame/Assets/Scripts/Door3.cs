using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door3 : MonoBehaviour
{
    private Animator openDoor;




    private void Start()
    {
        openDoor = GetComponent<Animator>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            openDoor.Play("Door_3_bottom_B");
        }
    }
}
