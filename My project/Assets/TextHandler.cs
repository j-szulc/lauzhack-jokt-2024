using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextHandler : MonoBehaviour
{
    int roundCounter;
    int previousDecision;
    bool useInput;
    // bool subDialoguePath

    List<Dat> datArray;

    // Start is called before the first frame update
    void Start()
    {
        roundCounter = 0;
        previousDecision = -1;
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
        datList.Add(sharkSpeaking("Look what we have here, new fish in the sea", true, false, false, false));
        datList.Add(sharkSpeaking("You look like you crashed a space shuttle or something down the street? Why the long face? You can call me Blahaj btw", false, false, false, false));
        datList.Add(narratorSpeaking("...", false, true, false, false));
        datList.Add(sharkSpeaking("Anyway, I\'m in the middle of a... uh, heated debate with this stupid monkey here, and we could use your help.", false, false, false, false));
        datList.Add(monkeySpeaking("That\'s right!", true, false, false, true));
        datList.Add(monkeySpeaking("Our planet is great and all, it\'s just getting..., crowded", false, false, false, true));
        datList.Add(sharkSpeaking("And you monkey people should get out as we came here first !", false, false, false, true));
        datList.Add(narratorSpeaking("...", false, true, true, false));
        datList.Add(monkeySpeaking("So what ? Everyone knows you shark people are the ones causing all the trouble !", false, false, false, true));
        datList.Add(sharkSpeaking("That\'s B#&*sh%t !", false, false, false, true));
        datList.add(new Dat(text,"Blahaj & Monkey",false, false, false, true, false, false, true, false, false, true));
    }

    public Dat queryData(int input) {
        Dat res = datArray[roundCounter];
        // if(useInput){

        // }
        // if(res.RequireChoice){
        //     useInput = true;
        // }
        return res;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Dat catSpeaking(string text, bool enter, bool leave, bool requireChoice) {
        new Dat(text,"Cat",true, enter, leave, false, false, false, false, false, false, requireChoice);
    }

    Dat sharkSpeaking(string text, bool enter, bool leave, bool requireChoice, bool showMonkey) {
        new Dat(text, "Blahaj",true, false, false, true, enter, leave, showMonkey, false, false, requireChoice);
    }

    Dat monkeySpeaking(string text, bool enter, bool leave, bool requireChoice, bool showShark) {
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
