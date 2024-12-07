using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Collumn : MonoBehaviour
{
    public float bottomBound, upperBound;
    public bool startMovment, moveUp;

    [HideInInspector()]
    public float speed, currentYPosition;
    Vector3 nextPosition;
    private void Start()
    {
        nextPosition = transform.position;
        moveUp = true;
    }

    private void Update()
    {
        currentYPosition = transform.position.y;
        if (startMovment)
        {
            Move();
        }
        if ((moveUp && currentYPosition >= upperBound)
        || (!moveUp && currentYPosition <= bottomBound))
        {
            ChangeMovementDirection();
        }


    }
    void Move()
    {

        if (moveUp)
        {
            nextPosition.y = currentYPosition + (speed * Time.deltaTime);
        }
        else
        {
            nextPosition.y = currentYPosition - (speed * Time.deltaTime);
        }
        transform.position = nextPosition;
    }
    void ChangeMovementDirection()
    {
        moveUp = !moveUp;
    }

}
