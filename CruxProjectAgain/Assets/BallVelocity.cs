using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class BallVelocity : MonoBehaviour
{
    Rigidbody2D rb;
    public Collider2D[] objects;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    objects = new Collider2D[5];
        //    objects = Physics2D.OverlapCircleAll(transform.position, 1f, 3);
            
        //    if (objects.Length > 0)
        //    {
        //        objects = objects.OrderBy((d) => (d.transform.position - transform.position).sqrMagnitude).ToArray();
        //        rb.AddForce(-(objects[0].transform.position - transform.position).normalized * 1000f * Time.deltaTime, ForceMode2D.Impulse);
                
        //    }
        //    else
        //    {
        //        Debug.Log("NO STICK NEAR");
        //    }
            
        //}
    }
}
