using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RoomInitializerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject roomPrefab;
    public GameObject GridInitilaizer;
    public GameObject[,] squares;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InitializeRoom();
    }
    public int InitializeRoom(){
        if (Input.GetMouseButtonDown(0))
        {
            // Convert mouse position from screen space to world space
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0; // Ensure the object is spawned at z = 0 (or your desired z position)
        // Round the x and y coordinates to the nearest integer
            int roundedX = Mathf.RoundToInt(mousePosition.x);
            int roundedY = Mathf.RoundToInt(mousePosition.y);
            GridInitilaizerScript gridInitilaizerScript = GridInitilaizer.GetComponent<GridInitilaizerScript>();
            GameObject square;
            for(int i = roundedX -5; i <= roundedX+5; i++){
                for(int j = roundedY -2; j <= roundedY+2; j++){
                    try
                    {
                    if(gridInitilaizerScript.returnSquare(i,j)!= null){
                    square = gridInitilaizerScript.returnSquare(i,j);
                    if (square.GetComponent<squareScript>().ReturnIsEmpty())
                        {
                            continue;
                        }
                        else{
                            Debug.Log("i cant do that");
                            return 0;
                        }
                    }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        return 0;
                    }

                }
                }
            
            // Create a new Vector3 with rounded x and y coordinates
            Vector3 roundedMousePosition = new Vector3(roundedX, roundedY, 0);
            
            // Instantiate the object at the rounded mouse position
            Instantiate(roomPrefab, roundedMousePosition, Quaternion.identity);
            for(int i = roundedX -5; i <= roundedX+5; i++){
                for(int j = roundedY -2; j <= roundedY+2; j++){
                    if(gridInitilaizerScript.returnSquare(i,j)!= null){
                    square = gridInitilaizerScript.returnSquare(i,j);
                    square.GetComponent<squareScript>().ChangeIsEmpty();
                    }
                }
            }
            return 1;      
        }
        return 0;
    }
}
