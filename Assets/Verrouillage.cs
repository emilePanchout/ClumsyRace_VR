using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class Verrouillage : MonoBehaviour
{

    public InputActionReference deleteRef;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (deleteRef.action.triggered)
        {
            Debug.Log("verrouiller");
            onVerouillage();
           

        }
    }


    private void onVerouillage()
    {

        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit))
            
        {
                  GameObject objetPointe = hit.collider.gameObject;
          
              XRGrabInteractable interactable = objetPointe.GetComponent<XRGrabInteractable>();

            interactable.enabled = false;

        }
    }
    




}
