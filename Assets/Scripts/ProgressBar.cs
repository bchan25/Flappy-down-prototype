using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    // The Progress Bar
    public Slider progressBar;
    // The Finish Line but this moves
    public Transform finishLine;

    // Distance from the start
    float distance;
    // Hold the distance travel of the finish line
    float distanceTravelled = 0;
    // store the recent position of the finish line
    Vector3 lastPos;

    
    void Start()
    {
        // Get the values at the start
        distance = Vector3.Distance(transform.position, finishLine.position);
        lastPos = finishLine.position;

    }

    // Update is called once per frame
    void Update()
    {
        // Update the distance travel
        distanceTravelled += Vector3.Distance(finishLine.position, lastPos);
        lastPos = finishLine.position;

     
        // Update the progress bar * 1 give value 0 to 1
        progressBar.value = (distanceTravelled / distance) * 1;

       
    }
}
