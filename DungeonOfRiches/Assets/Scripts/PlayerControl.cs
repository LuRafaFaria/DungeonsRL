using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerControl : MonoBehaviour
{
    Plane ground;
    Ray ray;
    Vector3 mousedestination;
    bool looking;
    Vector3 mouselook;
    public NavMeshAgent navigator;
    public float turnTime = 500f;
    InGameMenu menuscript;
    bool gamepaused;
    public int controlscheme;

    void Start()
    {
        menuscript = Camera.main.GetComponent<InGameMenu>();
        controlscheme = PlayerPrefs.GetInt("Scheme",0);
    }

    // Update is called once per frame
    void Update()
    {
        gamepaused = menuscript.GamePaused;
        if (!gamepaused)
        {
            if (controlscheme == 0)
            {
                if (Input.GetKeyDown(KeyCode.Mouse1))
                {
                    mousedestination = mousepos();
                    navigator.SetDestination(mousedestination);
                }
                if (Input.GetKey(KeyCode.Mouse0))
                {
                    looking = true;
                    mouselook = mousepos();
                }
            }
            else if (controlscheme == 1) 
            {
                if (Input.GetKey(KeyCode.Mouse0))
                {
                    looking = true;
                    mouselook = mousepos();
                }
                mousedestination = transform.position;
                if (Input.GetKey(KeyCode.W))
                {
                    mousedestination.z += 10;
                }
                if (Input.GetKey(KeyCode.S))
                {
                    mousedestination.z -= 10;
                }
                if (Input.GetKey(KeyCode.D))
                {
                    mousedestination.x += 10;
                }
                if (Input.GetKey(KeyCode.A))
                {
                    mousedestination.x -= 10;
                }
                navigator.SetDestination(mousedestination);
            }
        }          
    }
    void LateUpdate()
    {
        if (looking) 
        {
            Vector3 relativePos = mouselook - transform.position;
            Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, turnTime * Time.deltaTime);
        }
    }

    public Vector3 mousepos() 
    {
        ground = new Plane(Vector3.up, gameObject.transform.position);
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float dist;
        if (ground.Raycast(ray, out dist))
        {
           return ray.GetPoint(dist);
        }
        return Vector3.zero;
    }
}
