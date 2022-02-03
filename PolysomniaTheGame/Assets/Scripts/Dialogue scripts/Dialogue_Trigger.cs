using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Dialogue_Trigger : MonoBehaviour
{
        public Dialogue dialogue;
    public Transform character;
   
    public void TriggerDialogue()
    {
        FindObjectOfType<Dialogue_Manager>().StartDialogue(dialogue);

        GameObject.FindWithTag("Player").GetComponent<PlayerMovement>().enabled = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") == true)
        {
           TriggerDialogue();
        }
            
    }

}
