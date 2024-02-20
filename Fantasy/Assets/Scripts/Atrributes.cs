using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atrributes : MonoBehaviour
{
    public int health;
    public int stamina;
    public int strenght; 
   
    public int GetHealth()
    {
        return health;
    }

    public void SubtractHealth(int dmg)
    {
        health -= dmg;
    }
}
