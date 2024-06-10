using TMPro;
using UnityEngine;
using System.Collections;

public class CoinMovement : MonoBehaviour
{
    public Transform coin;
    public float rotationSpeed = 100;
    public GameObject dimond;
    public TextMeshProUGUI scorePoint;
    public score changeScore;
    

    void Start()
    {
        transform.localEulerAngles = new Vector3(0, 90, 0);
    }
    void Update()
    {
        coin.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.Self);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("one coin added");
        dimond.SetActive(false);
        changeScore.addScore();
        //add score
        //add sound
        //delete
        
    }
}
