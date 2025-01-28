using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoonButton : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 mousePosition;
    public GameObject Weather;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (mousePosition.x >= 2.138 && mousePosition.x <= 4.3 && mousePosition.y >= -3.07 && mousePosition.y <= -0.71 && Input.GetMouseButtonDown(0))
        {

            Weather.GetComponent<Weather>().NightCycle();
           


        }
    }
}