using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokeItem : MonoBehaviour
{

    public GameObject leftDoor;
    public GameObject rightDoor;
    public AnimationClip leftOpenAnimation;
    public AnimationClip rightOpenAnimation;

    private bool isLeftOpen = false;
    private bool isRightOpen = false;

    private void Start()
    {
        // Deactivate the door animations at the start
        leftDoor.SetActive(false);
        rightDoor.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Activate the door animations when the player interacts with the poke item
            ActivateDoorAnimation(leftDoor, leftOpenAnimation);
            ActivateDoorAnimation(rightDoor, rightOpenAnimation);
        }
    }

    private void ActivateDoorAnimation(GameObject door, AnimationClip animationClip)
    {
        door.SetActive(true);
        Animation anim = door.GetComponent<Animation>();
        if (anim == null)
        {
            anim = door.AddComponent<Animation>();
        }
        anim.AddClip(animationClip, animationClip.name);
        anim.Play(animationClip.name);
    }
}
