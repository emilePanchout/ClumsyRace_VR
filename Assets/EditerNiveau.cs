using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class EditerNiveau : MonoBehaviour
{
   
    public TMPro.TMP_Dropdown dropdown;
    
   // public Transform positionNiveau;

    public GameObject[] Niveaux;
    // Start is called before the first frame update
    void Start()
    {
        List<string> options = new List<string>();
        foreach (GameObject Niveau in Niveaux)
        {
            options.Add(Niveau.name); // ajout des prefab
        }
        dropdown.AddOptions(options); ;


    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void NiveauEdit(int index)
    {
        GameObject selectedNiveau = Niveaux[index];

        
        Debug.Log("Position de l'objet");





    }
}
