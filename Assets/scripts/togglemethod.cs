using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class togglecnrt : MonoBehaviour
{ 
    public GameObject jetcomponent;
    private  bool isVisible = true;

    public void Toggle ()
    {
        if(isVisible)
        {
            jetcomponent.SetActive(false);
            isVisible = false;
        } 
        else
        {
          jetcomponent.SetActive(true);
            isVisible = true;
        }
    }  
}
