using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds all the logic for our levelling system, so that includes logic to handle levelling up, gaining xp and detecting when we should level up!.
/// </summary>
public class LevellingSystem : MonoBehaviour
{
    public int curretLevel; // Our current level.

    public int currentXp; // The current amount of xp we have accumulated.

    public int currentXPThreshold = 10; // The amount of xp required to level up.

    private void Start()
    {
        // set our current level to one.
        int curretLevel = 1;
        // set our current XP to zero
        int currentXp = 0;
        // set our current XP Threshold to be our level multiplied by our 100.
        int currentXPThreshold = curretLevel * 100;
        // Debug out our starting values of our level, xp and current xp threshold
        Debug.Log("Level "+curretLevel);
        Debug.Log(currentXp+" Exp");
        Debug.Log("Current Exp Threshold "+currentXPThreshold);

        // Increase the current XP by one hundred.
        int NewXp = currentXp + 100;

        // Debug out our current XP.
        Debug.Log("Exp Increased by " + NewXp);
        // check if our current XP is more than our threshold.
        if( (NewXp > currentXp) == true)
        {
            Debug.Log("Current XP is more than our threshold");
        }
        else
        {
            Debug.Log("Current XP is less than our threshold");
        }
        // if it is, then let's increase out level by one.
        if ((NewXp > currentXp) == true)
        {
            Debug.Log("Level Incresed to Level " + (curretLevel= curretLevel + 1));
        }
        // let's also increase recalculate our current xp threshold as we've levelled up.
        int NewcurrentXPThreshold = curretLevel * 100;
            Debug.Log("Current Exp Threshold " + NewcurrentXPThreshold);
        // Debug out our new level value, as well as our current XP and our next Threshold we need to hit.
        Debug.Log("Level " + curretLevel);
        Debug.Log(NewXp + " Exp");
        Debug.Log("Current Exp Threshold " + NewcurrentXPThreshold);
    }
}
