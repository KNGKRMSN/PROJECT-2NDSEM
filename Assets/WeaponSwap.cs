using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwap : MonoBehaviour
{
    public Color weapon1Color;
    public Color weapon2Color;
    private SpriteRenderer rend;
    private float timer2;
    public float timeBeforeWeaponSwap;
    public Shooting Sh;
    public bool weapon1 = true;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        rend.color = weapon1Color;
    }

    // Update is called once per frame
    void Update()
    {
        timer2 += Time.deltaTime;
        if (timer2 > timeBeforeWeaponSwap && rend.color == weapon1Color)
        {
            weapon1 = false;
            timer2 = 0;
            gameObject.transform.localScale = new Vector3(0.8f, 0.1f, 1);
            rend.color = weapon2Color;
            Sh.timeBetweenShots = 0.1f;
        }
        if (timer2 > timeBeforeWeaponSwap && rend.color == weapon2Color)
        {
            weapon1 = true;
            timer2 = 0;
            gameObject.transform.localScale = new Vector3(0.2f, 0.1f, 1);
            rend.color = weapon1Color;
            Sh.timeBetweenShots = 0.4f;
        }
    }
}
