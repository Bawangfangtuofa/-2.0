using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starBackground : MonoBehaviour {
    
    
    public static float moveSpeed=2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!(StarMove.score < StarMove.targetScore))
        {
            if (transform.position.y < 20f)
            {
                Vector3 currentPosition = transform.position;
                Vector3 nextPosition = new Vector3(0, 1, 0) * moveSpeed + currentPosition;
                transform.position = Vector3.Lerp(currentPosition, nextPosition, Time.deltaTime);
            }
        }
    }
}
