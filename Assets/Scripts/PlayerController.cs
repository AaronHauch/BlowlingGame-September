using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool wasThrown;
    [SerializeField] private float throwStrength;
    [SerializeField] private Rigidbody myRigidbody;
    [SerializeField] private GameObject aimingArrow;

    // Start is called before the first frame update
    void Start()
    {
          
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime, 0, 0);
    
        if (Input.GetKeyDown(KeyCode.Space) && wasThrown == false)
        {
            aimingArrow.SetActive(false);
            wasThrown = true;
            myRigidbody.AddForce(aimingArrow.transform.forward * throwStrength, ForceMode.Impulse);
        }
        
            
    }
}
