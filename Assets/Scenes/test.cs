using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test : MonoBehaviour
{
    public int number = 0;
    private float span = 1;
    IEnumerator Logging(){
        while (true) {
            yield return new WaitForSeconds (span);
            Debug.LogFormat ("{0}秒経過", span);
        }}
    void Start()
    {
        Debug.Log("開始");
        StartCoroutine ("Logging");
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("衝突");
        number++;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("through");
        number++;
    }
}
