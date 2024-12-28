using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookHandler : MonoBehaviour
{
    public bool isBookHeld, isBookOpened, isBookClosed;
    private int currentPageNumber = 0;
    public void Awake()
    {

    }






    /*
    first the house will have 3 states 
    * 1- first we will have the house with there normal transform (position and rotation and scale ) .
    2- second the house parts will have the same scale and position of a some points in the book . 
    3- the house parts will scale and rotated and move based on the book state .
    */
    /*
    the book will have different states .
1- book will be closed and held . 
2- pages will contain the following :- 
    -page1 will have an introduction .
    -page2 will have the walls . 
    -page3 will have the windows and door .
    -page4 will have roof . 
    - then book will close.


 opening book stages , 
 1- stage 1 book will open to the first page , where there is an introduction .
 2- stage 2 book will open to the next page , during this the page content will scale and move up from thier relative points . 
3- stage 3 page content will go to thier initial position and rotation and scale in the scene .
4- stage 4 book will go to next page and similar behaviour will happen .
5- same as stage 3 .
6- same as stage 5 .



    */
}