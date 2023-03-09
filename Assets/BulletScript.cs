using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Vector3 mousepos;
    private Camera mainCam;
    private Rigidbody2D rb;
    public float force;
    private float timer;
    public float timeBeforeDepop;
    // Start is called before the first frame update
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        rb = GetComponent<Rigidbody2D>();
        mousepos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousepos - transform.position;
        Vector3 rotation = transform.position - mousepos;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;
        float rot = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot + 90);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeBeforeDepop)
        {
            Destroy(this.gameObject);
            timer = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy = collision.collider.GetComponent<GettingHit>();
        if (enemy)
            enemy.TakeHits(1);
        Destroy(gameObject);
    }
}
