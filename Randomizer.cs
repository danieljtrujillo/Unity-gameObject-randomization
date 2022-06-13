using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizer : MonoBehaviour
{
    public GameObject[] itemsToPickFrom;
    // Randomly select a numbered object from a parent array of GameObjects
    void Start()
    {
        int randomIndex = Random.Range(0, itemsToPickFrom.Length);
        itemsToPickFrom[randomIndex].SetActive(true);
        //Pick();
    }

    // Call this from a button (or another script) to deactivate all active objects in the array and randomize and activate a new object
    public void Pick()
    {
        foreach (GameObject visible in itemsToPickFrom)
        {
            visible.SetActive(false);
        }
        int randomIndex = Random.Range(0, itemsToPickFrom.Length);
        itemsToPickFrom[randomIndex].SetActive(true);

    }

}
