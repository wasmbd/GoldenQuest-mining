using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class SocketArray : MonoBehaviour
{
    public GameObject[] array;
    public XRSocketInteractor[] socketArr;
    bool[] is_right;
    // Start is called before the first frame update
    void Start()
    {
        is_right = new bool[array.Length];
    }
    IEnumerator enable_socket(XRSocketInteractor socket)
    {
        yield return new WaitForSeconds(1f);
        socket.enabled = true;
    }
    void check(bool[] isright)
    {
        for (int i = 0; i < isright.Length; i++) {
            if (!isright[i])
            {
                return;
            }
        }
        this.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < socketArr.Length; i++)
        {
            if (socketArr[i].hasHover)
            {
                IXRHoverInteractable obj = socketArr[i].GetOldestInteractableHovered();
                if(obj.transform.GetInstanceID() != array[i].GetInstanceID())
                {
                    socketArr[i].enabled = false;
                    StartCoroutine(enable_socket(socketArr[i]));
                }
                else
                {
                    is_right[i] = true;
                    check(is_right);
                }
            }
        }
    }
}
