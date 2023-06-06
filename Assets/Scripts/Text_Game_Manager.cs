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
    public GameObject Lvl3_Choices;
    public GameObject Lvl4_Choices;
    public GameObject Lvl5_Choices;
    public GameObject Lvl6_Choices;
    public GameObject MainMenu;

    public bool end = false;
 
    // Start is called before the first frame update
    void Start()
    {
        Lvl1_Choices.SetActive(false);
        Lvl2_Choices.SetActive(false);
        Lvl3_Choices.SetActive(false);
        Lvl4_Choices.SetActive(false);
        Lvl5_Choices.SetActive(false);
        Lvl6_Choices.SetActive(false);  
        storyText = "School Life";
    }

    // Update is called once per frame
    void Update()
    {
        storyTextMeshPro.text = storyText;
        HPMeshPro.text = HP_value.ToString();
        STAMeshPro.text = STA_value.ToString();
    }

    public void ending()
    {
        if (end == true)
        {
            storyText = "THE END";
        }
    }

    public void startGame()
    {
        Lvl1_Choices.SetActive(true);
        MainMenu.SetActive(false);
        storyText = "You wake up and prepared yourself to go to school. As you walk along the road heading towards the school, you encounter a black cat blocking your way. You take a moment to consider what to do with the black cat.";
    }

    public void Lvl1_petCat()
    {
        storyText = "As you pet the cat, you forgot the passing of time and was\r\nlocked out of the school.\r\n The end.";
           
  
        Debug.Log("Level 1 Pet Cat pressed.");
        Debug.Log("Level 1 choices deactivated.");
        Lvl1_Choices.SetActive(false);
        end = true;
    }

    public void Lvl1_ignoreCat()
    {
        storyText = "You ignored the cat and walked to school without being\r\nlate. Sitting at the class, you...";
        Debug.Log("Level 1 Ignore Cat pressed.");
        Debug.Log("Level 1 choices deactivated.");
        Lvl1_Choices.SetActive(false);
        Lvl2_Choices.SetActive(true);
    }

    public void Lvl2_focusClass()
    {
        storyText = "You focused on the class and listened attentively.\r\nThe teacher rewarded you 5 class points for listening properly. As the class finished you went to the...";

        Debug.Log("Level 2 Daydream pressed.");
        Debug.Log("Level 2 Focus Class pressed");
        Lvl2_Choices.SetActive(false);
        Lvl3_Choices.SetActive(true);
    }

    public void Lvl2_daydream()
    {
        storyText = "The teacher caught you daydreaming and penalized you with -5 class points and sent you outside while raising your arms up.\r\nThe end.";

        Debug.Log("Level 2 Daydream pressed.");
        Debug.Log("Level 2 choices deactivated.");
        Lvl2_Choices.SetActive(false);
    }

    public void Lvl3_cafeteria()
    {
        storyText = "You went to the cafeteria and ordered food for lunch.\r\n You feel fulla nd well rested. You go back to class.";
        Debug.Log("Level 3 Cafeteria pressed.");
        Debug.Log("Level 3 choices deactivated.");
        Debug.Log("Proceed to level 4");
        Lvl3_Choices.SetActive(false);
        Lvl4_Choices.SetActive(true);
    }

    public void Lvl3_backyard()
    {
        storyText = "You went to the school backyard and...";
        Debug.Log("Level 3 Backyard pressed.");
        Debug.Log("Level 3 choices deactivated.");
        Debug.Log("Proceed to level 5");
        Lvl5_Choices.SetActive(true);
        Lvl3_Choices.SetActive(false);
    }

    public void Lvl4_focusClass()
    {
        storyText = "As the class finished, you went back to your house.\r\n The end.";
        Debug.Log("Level 4 Focus Class pressed.");
        Debug.Log("Leve 4 choices deactivated.");
        Lvl4_Choices.SetActive(false);
    }
    public void Lvl4_daydream() 
    {
        storyText = "The teacher caught you daydreaming and penalized you with -5 class points and sent you outside while raising your arms up.\r\n The end.";
        Debug.Log("Level 4 Daydream pressed.");
        Debug.Log("Leve 4 choices deactivated.");
        Lvl4_Choices.SetActive(false);
    }

    public void Lvl5_playAround()
    {
        storyText = "You played around and felt exhausted. You go back to class.";
        Debug.Log("Level 5 Play Around pressed.");
        Debug.Log("Level 5 choices deactivated.");
        Debug.Log("Proceed to level 6");
        Lvl6_Choices.SetActive(true);
        Lvl5_Choices.SetActive(false);
    }
    
    public void Lvl5_explore()
    {
        storyText = "As you explore the backyard, you accidentally tripped on a pebble and hit the floor face first. You lost consciousness.\r\nThe end";
        Debug.Log("Level 5 Explore pressed.");
        Debug.Log("Level 5 choices deactivated.");
        Lvl5_Choices.SetActive(false);
    }

    public void Lvl6_focusClass()
    {
        storyText = "As you felt exhausted from playing earlier, you accidentally dozed off. You got caught by the teacher and forced you to stay outside while raising your arms up until the end of class.\r\nThe end.";
        Debug.Log("Level 6 Focus Class pressed.");
        Debug.Log("Level6 choices deactivated.");
        Lvl6_Choices.SetActive(false);
    }

    public void Lvl6_dozeOff()
    {
        storyText = "You covered your face with an open book raised vertically. The teacher didn't caught you sleeping. As the class finished, you woke up and go back to your house.\r\nThe end.";
        Debug.Log("Level 6 Doze Off pressed.");
        Debug.Log("Level6 choices deactivated.");
        Lvl6_Choices.SetActive(false);
    }
    public void ExitGame()
    {
        Application.Quit();
    }

}
