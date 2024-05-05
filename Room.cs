using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Room : MonoBehaviour
{
    protected int roomID;
    protected int roomWidth;
    protected int roomHeight;
    protected int peopleWorking;
    protected int MaxWorker; 
    protected  Room[] rooms = new Room[100];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
