using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

    public GameObject Game;
    public GameObject Back1;
    private Animator anim;
    private void Start()
    {
        anim = Back1.GetComponent<Animator>();
        anim.enabled = false;
    }
    private IEnumerator _anim()
    {

        anim.enabled = true;
        yield return new WaitForSeconds(1.5f);
        Game.SetActive(true);
        gameObject.SetActive(false);
    }

    public void Ami()
    {
        StartCoroutine(_anim());
    }
}
