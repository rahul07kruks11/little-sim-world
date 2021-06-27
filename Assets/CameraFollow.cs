using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    private Transform myTransform;
    private Transform target;
    public Vector3 offset = new Vector3(3, 7.5f, 0);
    public Vector3 offset_r = new Vector3(10, 10, 0);
    void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Start()
    {
        myTransform = this.transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (target != null)
        {
            myTransform.position = target.position + offset;
            myTransform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

} // class