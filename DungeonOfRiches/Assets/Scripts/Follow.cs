using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target;
    public bool followx;
    public bool followy; 
    public bool followz;
    public float offsetx;
    public float offsety;
    public float offsetz;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (followx) 
        {
            pos.x = target.position.x + offsetx;
        }
        else
        {
            pos.x = gameObject.transform.position.x;
        }
        if (followy)
        {
            pos.y = target.position.y + offsety;
        }
        else
        {
            pos.y = gameObject.transform.position.y;
        }
        if (followz)
        {
            pos.z = target.position.z + offsetz;
        }
        else
        {
            pos.z = gameObject.transform.position.z;
        }
        gameObject.transform.position = pos;
    }
}
