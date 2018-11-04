using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class StarMove : MonoBehaviour {
    public GameObject newbodynext;
    Vector3 tempVector;
    static int p;
    public float moveSpeed;
    bool flag=false;

    public static int targetScore = 5;
    public static int score=0;

    public List<Vector3> Direction = new List<Vector3>();
    public List<Vector3> Position = new List<Vector3>();

    // Use this for initialization
    private void Awake()
    {
        newbodynext.SetActive(false);
    }
    void Start() {
        
        Invoke("Star", 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (score < targetScore)
        {
            if (Time.timeSinceLevelLoad > 3)
            {
                Vector3 currentPosition = newbodynext.transform.position;
                Vector3 target = tempVector * moveSpeed + currentPosition;
                newbodynext.transform.position = Vector3.Lerp(currentPosition, target, Time.deltaTime);
            }
            if ((Mathf.Abs(newbodynext.transform.position.x) > 11.0f || Mathf.Abs(newbodynext.transform.position.y) > 7f) && flag == false)
            {
                flag = true;
                newbodynext.SetActive(false);
                tempVector = Vector3.zero;
                int t = Random.Range(0, 2);
                Invoke("Star", t);
            }
        }
        else
        {
            flag = true;
            newbodynext.SetActive(false);
            tempVector = Vector3.zero;

        }

    }

    void Star()
    {
        if (score < targetScore)
        {
            p = Random.Range(0, 3);
            newbodynext.transform.position = Position[p];
            tempVector = Direction[p];
            newbodynext.SetActive(true);
            flag = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        if(collision.gameObject.tag=="star" && flag == false)
        {
            flag = true;
            score++;
            collision.gameObject.SetActive(false);
            tempVector = Vector3.zero;
            int t = Random.Range(0, 2);
            Invoke("Star", t);
        }
    }
    
}
