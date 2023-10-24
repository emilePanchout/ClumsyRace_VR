using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlateformeOption : MonoBehaviour




{
    public TMPro.TMP_Dropdown dropdownplateforme;
    public TMPro.TMP_Dropdown dropdownpiege;

    public Transform hand;
    public Transform piegeposition;
    public GameObject parent;

    public GameObject[] prefabsplatforme;
    public GameObject[] prefabspiège;
    // public Transform hand;

    // public GameObject[] prefabs;
    void Start()

    {
        List<string> optionsplateforme = new List<string>();
        foreach (GameObject prefab in prefabsplatforme)
        {
            optionsplateforme.Add(prefab.name); // ajouter
        }
        dropdownplateforme.AddOptions(optionsplateforme);

        List<string> optionspieges = new List<string>();
        foreach (GameObject i in prefabspiège)
        {
            optionspieges.Add(i.name); // ajouter
        }
        dropdownpiege.AddOptions(optionspieges); ;


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDropdownValueChanged(int index)
    {

        string selectedOption = dropdownplateforme.options[index].text;

        GameObject selectedPrefab = prefabsplatforme[index];
        Instantiate(selectedPrefab, hand.position, hand.rotation,parent.transform);
    }



    public void OnDropdownValuepiege(int index)
    {

        string selectedOption = dropdownpiege.options[index].text;

        GameObject selectedPrefab = prefabspiège[index];
        Instantiate(selectedPrefab, piegeposition.position, piegeposition.rotation, parent.transform);
    }
}
