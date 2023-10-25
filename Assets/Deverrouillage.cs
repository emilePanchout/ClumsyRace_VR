using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class Deverrouillage : MonoBehaviour
{

    public InputActionReference deverouillage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (deverouillage.action.triggered)
        {
            Debug.Log("Deverrouiller");
            onDeVerouillage();


        }


    }




    private void onDeVerouillage()
    {

        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit))

        {
            GameObject objetPointe = hit.collider.gameObject;

            XRGrabInteractable interactable = objetPointe.GetComponent<XRGrabInteractable>();

            interactable.enabled = true;

        }
    }
}
