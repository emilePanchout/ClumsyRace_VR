using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapObject : MonoBehaviour
{
    public types type;
    public MapObjects mapObject;

    [Serializable]
    public struct MapObjects
    {
        public Vector3 position;
        public Quaternion rotation;
        public types type;

        public MapObjects(Vector3 pos, Quaternion rot, types name)
        {
            this.position = pos;
            this.rotation = rot;
            this.type = name;
        }
    }

    private void Update()
    {
        mapObject = new MapObjects(transform.position, transform.rotation, type);
    }

    public enum types
    {
        StartLine,
        EndLine,
        Checkpoint,
        Bumper,
        Shooter,
        Fan,
        Trampoline,
        MedCircle,
        MedFlatRectangle,
        MedFlatSquare,
        SmallCircle,
        SmallFlatSquare,
        SmallFlatRectangle,
        SmallHill,
        SmallLongHill,
        Void,


    }


}
