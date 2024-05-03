using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    private bool isDie;
    
    public Slider hpBar;

    public float maxHp;
    public float curHp;
    public float decreaseSpeed;

    void Start()
    {
        isDie = GameObject.Find("Player").GetComponent<PlayerMovement>().isDie;

        curHp = maxHp;
    }

    void Update()
    {
        if (!isDie)
        {
            if (curHp < 0f)
            {
                curHp = 0f;
                return;
            }

            curHp -= decreaseSpeed * Time.deltaTime;
            hpBar.value = Mathf.Lerp(hpBar.value, curHp / maxHp, Time.deltaTime * decreaseSpeed);
        }
    }
}
