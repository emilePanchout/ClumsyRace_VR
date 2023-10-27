using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePreview : MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        endPoint.position = new Vector3(startPoint.position.x + 16, startPoint.position.y, startPoint.position.z);
    }
}
