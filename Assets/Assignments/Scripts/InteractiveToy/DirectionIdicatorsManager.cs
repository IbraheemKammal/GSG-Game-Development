using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionIdicatorsController : MonoBehaviour
{
    public GameObject leftIndicator, rightIndicator, upIndicator, downIndicator;

    public LetterPart[] letterParts;
    LetterPart currentPart;
    int letterPartIndex = 0;
    string currentDirectionIndicator;

    void Awake()
    {
        leftIndicator.SetActive(false);
        rightIndicator.SetActive(false);
        upIndicator.SetActive(false);
        downIndicator.SetActive(false);

        currentPart = letterParts[letterPartIndex];
        ActivateDirectionIdicator(currentPart.scallingDirection);
    }

    void Update()
    {


        string inputDirection = CheckInputDirection();

        if (currentPart.scallingDirection == inputDirection)
        {
            currentPart.gameObject.SetActive(true);
            if (letterPartIndex < letterParts.Length - 1) letterPartIndex++;
            currentPart = letterParts[letterPartIndex];
            ActivateDirectionIdicator(currentPart.scallingDirection);
            currentDirectionIndicator = currentPart.scallingDirection;
        }




    }


    public void ActivateDirectionIdicator(string direction)
    {
        string lowerCaseDirection = direction.ToLower();
        if (lowerCaseDirection == currentDirectionIndicator) return;
        switch (lowerCaseDirection)
        {
            case "left":
                DeactivateAllDirections();
                leftIndicator.SetActive(true);
                break;

            case "right":
                DeactivateAllDirections();
                rightIndicator.SetActive(true);
                break;

            case "up":
                DeactivateAllDirections();
                upIndicator.SetActive(true);
                break;

            case "down":
                DeactivateAllDirections();
                downIndicator.SetActive(true);
                break;
        }

    }
    void DeactivateAllDirections()
    {
        leftIndicator.SetActive(false);
        rightIndicator.SetActive(false);
        upIndicator.SetActive(false);
        downIndicator.SetActive(false);
    }

    string CheckInputDirection()
    {
        string ChosenDirection = "";
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ChosenDirection = "left";
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ChosenDirection = "right";
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ChosenDirection = "up";
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            ChosenDirection = "down";
        }

        return ChosenDirection;

    }
}




