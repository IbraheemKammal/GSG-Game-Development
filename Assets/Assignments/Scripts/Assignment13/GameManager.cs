using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player.ShowPlayerCount();

        Player ibraheem = new Player();
        ibraheem.InitializePlayer("Ibraheem", 15);
        Debug.Log("Ibraheem Health: " + ibraheem.health);

        ibraheem.Heal(20);
        Debug.Log("Ibraheem Health: " + ibraheem.health);
        Player.ShowPlayerCount();

        Player mohammed = new Player();
        mohammed.InitializePlayer("mohamed", 40);
        Debug.Log("Mohammed Health: " + mohammed.health);
        mohammed.Heal(true);
        Debug.Log("Mohammed Health: " + mohammed.health);


        Player.ShowPlayerCount();
    }


}
