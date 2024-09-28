using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextHandler : MonoBehaviour
{
    int roundCounter = 0;
    int previousDecision = -1;

    Dat[] datArray;

    // Start is called before the first frame update
    void Start()
    {
        datList = new List<Dat>();

        // first scene        
        datList.Add(catSpeaking("newcomer eh ?", true, false, false));
        datList.Add(narratorSpeaking("yeah, I got hit by an asteroid on my way to my vacation and looking at my ship I will stay here for a long time", true, false, false, false));
        datList.Add(catSpeaking("Oh shi...It can\'t be... I mean how unfortunate! Today, I\'m feelin\' extra generous. Call me... the Good Sam... uh, Samaritan!", false, false, false));
        datList.Add(narratorSpeaking("?", true, false, false, false));
        datList.Add(catSpeaking("Lucky for you, I think... some screws should be... um, sufficient. They gotta be... around here... somewhere.", false, false, false));
        datList.Add(catSpeaking("Alrighty then! Jus\'... come back when ya... when ya got the screws, okay? iS aul goodman!", false, true, false));
        datList.Add(narratorSpeaking("Great, a mechanic who's already drunk on a Tuesday morning who is going to fix my spaceship with ... some screws. but at this point, he's the only option I\'ve got.", false, false, false, false));

        // second scene


    }

    public Dat queryData(){
        return datArray[roundCounter];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Dat catSpeaking(string text, bool enter, bool leave, bool requireChoice) {
        new Dat(text, "Cat",enter, true, leave, false, false, false, false, false, false, requireChoice);
    }

    Dat SharkSpeaking(string text, bool enter, bool leave, bool requireChoice, bool showMonkey) {
        new Dat(text, "Shark",true, false, false, true, enter, leave, showMonkey, false, false, requireChoice);
    }

    Dat MonkeySpeaking(string text, bool enter, bool leave, bool requireChoice, bool showShark) {
        new Dat(text, "Monkey",true, false, false, showShark, false, false, false, enter, leave, requireChoice);
    }

    Dat narratorSpeaking(string text, bool showCat, bool showShark, bool showMonkey, bool requireChoice) {
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
