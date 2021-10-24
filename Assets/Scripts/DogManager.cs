using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogManager : MonoBehaviour
{
    public GameObject dogHouse;
    
    
    public void DogController()
    {
        dogHouse.GetComponent<DogHouseManager>().bottleIsTrue();
    }

}
