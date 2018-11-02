using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScript : MonoBehaviour
{
    public List<Vector2> teleportLocations = new List<Vector2>();
    public GameObject player;

    public void OnClickTeleport()
    {
        player.transform.position = teleportLocations[Random.Range(0, teleportLocations.Count)];
    }
}
