using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Path : MonoBehaviour
{
    public GameObject PathSection;
    public Transform SpawnPosition;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Path Trigger"))
        {
            GameObject newSection = Instantiate(PathSection, SpawnPosition.position, Quaternion.identity);
            SpawnPosition = newSection.transform.Find("SpawnPoint");
        }
    }
}
