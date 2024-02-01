using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocksController : MonoBehaviour
{
    public GameObject shatteredTree; // Assign a pre-fractured rock model

    public void BreakRock()
    {
        shatteredTree.SetActive(true);
        gameObject.SetActive(false);
        // You could also add more effects like sounds, particles, etc.
    }
}
