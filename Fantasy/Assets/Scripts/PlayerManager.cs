using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static public class PlayerManager
{
    static private int playerHealth; 

    static private int GetPlayerHealth()
    {
        return playerHealth;
    }

    static private void SetPlayerHealth(int i)
    {
        playerHealth = i;
    }

 
}
