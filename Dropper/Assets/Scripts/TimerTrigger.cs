using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTrigger : MonoBehaviour
{
    public bool timerState;

    public void OnTriggerEnter(Collider other)
    {
        timerState = true;
    }
}
