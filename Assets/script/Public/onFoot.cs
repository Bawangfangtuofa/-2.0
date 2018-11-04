using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onFoot : MonoBehaviour {
    public float moveSpeed;
    private Vector3 moveDirection;
    public Vector3 mousePosition;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        Vector3 currentPosition = transform.position;
        Vector3 moveToward;
        if (Input.GetButton("Fire1"))
        {
            moveToward = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0;
            moveDirection = moveToward - currentPosition;
            moveDirection.z = 0;
            moveDirection.y = 0;
            moveDirection.Normalize();
        }
        Vector3 target = moveDirection * moveSpeed + currentPosition;
        if (mousePosition.y - transform.position.y <= 2f&& mousePosition.y - transform.position.y >= -2f)
              if (mousePosition.x- transform.position.x >= 0.1f|| transform.position.x- mousePosition.x>=0.1f)
             {
                 transform.position = Vector3.Lerp(currentPosition, target, Time.deltaTime);
             }
    }
}
