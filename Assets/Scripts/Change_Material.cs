using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Material : MonoBehaviour
{
  //  public Material material;
    public Material New_material;
    public GameObject Glove1;
    public GameObject Glove2;
    public GameObject Particle;
    public GameObject leftController;
    public GameObject rightController;
    // Start is called before the first frame update
    void Start()
    {
        ChangeMaterial();
    }

    IEnumerator ChangeMaterial()
    {
        yield return new WaitForSeconds(20f);
        Destroy(Glove1);
        Destroy(Glove2);
        var leftRenderer = leftController.GetComponent<Renderer>();
        var rightRenderer = rightController.GetComponent<Renderer>();

        leftRenderer.material = New_material;
        rightRenderer.material = New_material;
        yield return new WaitForSeconds(0.2f);
        Destroy(Particle);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
