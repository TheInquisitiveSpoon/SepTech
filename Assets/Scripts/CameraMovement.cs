using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private GameObject Level1;
    private GameObject Level2;
    private GameObject Level3;

    void Start()
    {
        Level1 = GameObject.FindGameObjectWithTag("Level1");
        Level2 = GameObject.FindGameObjectWithTag("Level2");
        Level3 = GameObject.FindGameObjectWithTag("Level3");
    }
    public void ChangeLevel(GameObject level)
    {
        gameObject.transform.position = new Vector3(level.transform.position.x, level.transform.position.y, -10.0f);
    }
}

