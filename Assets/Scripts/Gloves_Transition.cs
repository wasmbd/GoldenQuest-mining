using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Gloves_Transition : MonoBehaviour
{
    public GameObject gloves;
    public GameObject leftController;
    public GameObject rightController;
    public GameObject particleSystem;
    public Material newMaterial;
    public XRSocketInteractor socket;



    private void Update()
    {
        bool glovesEquipped = false;
        // Check if the player is holding the gloves
        if (!glovesEquipped && gloves != null && socket.selectTarget != null)
        {
            if (socket.selectTarget.gameObject == leftController || socket.selectTarget.gameObject == rightController)
            {
                // Gloves are equipped
                glovesEquipped = true;
                PlayParticleSystem();
                ChangeMaterial();
                StartCoroutine(Disable_socketAndParticle());
            }
        }
    }
    private void PlayParticleSystem()
    {
        particleSystem.gameObject.SetActive(true);
    }
    private void ChangeMaterial()
    {
        var leftRenderer = leftController.GetComponent<Renderer>();
        var rightRenderer = rightController.GetComponent<Renderer>();

            leftRenderer.material = newMaterial;
            rightRenderer.material = newMaterial;
        
    }
    IEnumerator Disable_socketAndParticle()
    {
        Destroy(gloves);
        yield return new WaitForSeconds(0.5f);
        Destroy(socket);
        yield return new WaitForSeconds(0.3f);
        Destroy(particleSystem);

    }
}
