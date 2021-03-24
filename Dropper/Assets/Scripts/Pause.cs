using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    private FirstPersonController FPC;


    void Start()
    {
        FPC = FindObjectOfType<FirstPersonController>();

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            FPC.LockPlayer(true);
            //LoadSceneMode.Additive("PauseScene");
        }
    }
}
