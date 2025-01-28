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
    public Vector3 CurrentRotation; 
    public float t;

    void Start()
    {
        CurrentRotation = new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z);
        DayNightCycle = true;
    }

    // Update is called once per frame
    void Update()
    {

        
        t += Time.deltaTime * 0.3f;

        if (DayNightCycle == true)
        {
            transform.rotation = Quaternion.Euler(Vector3.Lerp(CurrentRotation, DayTimePosition,t));
        }
else
        {
            transform.rotation = Quaternion.Euler(Vector3.Lerp(CurrentRotation, NightTimePosition, t));

        }
    }
public void DayCycle ()
    {
      
        
      
      CurrentRotation = new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z);
      DayNightCycle = true;
        t = 0;
    }
    public void NightCycle()
    {
        

      
        CurrentRotation = new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z);
        DayNightCycle = false;
        t = 0;
    }


}

