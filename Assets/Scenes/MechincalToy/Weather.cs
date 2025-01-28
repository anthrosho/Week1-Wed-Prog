using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Weather : MonoBehaviour
{
    // Start is called before the first frame update
    public Boolean DayNightCycle;
    private Vector3 DayTimePosition = new Vector3(0,  0, - 354.50f);
    private Vector3 NightTimePosition = new Vector3(0, 0, -531.09f);
    public float t;
    public Boolean lockf = false; 

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        
        t += Time.deltaTime * 0.3f;
        
        if (DayNightCycle == true)
        {
            transform.rotation = Quaternion.Euler(Vector3.Lerp(NightTimePosition, DayTimePosition,t));
        }
else
        {
            transform.rotation = Quaternion.Euler(Vector3.Lerp(DayTimePosition, NightTimePosition, t));


        }
    if (t >= 1)
        {
            lockf = false; 

        }

    }
public void DayCycle ()
    {



        if (lockf == false && DayNightCycle == false)
        {
            t = 0;
            DayNightCycle = true;
            lockf = true;

        }

    }
    public void NightCycle()
    {

        if (lockf == false && DayNightCycle == true) {

            t = 0;
            DayNightCycle = false;
            lockf = true;
        }


        
    }


}

