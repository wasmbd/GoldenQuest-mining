using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Trigger : MonoBehaviour
{
    public Canvas Canvas;
    public GameObject Player;
    public int offset;
    private void Update()
    {
        if (Vector3.Distance(gameObject.transform.position, Player.transform.position) < offset)
        {
            Canvas.gameObject.SetActive(true);
        }
        else
        {
            Canvas.gameObject.SetActive(false);
        }

    }
}
