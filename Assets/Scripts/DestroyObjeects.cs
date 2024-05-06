using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjeects : MonoBehaviour
{
    public GameObject[] objTO_Active;
    public GameObject[] objTO_Deactive;
    public GameObject mainOBG;
    private void Start()
    {
        Invoke("activateObject", 20);
        Invoke("DeactivateObject", 50);

        Destroy(mainOBG);
    }

    void activateObject()
    {
        foreach (GameObject obj in objTO_Active)
        {
         
                obj.SetActive(true);
        
        }
    }
        void DeactivateObject()
    {
        foreach (GameObject obj in objTO_Deactive)
        {
                obj.SetActive(false);
        } 
    }
}
