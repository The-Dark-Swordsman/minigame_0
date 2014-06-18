using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

void Start () 
    {

        GUI.Box(new Rect(460,100,300,140), "Collect Them Balls!");
    
        GUI.Button(new Rect(570,160,80,20), "Start");
    }
}