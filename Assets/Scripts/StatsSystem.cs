using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds all the logic for our stats system, so that includes logic to handle generating starting physical stats
/// calculating our dancing stats based on physical stats and our stat multipliers.
/// </summary>
public class StatsSystem : MonoBehaviour
{
    /// Our physical stats that determine our dancing stats.
    public int agility;
    public int intelligence;
    public int strength;

    // Our variables used to determine our fighting power.
    public int style;
    public int luck;
    public int rhythm;

    private void Start()
    {
        // set out agility, strength and intelligence to a random number between zero and ten.
        // BONUS! let's try taking our stats away from a pool of stats, i.e. 20 total, distributing this amoungst all the stats.
        int totalpool = 20;
        
        strength = Random.Range(0, 10);
        totalpool = totalpool - strength; 
        agility = Random.Range(0, 10);
        totalpool = totalpool - agility;
        intelligence = Random.Range(0, 10);
        intelligence = totalpool;

        // Debug out your current physical stat values (strength, agility, intelligence).
        Debug.Log("strength = " + strength);
        Debug.Log("agility = " + agility);
        Debug.Log("intelligence = " + intelligence);
        // let's create some float temporary variables to hold our multiplier values.
        
        // create an agility multiplier should be set to 0.5
        float AGI =  0.5f;
        // create a strength multiplier should be set to 1
        float STR =  1;
        // create an intelligence multiplier should be set to 2.
        float INT =  2;
        // Debug out our current multiplier values.
        Debug.Log("AGI = "+AGI);
        Debug.Log("STR = "+STR);
        Debug.Log("INT = "+INT);
        // now that we have some stats and our multiplier values let's calculate our style, luck and ryhtmn based on these values.

        // style should be based off our strength and be converted at a rate of 1 : 1.
        float style = STR*strength;
        // luck should be based off our intelligence and be converted at a rate of 1 : 1.5f
        float luck = (INT * intelligence) / 1.5f;
        // rhythm should be based off our agility and be converted at a rate of 1 : 0.5.
        float rhythm = (AGI* intelligence) / 0.5f;
        // Debug out our current dancing stat values (style, luck, rhythm)
        Debug.Log("Style = " + style);
        Debug.Log("Luck = " + luck);
        Debug.Log("Rhythm = " + rhythm);
        // now let's imagine that our level has increased; and we've been granted 10 new stat points.
        // let's distribute those stats amoungst our strength and agility and intelligence.
        int additionalPoints = 10;

        int strengthUp = Random.Range(0, 6);
        strength += strengthUp;
        additionalPoints = additionalPoints - strengthUp;
        int agilityUp = Random.Range(0, 6);
        agility += agilityUp;
        additionalPoints = additionalPoints - agilityUp;
        intelligence += additionalPoints;

        // Debug out our new physical stat values
        Debug.Log(strength);
        Debug.Log(agility);
        Debug.Log(intelligence);

        // let's recalculate our style, luck and rhytmn as our initial stats have changed.
        float styleUP = style + (STR * strength);
        float luckUP = luck + ((INT * intelligence) / 1.5f);
        float rhythmUP = rhythm + ((AGI * agility) / .5f);
        // Debug out our new dancing stat values
        Debug.Log("Style = " + styleUP);
        Debug.Log("Luck = " + luckUP);
        Debug.Log("Rhythm = " + rhythmUP);
    }
}
