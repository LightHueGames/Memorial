using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleIgnite : MonoBehaviour
{
    [SerializeField] GameObject SelectedCandle;
    [SerializeField] ParticleSystem CandleInitVFX;
    [SerializeField] ParticleSystem CandleVFX;
    public bool isON;
    RaycastHit hit;
    public void IgniteSelectedCandle()
    {
        SelectedCandle.GetComponentInChildren<ParticleSystem>().Play();

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(isON == false)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                IgniteSelectedCandle();
                isON = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
       
       
    }
}
