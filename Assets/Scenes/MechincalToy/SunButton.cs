using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SunButton : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Weather;
    public Vector2 mousePosition;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (mousePosition.x >= -4.48 && mousePosition.x <= -2.2 && mousePosition.y >= -3.07 && mousePosition.y <= -0.71 && Input.GetMouseButtonDown(0))
        {
            Weather.GetComponent<Weather>().DayCycle();

            Debug.Log("DayCounter incremented: " );

        }
    }
}