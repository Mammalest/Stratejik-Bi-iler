using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class GridInitilaizerScript : MonoBehaviour
{
    [SerializeField] private int numberOfSquaresinX;
    [SerializeField] private int numberOfSquaresinY;
    private GameObject[,] squares;
    public GameObject squarePrefab;
    // Start is called before the first frame update
void Start()
{
    Debug.Log("Start method called."); // Check if Start() is called
    // Initialize the array to hold game objects
    squares = new GameObject[numberOfSquaresinX , numberOfSquaresinY];

    // Check the array dimensions
    Debug.Log("Array dimensions: " + numberOfSquaresinX + " x " + numberOfSquaresinY);

    // Create the grid of squares
    for (int i = 0; i < numberOfSquaresinX; i++)
    {
        for (int j = 0; j < numberOfSquaresinY; j++)
        {
            // Instantiate the square prefab at the appropriate position
            squares[i, j] = Instantiate(squarePrefab, new Vector3(i, j, 0), Quaternion.identity);
        }
    }
    Debug.Log("Grid creation complete."); // Log when grid creation is finished
}

    // Update is called once per frame
    void Update()
    {

    }
    public GameObject returnSquare(int x, int y){
        if(squares[x,y] != null){
        return squares[x,y];
        }
        else{
            return null;
        }
    }
}
