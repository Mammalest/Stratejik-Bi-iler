using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class squareScript : MonoBehaviour
{
    public bool isEmpty = true;
    // Start is called before the first frame update
    public bool ReturnIsEmpty(){
        return isEmpty;
    }
    public void ChangeIsEmpty(){
        isEmpty = !isEmpty;
    }
}
