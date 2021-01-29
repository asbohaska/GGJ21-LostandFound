using System.Collections;
using System.Collections.Generic;
using UnityEngine;

   public class Spawnspots : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        GameObject theSpawn;

        do  // checks an error
        {
            getSpawn(gameObject); // grabs random spawn
            theSpawn = getSpawn(gameObject);
        } while (theSpawn == gameObject);

        player.transform.position = theSpawn.transform.position; // changes players position
    }

    private GameObject getSpawn(GameObject spawn)
    {
        Transform[] childs; // spawn list childs transform
        GameObject randomSpawn; // random spawn game object

        childs = (Transform[])spawn.GetComponentsInChildren<Transform>(); // gets transform of spawnPositions children
        randomSpawn = (GameObject)((Transform)childs[Random.Range(0, childs.Length)]).gameObject; // randomly picks a childs transform

        return randomSpawn;
    }
}