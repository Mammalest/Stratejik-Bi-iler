using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmRoom : Room
{
    public FarmRoom(){
        roomID = 0;
        roomWidth = 11;
        roomHeight = 5;
        MaxWorker = 4;
        peopleWorking = 0;
    }
    void Awake(){
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
