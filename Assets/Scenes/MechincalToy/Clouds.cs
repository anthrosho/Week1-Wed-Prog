using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{

    public GameObject Weather;
    public Vector3 Cloud1Position = new Vector3(13.34f, 0.43f, 0);
    public Vector3 Cloud2Position = new Vector3(-14.3f, 0.66f, 0);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Weather.GetComponent<Weather>().DayNightCycle == false && Weather.GetComponent<Weather>().lockf == false)  {

            transform.position = Cloud1Position;
        } 



    }
}
