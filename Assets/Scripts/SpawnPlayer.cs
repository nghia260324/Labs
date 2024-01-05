using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class SpawnPlayer : MonoBehaviour
{
    public Image die;
    public GameObject posRespawn;
    public GameObject player;

    private void RespawnPlayer()
    {
        GameObject newPlayer = GameObject.Instantiate(player, posRespawn.transform);
        newPlayer.name = "Player";
        die.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (die.enabled && Input.GetMouseButtonUp(0))
        {
            RespawnPlayer();
        }
    }
}
