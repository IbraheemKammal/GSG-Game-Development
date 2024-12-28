using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraDirector : MonoBehaviour
{
    public Transform target;
    public float rotationSpeed = 1f;
    float counter = 0f;
    Quaternion initialRotation;
    void Start()
    {
        initialRotation = transform.rotation;
    }

    void LateUpdate()
    {
        if (target != null)
        {
            counter += Time.deltaTime;
            counter = Mathf.Clamp(counter, 0f, rotationSpeed);
            initialRotation = transform.rotation;
            Vector3 direction = target.position - transform.position;
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(initialRotation, targetRotation, counter / rotationSpeed);
        }

    }

    public void SetTarget(Transform target, float rotationSpeed)
    {
        counter = 0f;
        this.target = target;

    }
}


