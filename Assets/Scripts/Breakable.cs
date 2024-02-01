using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour
{
    public GameObject[] breakablePieces;
    void Update()
    {
        foreach (var item in breakablePieces)
        {
            item.SetActive(false);
        }
    }


    void OnTriggerEnter(Collider other)
    {
       /* if (other.gameObject.CompareTag("Hammer"))
        {*/

            foreach (var item in breakablePieces)
            {
                item.SetActive(true);
            }

            
/*
        }*/
        gameObject.SetActive(false);
    }
}