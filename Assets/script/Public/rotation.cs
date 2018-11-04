using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour {
    // Use this for initialization
    Vector3 m_startPos;
    Vector3 m_endPos;
    Vector3 point=new Vector3(0,0,-10);
    bool m_down = false;
    bool test = false;
    
    bool FingerSwipe()
    {
        
        if (Application.platform == RuntimePlatform.WindowsEditor)
        {

            if (Input.GetMouseButtonDown(0) && Mathf.Abs(Vector3.Distance(point, Camera.main.ScreenToWorldPoint(Input.mousePosition))) <= 3.0f)
            {
                test = true;
                if (m_down == false)
                {
                    m_down = true;
                    m_startPos = Input.mousePosition;
                }

            }
            else if (Input.GetMouseButtonUp(0) && test == true)
            {
                if (m_down == true)
                {
                    m_down = false;
                    m_endPos = Input.mousePosition;
                    if (Vector3.Distance(m_startPos, m_endPos) > 150.0f)
                    {
                        test = false;
                        return true;
                    }
                }
            }
        }
        return false;
    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        if (StarMove.score < StarMove.targetScore)
        {
            if (FingerSwipe())

            {
                Vector3 moveDirection;
                moveDirection = m_startPos - m_endPos;
                moveDirection.z = 0;
                moveDirection.Normalize();
                float targetAngle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(0, 0, targetAngle - 38);
                transform.position = new Vector3(0, 0, 0);
            }
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
