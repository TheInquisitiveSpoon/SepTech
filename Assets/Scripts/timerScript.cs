using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerScript : MonoBehaviour
{
    void Update()
    {
        float mins = Mathf.FloorToInt(Time.time / 60F);
        float secs = Mathf.FloorToInt(Time.time - mins * 60);
        string time = string.Format("{0:0}:{1:00}", mins, secs);
        gameObject.GetComponent<Text>().text = time;
    }
}
