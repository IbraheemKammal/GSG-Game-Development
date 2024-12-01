using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public string playerName;
    public int health;
    public void InitializePlayer(string name, int initialHealth)
    {
        this.playerName = name;
        this.health = initialHealth;
        playerCount++;
    }
    public void Heal(int amount)
    {
        
        health += amount;
        if (health > 100) health = 100;
        Debug.Log($"{this.playerName} had been healed by {amount}.");
    }
    public void Heal(bool fullRestor)
    {
        if (fullRestor) health = 100;
        Debug.Log($"{this.playerName} health had been fully restored .");
    }
    public static int playerCount = 0;
    public static void ShowPlayerCount()
    {
        Debug.Log("Current Players: " + playerCount);
    }

}
