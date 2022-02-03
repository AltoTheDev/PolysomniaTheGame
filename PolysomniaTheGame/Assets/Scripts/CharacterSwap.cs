using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class CharacterSwap : MonoBehaviour
{
    public Transform character;

    public List<Transform> possibleCharacters;

    public int whichCharacter;

    public CinemachineVirtualCamera cam1;
    public CinemachineVirtualCamera cam2;
    public CinemachineVirtualCamera cam3;

    private void Start()
    {
        if (character == null &&  possibleCharacters.Count >= 1)
        {
            character = possibleCharacters[0];
        }
        Swap();
    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (whichCharacter == 0)
            {
                whichCharacter = possibleCharacters.Count - 1;
            }

            else
            {
                whichCharacter -= 1;
            }
            Swap();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (whichCharacter == possibleCharacters.Count - 1)
            {
                whichCharacter = 0;
            }

            else
            {
                whichCharacter += 1;
            }
            Swap();
        }
    }

    public void Swap()
    {
        character = possibleCharacters[whichCharacter];
        character.GetComponent<PlayerMovement>().enabled = true;
        for (int i = 0; i < possibleCharacters.Count; i++)
        {
            if (possibleCharacters[i] != character)
            {
                possibleCharacters[i].GetComponent<PlayerMovement>().enabled = false; 
            }
        }

         if (whichCharacter == 0)
        {
            cam1.Priority = 10;
            cam2.Priority = 0;
            cam3.Priority = 0;
        }

        if (whichCharacter == 1)
        {
            cam1.Priority = 0;
            cam2.Priority = 10;
            cam3.Priority = 0;
        }

        if (whichCharacter == 2)
        {
            cam1.Priority = 0;
            cam2.Priority = 0;
            cam3.Priority = 10;
        }
    }
}
