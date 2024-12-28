using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public abstract class Transformer
{
    private float _duration;
    protected float tolerance, counter = 0f;
    public float Duration
    {
        get { return _duration; }
        set
        {
            if (value < 0) _duration = value * -1f;
            else _duration = value;
        }
    }
    public bool hasStarted, hasFinished;
    protected Transform transformedObject;


    public Transformer(Transform transformedObject, float duration = 1f)
    {
        hasStarted = hasFinished = false;
        Duration = duration;
        this.transformedObject = transformedObject;
        tolerance = 0.01f;
    }
    public abstract void StartTransforming();
    protected void StartCounter()
    {

        counter += Time.deltaTime;
        if (counter > Duration)
        {
            hasFinished = true;
        }
    }

}







public class Rotator : Transformer
{
    Vector3 initialRotation, endRotation;
    public Space relativeTo;
    public Rotator(Transform transformedObject, Vector3 newRotation, float rotationTime, Space relativeTo) : base(transformedObject, rotationTime)
    {
        endRotation = newRotation;
        this.initialRotation = transformedObject.eulerAngles;
        this.relativeTo = relativeTo;
    }

    public override void StartTransforming()
    {
        hasStarted = true;
        StartCounter();

        Vector3 newRotation = endRotation * Time.deltaTime / Duration;
        if (!hasFinished) transformedObject.Rotate(newRotation, relativeTo);
        else transformedObject.rotation = Quaternion.Euler(initialRotation + endRotation);

    }
    public void StartLerping()
    {

    }
    public void SetRotations(Vector3 initial, Vector3 end)
    {

        initialRotation = initial;
        endRotation = end;
    }

}








public class Transitionar : Transformer
{
    Vector3 initialPosition, newPosition;
    public Space relativeTo;

    public Transitionar(Transform transformedObject, Vector3 newPosition, float transitionTime, Space relativeTo) : base(transformedObject, transitionTime)
    {
        initialPosition = transformedObject.position;
        this.newPosition = newPosition;
        this.relativeTo = relativeTo;
    }
    public override void StartTransforming()
    {
        hasStarted = true;
        StartCounter();
        Vector3 currentPosition = transformedObject.position;
        Vector3 transition = newPosition * Time.deltaTime / Duration;
        if (!hasFinished) transformedObject.Translate(transition, relativeTo);



    }

}





public class Scaler : Transformer
{
    Vector3 initialScale, newScale;
    public Scaler(Transform transformedObject, Vector3 newScale, float scaleTime) : base(transformedObject, scaleTime)
    {

        initialScale = transformedObject.localScale;
        this.newScale = newScale;
    }
    public override void StartTransforming()
    {
        hasStarted = true;
        StartCounter();
        Vector3 scaling = newScale * Time.deltaTime / Duration;
        if (!hasFinished) transformedObject.localScale += scaling;
        else transformedObject.localScale = initialScale + newScale;


    }

}
