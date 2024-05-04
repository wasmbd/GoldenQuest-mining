using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorSoundsTrigger : MonoBehaviour
{
    public AudioSource SensorSound;
     void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Sensor")
        {
         SensorSound.Play();
        }
       
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Sensor")
        {
            SensorSound.Stop();
        }
    }
}
