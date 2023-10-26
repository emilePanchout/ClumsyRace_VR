using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class prefabPreview : MonoBehaviour
{
    public GameObject prefab;
    public Image image;
    void Start()
    {

        image.sprite = Sprite.Create(AssetPreview.GetMiniThumbnail(prefab), new Rect(0, 0, AssetPreview.GetMiniThumbnail(prefab).width, AssetPreview.GetMiniThumbnail(prefab).height), Vector2.zero);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
