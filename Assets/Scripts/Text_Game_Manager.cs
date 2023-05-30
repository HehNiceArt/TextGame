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

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        storyTextMeshPro.text = storyText;
        HPMeshPro.text = HP_value.ToString();
        STAMeshPro.text = STA_value.ToString();


        Lvl2_Choices.SetActive(false);

    }

    public void Lvl1_openMailbox()
    {
        storyText = "You find a leaflet.";
        if (STA_value == 10)
        {
            STA_value -= 1;
        }
    }

    public void Lvl1_openDoor()
    {
        storyText = "The door is boarded... You can't enter without a specific item to pry open the door.\r\n[STA -1]";
        if (STA_value == 10)
        {
            STA_value -= 1;
        }
    }

    public void Lvl1_ignore()
    {
        storyText = "You ignored the boarded door and the mailbox.\r\nExplore the open fields?";
        Lvl2_Choices.SetActive(true);
        Lvl1_Choices.SetActive(false);

        /*
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
        Lvl1_Choices.SetActive(false);
        */
    }
    public void Lvl2_ignore()
    {

    }
}
