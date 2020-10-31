using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    [SerializeField] private GameObject star;
    [SerializeField] private Transform spawn;
    [SerializeField] private float respawnTime = 60.0f;

    private Animator anim;
    private bool isOpen = false;
    private bool isEPressed = false;

    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            isEPressed = true;
        }
    }
    void OnTriggerStay2D(Collider2D chest)
    {
            if (chest.CompareTag("Player") && isEPressed)
            {
                OpenChest();
            }
        }
    private void OpenChest()
    {
        isOpen = true;
        anim.SetBool("isOpen", isOpen);
        StartCoroutine(starWave());
    }

    private void spawnStar()
    {
        Instantiate(star, spawn.position, spawn.rotation); 
    }

    IEnumerator starWave()
    {
        while(isOpen)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnStar();
        }
    }
}
