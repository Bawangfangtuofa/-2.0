using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {
    public float mspeed = 10F;
    public Transform playerTransform; //把运动物体放到这里
    private Vector3 offset;
    public float moveSpeed;
    public GameObject target;
    IEnumerator Wait()
    {
        //等待5秒在执行
        yield return new WaitForSeconds(5);
    }
    // Use this for initialization
    void Start ()
    {
        offset = transform.position - playerTransform.position;//计算初始物体和相机的偏移距离 

    }
	
	// Update is called once per frame
	void Update ()
    {
        
        if (transform.position.y>-37.5)
        {
            transform.Translate(Vector3.up * Time.deltaTime *-10f);
            
        }
        else if(transform.position.y<=-37.5)
        {
            if (transform.position.x - target.transform.position.x >= 7f)
            {
                transform.position = new Vector3(target.transform.position.x + 7f, transform.position.y, -10);
            }
            else if (target.transform.position.x - transform.position.x >= 7f)
            {
                transform.position = new Vector3(target.transform.position.x - 7f, transform.position.y, -10);
            }
        }
        
	}
    
}
