using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Town : Location
{



    [Range(1, 5)]
    public int locationPowerFactor;
    public Faction currentlyOccupiedBy;

    public MilitaryLeader militaryRuler;

    public LocalSupplier marketCharacter;

    public TownFolk infoSpeakers;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void VisitMilitary()
    {

    }

    void VisitMarket()
    {

    }

    void VisitTavern()
    {

    }


}
