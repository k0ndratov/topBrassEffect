using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningThorn : MonoBehaviour
{
    [SerializeField] private GameObject gameObject;
    [SerializeField] private Hero hero;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, -1.5f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            hero.Die();
        }
    }
}
