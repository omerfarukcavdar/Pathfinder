using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptDetector : MonoBehaviour {

    public GameObject[] detector = new GameObject[2];
    bool[] isInSightMultiple = new bool[2];
 
    //This function help to detect all enemies isInSight variables value. 
    public bool isInSightFunction()
    {
        
            for (int i = 0; i < detector.Length; i++)
            {
                isInSightMultiple[i] = detector[i].GetComponent<AiSight>().isInSight;
            }

            for (int i = 0; i < isInSightMultiple.Length; i++)
            {
                if (isInSightMultiple[i])
                    return true;
            }
            return false;
        
        
    }
    // Update is called once per frame
        void Update () 
            {
            
            isInSightFunction();
        }

    }

