using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assignment10 : MonoBehaviour
{
    // Start is called before the first frame update
   void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            // Call Multiply function and log the result
            Debug.Log(i + " x 5 = " + Multiply(i, 5));
        }
    }

    // Multiply function inside the class
    int Multiply(int x, int y) => x * y;
}
