using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZoneActivator : MonoBehaviour
{
    public GameObject spawnPillar;
    // Start is called before the first frame update
    
    //Intent of this script is to reveal a spawnpillar - See SpawnPillar.CS upon the player/anything colliding with a platform.
    // place this script on a gameobject with a collider, with a child object with the spawnpillar.cs script on it.
    void Start()
    {
        spawnPillar = gameObject.transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Player"))
        {
            spawnPillar.SetActive(true);
            
        }
    }
}
