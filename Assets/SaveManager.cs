using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{

    public Transform parentObject;
    public List<MapObject.MapObjects> objectList;
    public string dataString;


    public void SaveObjects()
    {
        objectList = new List<MapObject.MapObjects>();

        foreach (Transform child in parentObject)
        {
            objectList.Add(child.GetComponent<MapObject>().mapObject);
        }

        Objectwrapper wrapper = new Objectwrapper();
        wrapper.data = objectList;

        dataString = JsonUtility.ToJson(wrapper);
        System.IO.File.WriteAllText(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop) + "/map.json", dataString);
        Debug.Log("Saving objects into json");
    }



}

[Serializable]
public class Objectwrapper
{
    public List<MapObject.MapObjects> data;
}

