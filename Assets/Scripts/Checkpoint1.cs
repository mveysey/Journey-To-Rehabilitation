using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint1 : MonoBehaviour
{
    
    public GameObject climb1;
    public GameObject isotonicScaption2;
    public GameObject healing3;
    public GameObject tinSoldier4;
    public GameObject pushUpPlus5;
    public GameObject depression6;
    public GameObject proneArms7;
    public GameObject pronePressUps8;
    public GameObject anxiety9;

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

    void OnTriggerEnter(Collider other)
    { 

        if (other.gameObject.tag == "Respawn")
        {
            player.transform.position = checkpointLocation.position;
        }

        if (other.gameObject.tag == "isotonicScaption")
        {
            Trigger2.SetActive(false);
            isotonicScaption2.SetActive(true);
            checkpointLocation2.transform.position = checkpointLocation.position;
        }
        if (other.gameObject.tag == "Healing")
        {
            Trigger3.SetActive(false);
            healing3.SetActive(true);
            checkpointLocation3.transform.position = checkpointLocation.position;

            isotonicScaption2.SetActive(false);
        }
        if (other.gameObject.tag == "tinSoldier")
        {
            Trigger4.SetActive(false);
            tinSoldier4.SetActive(true);
            checkpointLocation4.transform.position = checkpointLocation.position;

            healing3.SetActive(false);
        }
        if (other.gameObject.tag == "pushUpPlus")
        {
            Trigger5.SetActive(false);
            pushUpPlus5.SetActive(true);
            checkpointLocation5.transform.position = checkpointLocation.position;

            tinSoldier4.SetActive(false);
        }
        if (other.gameObject.tag == "depression")
        {
            Trigger6.SetActive(false);
            depression6.SetActive(true);
            checkpointLocation6.transform.position = checkpointLocation.position;

            pushUpPlus5.SetActive(false);
        }
        if (other.gameObject.tag == "proneArms")
        {
            Trigger7.SetActive(false);
            proneArms7.SetActive(true);
            checkpointLocation7.transform.position = checkpointLocation.position;

            depression6.SetActive(false);
        }
        if (other.gameObject.tag == "pronePressUps")
        {
            Trigger8.SetActive(false);
            pronePressUps8.SetActive(true);
            checkpointLocation8.transform.position = checkpointLocation.position;

            proneArms7.SetActive(false);
        }
        if (other.gameObject.tag == "anxiety")
        {
            Trigger9.SetActive(false);
            anxiety9.SetActive(true);
            checkpointLocation9.transform.position = checkpointLocation.position;

            pronePressUps8.SetActive(false);
        }
    }
}
