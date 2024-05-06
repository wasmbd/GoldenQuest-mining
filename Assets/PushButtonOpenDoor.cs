using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class PushButtonOpenDoor : MonoBehaviour
{
    public Animator leftDoorAnimator;
    public Animator rightDoorAnimator;
    public string boolName = "Open";

    void Start()
    {
        GetComponent<XRSimpleInteractable>().selectEntered.AddListener(x => ToggleDoorsOpen());
    }

    public void ToggleDoorsOpen()
    {
        bool isLeftDoorOpen = leftDoorAnimator.GetBool(boolName);
        bool isRightDoorOpen = rightDoorAnimator.GetBool(boolName);

        leftDoorAnimator.SetBool(boolName, !isLeftDoorOpen);
        rightDoorAnimator.SetBool(boolName, !isRightDoorOpen);
    }
}
