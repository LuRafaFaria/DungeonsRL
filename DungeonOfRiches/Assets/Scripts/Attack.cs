using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public AttackStats;
    public GameObject Sender;
    public int Target;
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Enemy" && Target == 1) 
        {

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
