using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    public GameObject CameraPosition;
    Vector3 now;
    
    static float moveSpeed = starBackground.moveSpeed;

    Vector3 up = new Vector3(0, 1, 0);
    Vector3 down = new Vector3(0, -1, 0);
    Vector3 left = new Vector3(-1, 0, 0);
    Vector3 right = new Vector3(1, 0, 0);

    
    /*
    float timer = 0f;
    float timerGap = 0.1f;
    */
    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update()
    {
        if (!(StarMove.score < StarMove.targetScore))
        {

            Vector3 currentPosition = transform.position;
            Vector3 nextPosition = new Vector3(0, 1, 0) * moveSpeed + currentPosition;
            if (transform.position.y < 15f)
            {
                transform.position = Vector3.Lerp(currentPosition, nextPosition, Time.deltaTime);
            }


            if (transform.position.y - CameraPosition.transform.position.y < 5f && (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)))
            {
                transform.position = 0.1f * up + transform.position;
            }
            if (CameraPosition.transform.position.y - transform.position.y < 5f && (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)))
            {
                transform.position = 0.1f * down + transform.position;
            }
            if (CameraPosition.transform.position.x - transform.position.x < 9f && (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)))
            {
                transform.position = 0.1f * left + transform.position;
            }
            if (transform.position.x - CameraPosition.transform.position.x< 9f && (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)))
            {
                transform.position = 0.1f * right + transform.position;
            }

            

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "EnemyStar")
        {


        }
    }
}
