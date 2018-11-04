using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCharacter : MonoBehaviour
{

    public Transform playerTransform; //把运动物体放到这里
    private Vector3 offset;


    void Start()
    {
        offset = transform.position - playerTransform.position;//计算初始物体和相机的偏移距离
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTransform.position + offset;//运动物体当前位置加上原始位移
    }
}
   
