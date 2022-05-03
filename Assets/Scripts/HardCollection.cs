using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class HardCollection : MonoBehaviour
{
    private float pickup = 0;

    public TextMeshProUGUI textScore;
    public TextMeshProUGUI objectiveText;
    public AudioClip polaroidSound;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "pickup")
        {
            pickup++;
            textScore.text = pickup.ToString();
            AudioSource.PlayClipAtPoint(polaroidSound, transform.position);
            Destroy(other.gameObject);
        }

        if(pickup == 9)
        {
            objectiveText.text = "Level Complete";

        }
       
    }
}
