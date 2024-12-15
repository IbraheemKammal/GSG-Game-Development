using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterPart : MonoBehaviour
{
    public string scallingDirection;
    public int scalingOrder, scallingSpeed = 5;
    public float colorLerpingSpeed = 0.0075f;
    Vector3 initialScale, currentScale;
    Material letterMaterial;
    Color color, maxColorValue;

    float yScale;

    void Awake()
    {
        letterMaterial = GetComponentInChildren<Renderer>().material;
        color = letterMaterial.color;
        maxColorValue = color; maxColorValue.g = 254;
        initialScale = currentScale = transform.localScale;
        currentScale.y = yScale = 0;
        transform.localScale = currentScale;
        gameObject.SetActive(false);

    }

    void Update()
    {
        StartScalling();
        StartColorLerp();
    }

    void StartScalling()
    {
        yScale = Mathf.Lerp(yScale, initialScale.y, Time.deltaTime * scallingSpeed);
        currentScale.y = yScale;
        transform.localScale = currentScale;

        if (transform.localScale.y >= initialScale.y - .005f) transform.localScale = initialScale;

    }

    void StartColorLerp()
    {
        color = Color.Lerp(color, maxColorValue, Time.deltaTime * colorLerpingSpeed);
        letterMaterial.color = color;
    }
}
