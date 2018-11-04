using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change1 : MonoBehaviour
{
    public float Speed = 1.5f; // 定义图片切换的速度

    private bool Triggered = false; //定义图片的标志变量
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Triggered)
        {
            Zup();

        }
    }

    private void Zup()
    {
        while (true & transform.position.z < 3)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 1.5f);
        }
    }

    private void Zdown()
    {
        if (true)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * (-1.5f));
        }
    }

    void OnTriggerEnter(Collider mCollider)
    {
        Debug.Log(mCollider.gameObject.tag);
        if (mCollider.gameObject.tag == "Character")
        {
            Triggered = true;
        }
    }

    void OnTriggerExit(Collider mCollider)
    {
        if (mCollider.gameObject.tag == "Character")
        {
            Triggered = false;
        }
    }
}
