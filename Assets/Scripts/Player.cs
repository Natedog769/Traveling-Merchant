using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public string playerName = "";
    public Location currentLocation;
    public List<Location> newLocationList;



    void Start()
    {
        gameObject.transform.position = currentLocation.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        newLocationList.AddRange(currentLocation.nextLocationsToTravelTo);

        

    }


    void MovePlayer()
    {



    }


}
