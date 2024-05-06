using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorSoundsTrigger : MonoBehaviour
{
    public AudioSource SensorSound;
    private void Start()
    {
        SensorSound.GetComponent<AudioSource>();
    }
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
   /* private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Sensor"))
        {
            SensorSound.Play();
        }

    }*/
}
