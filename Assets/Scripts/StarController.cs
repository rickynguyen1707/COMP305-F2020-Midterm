using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour
{
    [SerializeField] private float shootForce = 300f;
    [SerializeField] private float destroyTimer = 1.0f;
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(0.0f, shootForce));
    }

    private void Update()
    {
        Object.Destroy(gameObject, destroyTimer);
    }
}
