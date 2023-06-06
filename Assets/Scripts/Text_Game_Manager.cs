using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Threading;

public class Text_Game_Manager : MonoBehaviour
{
    public TextMeshProUGUI storyTextMeshPro;
    public TextMeshProUGUI HPMeshPro;
    public TextMeshProUGUI STAMeshPro;
    public string storyText;
    public int HP_value = 10;
    public int STA_value = 10;
    public GameObject Lvl1_Choices;
    public GameObject Lvl2_Choices;

    public float timeRemaining = 3;
    public bool timeIsRunning = false;
    // Start is called before the first frame update
    void Start()
    {
        Lvl2_Choices.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        storyTextMeshPro.text = storyText;
        HPMeshPro.text = HP_value.ToString();
        STAMeshPro.text = STA_value.ToString();


        if (timeIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                //Debug.Log(timeRemaining.ToString());
            }
            else
            {
                Debug.Log("No more time.");
                timeRemaining = 0;
                timeIsRunning = false;
            }
        }
    }


    public void Lvl1_openMailbox()
    {
        storyText = "You find a leaflet.\r\n[STA -1]";
            STA_value -= 1;
  
        Debug.Log("Level 1 Open Mailbox pressed.");
    }

    public void Lvl1_openDoor()
    {
        storyText = "The door is boarded... You can't enter without a specific item to pry open the door.\r\n[STA -1]";
        if (STA_value == 10)
        {
            STA_value -= 1;
        }
        Debug.Log("Level 1 Open Door pressed.");
    }

    public void Lvl1_ignore()
    {
        
        storyText = "You ignored the boarded door and the mailbox.\r\nExplore the open fields?";
        Lvl1_Choices.SetActive(false);
        Lvl2_Choices.SetActive(true);

        Debug.Log("Level 1 Ignore button pressed, Level 1 choices deactivated.");
        Debug.Log("Level 2 choices appear.");

    }

    public void Lvl2_ExploreFields()
    {
        storyText = "You explored the fields and found nothing!\r\n[STA -5]";
        Debug.Log("Level 2 Explore fields pressed");
        Debug.Log("Start 5 second timer.");
        
           STA_value -= 5;
        

        Lvl2_Choices.SetActive(false);
        timeIsRunning = true;
        if (timeIsRunning == false)
        {
            storyText = "Go back?";
            Debug.Log("Timer 0 second");
        }
    }

    public void Lvl3_GoBack()
    {
        
       /* if (timeRemaining > 0)
        {
            storyText = "Go back?";
            Debug.Log("Timer 0 second");
        }
       */
    }

    public void Lvl2_Ignore()
    {
        storyText = "You suddenly had a heart attack!\r\n[HP - 10]";
        if (HP_value == 10)
        {
            HP_value -= 10;
        }
        if (STA_value >= 1)
        {
            STA_value = 0;
        }
        Debug.Log("Level 1 Button (Ignore) pressed! HP -10, STA -10");
        Lvl2_Choices.SetActive(false);

        if (timeRemaining == 0)
        {
            Application.Quit();
        }
    }


}
