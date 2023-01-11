using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collect : MonoBehaviour
{
    public string target = "Player";
    public bool easter = false;
    private int seta = 0;
  
    // Update is called once per frame
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == target)
            {
                collision.gameObject.SetActive(false);
                seta++;
            }
        }
    private void Update()
    {
        if (seta==2) 
        {
            easter = true;
        }
    }

}
