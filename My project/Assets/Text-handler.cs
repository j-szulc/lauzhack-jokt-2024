using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text-handler : MonoBehaviour
{
    int roundCounter = 0;
    int previousDecision = -1;

    Dat[] datArray;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the array with a fixed size (e.g., 5 objects)
        datArray = new Dat[5];

        // Populate the array with Dat objects
        datArray[0] = catSpeaking("newcomer eh ?", true, false, false);
        datArray[1] = narratorSpeaking("yeah, I got hit by an asteroid on my way to my vacation and looking at my ship I will stay here for a long time", true, false, false, false);
        datArray[2] = catSpeaking("Oh shi...It can\'t be... I mean how unfortunate! Today, I\'m feelin\' extra generous. Call me... the Good Sam... uh, Samaritan!", false, false, false);
        datArray[3] = narratorSpeaking("?", true, false, false, false);
        datArray[4] = catSpeaking("Lucky for you, I think... some screws should be... um, sufficient. They gotta be... around here... somewhere.", false, false, false);
    }

    public Dat queryData(){
        return datArray[roundCounter]
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Dat catSpeaking(string text, boolean enter, boolean leave, boolean requireChoice) {
        new Dat(text, "Cat",true, true, false, false, false, false, false, false, false, requireChoice);
    }

    Dat narratorSpeaking(string text, boolean showCat, boolean showShark, boolean showMonkey, boolean requireChoice) {
        new Dat(text, "Narrator",false, showCat, false, false, showShark, false, false, showMonkey, false, requireChoice);
    }

}

public class Dat
{
    public string Text { get; set; }
    public string CharacterSpeaking { get; set; }
    public bool ShowCat { get; set; }
    public bool CatInScreen { get; set; }
    public bool CatOutScreen { get; set; }
    public bool ShowShark { get; set; }
    public bool SharkInScreen { get; set; }
    public bool SharkOutScreen { get; set; }
    public bool ShowMonkey { get; set; }
    public bool MonkeyInScreen { get; set; }
    public bool MonkeyOutScreen { get; set; }
    public bool RequireChoice { get; set; }

    // Optional: constructor to initialize values
    public Dat(string text, string characterSpeaking, bool showCat, bool catInScreen, bool catOutScreen, 
               bool showShark, bool sharkInScreen, bool sharkOutScreen, 
               bool showMonkey, bool monkeyInScreen, bool monkeyOutScreen, 
               bool requireChoice)
    {
        Text = text;
        CharacterSpeaking = characterSpeaking;
        ShowCat = showCat;
        CatInScreen = catInScreen;
        CatOutScreen = catOutScreen;
        ShowShark = showShark;
        SharkInScreen = sharkInScreen;
        SharkOutScreen = sharkOutScreen;
        ShowMonkey = showMonkey;
        MonkeyInScreen = monkeyInScreen;
        MonkeyOutScreen = monkeyOutScreen;
        RequireChoice = requireChoice;
    }

    // Default constructor (optional)
    public Dat() { }
}
