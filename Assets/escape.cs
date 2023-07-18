using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escape : MonoBehaviour
{
  public Controller controller;
  
    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Escape)&&controller.gravity != 0) 
        {
            
            Application.Quit();
            Debug.Log("rg");
        }
    }

    
}
