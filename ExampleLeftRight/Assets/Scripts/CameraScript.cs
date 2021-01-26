using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform Target;
    bool Follow;

    Transform myTransform;
    void Awake()
    {
        myTransform = transform;
    }

    void Start()
    {
        Follow = true;
    }

    void LateUpdate()
    {
        if (Target != null && Follow == true)
        {
            myTransform.position = new Vector3(Target.position.x, myTransform.position.y, myTransform.position.z);
            myTransform.eulerAngles = new Vector3(15, 0, Target.eulerAngles.z);
        }
    }
}