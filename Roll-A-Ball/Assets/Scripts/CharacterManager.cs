using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public GameObject[] characters;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            characters[0].SetActive(true);
            characters[1].SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.X)){

            characters[1].SetActive(true);
            characters[0].SetActive(false);
        }
    }
}
