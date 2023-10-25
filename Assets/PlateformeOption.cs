using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlateformeOption : MonoBehaviour




{
    public TMPro.TMP_Dropdown dropdownplateforme;
    public TMPro.TMP_Dropdown dropdownpiege;
    public TMPro.TMP_Dropdown dropdowntrap;

    public Transform hand;
    public Transform piegeposition;
    public GameObject parent;

    public GameObject[] prefabsplatforme;
  
    public GameObject[] prefabspiège;

    public GameObject[] prefabTrap;
    // public Transform hand;

    // public GameObject[] prefabs;
    void Start()

    {
        List<string> optionsplateforme = new List<string>();
        foreach (GameObject prefab in prefabsplatforme)
        {
            optionsplateforme.Add(prefab.name); // ajouter les  prefab plateforms
        }
        dropdownplateforme.AddOptions(optionsplateforme);

        List<string> optionspieges = new List<string>();
        foreach (GameObject i in prefabspiège)
        {
            optionspieges.Add(i.name); // ajouter  les prefab checkpoints
        }
        dropdownpiege.AddOptions(optionspieges);


        List<string> optionsTrap= new List<string>();
        foreach (GameObject i in prefabTrap)
        {
            optionsTrap.Add(i.name); // ajouter  les prefab checkpoints
        }
        dropdowntrap.AddOptions(optionsTrap);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDropdownValueChanged(int index)
    {

     

        GameObject selectedPrefab = prefabsplatforme[index];
        Instantiate(selectedPrefab, hand.position, hand.rotation,parent.transform);
    }



    public void OnDropdownValuepiege(int index)
    {

      

        GameObject selectedPrefab = prefabspiège[index];
        Instantiate(selectedPrefab, piegeposition.position, piegeposition.rotation, parent.transform);
    }

    public void OnDropdownValueTrap(int index)
    {

        

        GameObject selectedPrefab = prefabTrap[index];
        Instantiate(selectedPrefab, hand.position, hand.rotation, parent.transform);
    }




}
