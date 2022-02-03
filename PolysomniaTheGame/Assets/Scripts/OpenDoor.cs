using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private Animator openDoor;
    public Collider collide;
   


    private void Start()
    {
        openDoor = GetComponent<Animator>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            openDoor.Play("OpenDoor7");
            collide.enabled = !collide.enabled;

        }
    }



}
