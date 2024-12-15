using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicatorController : MonoBehaviour
{
    public Vector3 scaleModifier;
    public float scaleSpeed = 1f;
    Vector3 normalScale, maxScale;
    bool startScallingUp, startScallingDown;
    void Awake()
    {
        normalScale = transform.localScale;
        maxScale = normalScale + scaleModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (startScallingUp)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, maxScale, Time.deltaTime * scaleSpeed);
            if (transform.localScale.magnitude >= maxScale.magnitude - 0.05f)
            {
                startScallingUp = false;
            }
        }
        if (!startScallingUp)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, normalScale, Time.deltaTime * scaleSpeed);
            if (transform.localScale.magnitude <= normalScale.magnitude + 0.05f)
            {
                startScallingUp = true;
            }
        }
    }

    private void OnEnable()
    {
        startScallingUp = true;
    }
    private void OnDisable()
    {
        transform.localScale = normalScale;
        startScallingUp = false;
    }
}
