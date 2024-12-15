using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SculptureController : MonoBehaviour
{

    public float nextCollumnTriggerPoint = 2, movemenetSpeed = 10f;


    public Collumn[] collumns;
    Collumn currentCollumn;
    int nextCollumnIndex;
    void Awake()
    {
        foreach (Collumn collumn in collumns)
        {
            collumn.speed = movemenetSpeed;
        }
    }

    void Start()
    {
        ChangeCurrentCollumn();
    }

    void Update()
    {
        if (collumns != null)
        {
            startWaveBehaviour();
        }

        Debug.Log(nextCollumnIndex);
    }


    void startWaveBehaviour()
    {
        if (nextCollumnIndex < collumns.Length)
            if (currentCollumn.currentYPosition >= nextCollumnTriggerPoint)
            {
                ChangeCurrentCollumn();
            }
    }

    void ChangeCurrentCollumn()
    {
        currentCollumn = collumns[nextCollumnIndex];
        currentCollumn.startMovment = true;
        nextCollumnIndex++;
    }


}
