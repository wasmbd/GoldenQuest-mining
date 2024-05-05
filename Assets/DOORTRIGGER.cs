using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DOORTRIGGER : MonoBehaviour
{
    private Animator m_Animator;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Activate the door animations when the player interacts with the poke item
            m_Animator.SetTrigger("ANIMATION DOOR");


        }
    }
}
