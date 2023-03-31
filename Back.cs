using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour
{
    public GameObject Back__;
    private Animator anim;
    public void Back_()
    {
        Back__.SetActive(true);
        StartCoroutine(ghg());
        anim = Back__.GetComponent<Animator>();
        anim.enabled = false;
        gameObject.SetActive(false);
    }
    private IEnumerator ghg()
    {
        yield return new WaitForSeconds(1f);
    }
}
