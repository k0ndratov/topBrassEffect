using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] private GameObject teleportTo;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.position = teleportTo.transform.position;
    }
}
