using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location : MonoBehaviour
{
    public string thisLocationName;

    public Location[] nextLocationsToTravelTo;
    [Range(1,5)]
    public int locationPowerFactor;
    public Faction currentlyOccupiedBy;

    public MilitaryLeader militaryRuler;

    public LocalSupplier marketCharacter;

    public TownFolk infoSpeakers;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
