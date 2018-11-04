using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    public float moveSpeed;
    public GameObject target;//角色物体

    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x - target.transform.position.x >= 7f)
        {
            transform.position = new Vector3(target.transform.position.x , target.transform.position.y, -10);
        }
        else if (target.transform.position.x - transform.position.x >= 7f)
        {
            transform.position = new Vector3(target.transform.position.x , target.transform.position.y, -10);
        }
    }
}
