using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ASSIGNMENT8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*1. Write a C# script that generates random numbers (from 1 to 20) using a while loop.
2. Print each number. If the number is 5, use continue to skip printing it.
3. If the number is 15, use break to exit the loop.*/
    void Start()
    {
       
       
       /* while(true)
        {
            int randomnum = Random.Range(1,20);
            Debug.Log(randomnum);
            if(randomnum ==5)
            {
                 continue; 
            }
          
           if(randomnum ==15)
            {
                 break; 
            }
        }*/
  /*Write a C# script that uses an array of these words:
Cat, Dog, Car, Pizza, Hat, Fish, Tree, Monkey, Ball, Bird.
2. Use a while loop to build a funny sentence with 7 words randomly chosen from the
array.
3. Print the sentence to the console.*/
         string[] arr = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        int counter = 0;
        string sentence = "";

        while (counter < 7)
        {
            sentence += arr[Random.Range(0, arr.Length)] + " ";
            counter++;
        }

        Debug.Log("Funny Sentence: " + sentence.Trim());
    }
    }

    
  
    }

  

