using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint1 : MonoBehaviour
{
    
    public GameObject climb1;
    public GameObject proneArms2;
    public GameObject anxiety3;
    public GameObject tinSoldier4;
    public GameObject pushUpPlus5;
    public GameObject depression6;
    public GameObject isotonicScaption7;
    public GameObject pronePressUps8;
    public GameObject healing9;

    public GameObject Trigger1;
    public GameObject Trigger2;
    public GameObject Trigger3;
    public GameObject Trigger4;
    public GameObject Trigger5;
    public GameObject Trigger6;
    public GameObject Trigger7;
    public GameObject Trigger8;
    public GameObject Trigger9;

    public GameObject checkpointLocation1;
    public GameObject checkpointLocation2;
    public GameObject checkpointLocation3;
    public GameObject checkpointLocation4;
    public GameObject checkpointLocation5;
    public GameObject checkpointLocation6;
    public GameObject checkpointLocation7;
    public GameObject checkpointLocation8;
    public GameObject checkpointLocation9;

    public Transform checkpointLocation;
    public float fallHeight;
    public GameObject player;

    void Update()
    {
        if (player.transform.position.y < fallHeight)
            player.transform.position = checkpointLocation.position;
    }

    void OnTriggerEnter(Collider other)
    { 

        if (other.gameObject.tag == "climb")
        {
            Trigger1.SetActive(false);
            climb1.SetActive(true);
            checkpointLocation1.transform.position = checkpointLocation.position;
        }


        if (other.gameObject.tag == "proneArms")
        {
            Trigger2.SetActive(false);
            proneArms2.SetActive(true);
            checkpointLocation2.transform.position = checkpointLocation.position;
        }
        if (other.gameObject.tag == "anxiety")
        {
            Trigger3.SetActive(false);
            anxiety3.SetActive(true);
            checkpointLocation3.transform.position = checkpointLocation.position;
        }
        if (other.gameObject.tag == "tinSoldier")
        {
            Trigger4.SetActive(false);
            tinSoldier4.SetActive(true);
            checkpointLocation4.transform.position = checkpointLocation.position;
        }
        if (other.gameObject.tag == "pushUpPlus")
        {
            Trigger5.SetActive(false);
            pushUpPlus5.SetActive(true);
            checkpointLocation5.transform.position = checkpointLocation.position;
        }
        if (other.gameObject.tag == "depression")
        {
            Trigger6.SetActive(false);
            depression6.SetActive(true);
            checkpointLocation6.transform.position = checkpointLocation.position;
        }
        if (other.gameObject.tag == "isotonicScaption")
        {
            Trigger7.SetActive(false);
            isotonicScaption7.SetActive(true);
            checkpointLocation7.transform.position = checkpointLocation.position;
        }
        if (other.gameObject.tag == "pronePressUps")
        {
            Trigger8.SetActive(false);
            pronePressUps8.SetActive(true);
            checkpointLocation8.transform.position = checkpointLocation.position;
        }
        if (other.gameObject.tag == "healing")
        {
            Trigger9.SetActive(false);
            healing9.SetActive(true);
            checkpointLocation9.transform.position = checkpointLocation.position;
        }
    }
}
