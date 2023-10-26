using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class Verrouillage : MonoBehaviour
{

    public InputActionReference VerrouillageRef;
    public InputActionReference deverouillage;
    public Material newMaterial;
    public Material materialToRemove;
   // private bool isLocked = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {



        if (VerrouillageRef.action.triggered)
        {
            
                Debug.Log("verrouiller");
                onVerouillage();  

        }

        if (deverouillage.action.triggered)
        {
                Debug.Log("deverouiller");
                onDeVerouillage();

        }


    }

    private void onVerouillage()
    {
        
        RaycastHit hit;


        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            GameObject objetPointe = hit.collider.gameObject;

            if(objetPointe.GetComponent<XRGrabInteractable>())
            {
                XRGrabInteractable interactable = objetPointe.GetComponent<XRGrabInteractable>();
                objetPointe.tag = "Undeletable";
                interactable.enabled = false;
                Renderer render = objetPointe.GetComponentInChildren<MeshRenderer>();




                if (render != null && newMaterial != null)
                {
                    Material[] materials = render.materials;
                    Material[] newMaterials = new Material[materials.Length + 1];
                    for (int i = 0; i < materials.Length; i++)
                    {
                        newMaterials[i] = materials[i];
                    }

                    newMaterials[newMaterials.Length - 1] = newMaterial;
                    render.materials = newMaterials;
                }
                else
                {
                    Debug.LogWarning("Renderer ou nouveau matériau non définis.");
                }
            }

        }

        

    }

    private void onDeVerouillage()
    {
       
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit))

        {
            GameObject objetPointe = hit.collider.gameObject;

            if (objetPointe.GetComponent<XRGrabInteractable>())
            {
                XRGrabInteractable interactable = objetPointe.GetComponent<XRGrabInteractable>();
                interactable.enabled = true;
                objetPointe.tag = "Untagged";

                Renderer render = objetPointe.GetComponent<MeshRenderer>();
                if (render != null && materialToRemove != null)
                {
                    Material[] materials = render.sharedMaterials;
                    List<Material> newMaterials = new List<Material>(materials);


                    for (int i = newMaterials.Count - 1; i >= 0; i--)
                    {
                        if (newMaterials[i] == materialToRemove)
                        {
                            newMaterials.RemoveAt(i);
                        }
                    }


                    render.sharedMaterials = newMaterials.ToArray();
                }
                else
                {
                    Debug.LogWarning("Renderer ou matériau à supprimer non définis.");
                }
            }

            


        }
      



    }

   
}
