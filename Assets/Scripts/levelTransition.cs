using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelTransition : MonoBehaviour
{
    private GameObject Camera;

    void Start()
    {
        Camera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Camera.GetComponent<CameraMovement>().ChangeLevel(transform.parent.gameObject);
        }
    }
}
