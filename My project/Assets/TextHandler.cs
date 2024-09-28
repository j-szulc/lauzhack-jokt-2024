using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextHandler : MonoBehaviour
{
    int roundCounter;
    bool useInput;
    int subDialoguePath;
    int subDialogueRoundCounter;
    List<Dat> datList;
    List<List<Dat>> subPathLists;

    // Start is called before the first frame update
    void Start()
    {
        roundCounter = 0;
        subDialogueRoundCounter = 0;
        datList = new List<Dat>();
        subPathLists = new List<List<Dat>>();

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
        datList.add(new Dat("What do YOU say","Blahaj & Monkey",false, false, false, true, false, false, true, false, false, true));

        //sub list 1
        List<Dat> subPathList1 = new List<Dat>();
        subPathList1.Add(sharkSpeaking("During the last 20 years the situation on our planet has gotten worse and worse", false, false, false, true));
        subPathList1.Add(sharkSpeaking("A big part in that is the arrival of the monkeys 10 years ago", false, false, false, true));
        subPathList1.Add(sharkSpeaking("They depleted the resources of our world even more", false, false, false, true));
        subPathList1.Add(sharkSpeaking("This is why we are voting who should leave the planet, we both have the deciding vote", false, false, true, true));
        subPathLists.Add(subPathList1);

        //sub list 2
        List<Dat> subPathList2 = new List<Dat>();
        subPathList2.Add(sharkSpeaking("On top of that, there aren\'t even any bananas on this planet!", false, false, false, true));
        subPathList2.Add(sharkSpeaking("Why would a monkey want to be here at all?", false, false, true, true));
        subPathLists.Add(subPathList2);

        //sub list 3
        List<Dat> subPathList3 = new List<Dat>();
        subPathList3.Add(sharkSpeaking("Clearly the monkeys should leave", false, false, false, true));
        subPathList3.Add(sharkSpeaking("Since we\'ve run out of time, please make your decision now.", false, false, false, true));
        subPathList3.Add(sharkSpeaking("You agree with me right?", false, false, true, true));
        subPathLists.Add(subPathList3);

        //sub list 4
        List<Dat> subPathList4 = new List<Dat>();
        subPathList4.Add(sharkSpeaking("Although the monkeys are slightly right, there was enough water before they arrived!", false, false, false, true));
        subPathList4.Add(sharkSpeaking("And besides, there aren\'t even any bananas here", false, false, false, true));
        subPathList4.Add(sharkSpeaking("Why would they want to be here at all?!", false, false, true, true));
        subPathLists.Add(subPathList4);

        //sub list 5
        List<Dat> subPathList5 = new List<Dat>();
        subPathList5.Add(sharkSpeaking("The monkeys are exaggerating!", false, false, false, true));
        subPathList5.Add(sharkSpeaking("We have our disputes with others from time to time", false, false, false, true));
        subPathList5.Add(sharkSpeaking("We are just very unhappy with the current situation created by the monkeys", false, false, false, true));
        subPathList5.Add(sharkSpeaking("Which is why we lash out at the others sometimes", false, false, false, true));
        subPathList5.Add(sharkSpeaking("Getting rid of them will make everything better!", false, false, false, true));
        subPathList5.Add(sharkSpeaking("Since we\'ve run out of time, please make your decision now.", false, false, false, true));
        subPathList5.Add(sharkSpeaking("You agree with me right?", false, false, true, true));
        subPathLists.Add(subPathList5);

        //sub list 6
        List<Dat> subPathList6 = new List<Dat>();
        subPathList6.Add(monkeySpeaking("We did arrive quite recently", false, false, false, true));
        subPathList6.Add(monkeySpeaking("But so far we only have had problems with the sharks", false, false, false, true));
        subPathList6.Add(monkeySpeaking("All the other species have been welcoming", false, false, false, true));
        subPathList6.Add(monkeySpeaking("On top of that, the sharks have been mean to the other species as well", false, false, false, true));
        subPathList6.Add(monkeySpeaking("Basically everyone would like them to leave!", false, false, true, true));
        subPathLists.Add(subPathList6);

        //sub list 7
        List<Dat> subPathList7 = new List<Dat>();
        subPathList7.Add(monkeySpeaking("Bananas? We don\'t care about bananas.", false, false, false, true));
        subPathList7.Add(monkeySpeaking("We are very happy with whatever this planet has to offer.", false, false, false, true));
        subPathList7.Add(monkeySpeaking("I don\'t think the sharks can say the same", false, false, false, true));
        subPathList7.Add(monkeySpeaking("Since we\'ve run out of time, please make your decision now.", false, false, false, true));
        subPathList7.Add(monkeySpeaking("You agree with me right?", false, false, true, true));
        subPathLists.Add(subPathList7);

        //sub list 8
        List<Dat> subPathList8 = new List<Dat>();
        subPathList8.Add(monkeySpeaking("The sharks have always been mean to us", false, false, false, true));
        subPathList8.Add(monkeySpeaking("I do not understand why they would want to stay here", false, false, false, true));
        subPathList8.Add(monkeySpeaking("There is barely any water left on this planet, this is no place for sharks to live", false, false, false, true));
        subPathList8.Add(monkeySpeaking("Anyways, we\'ve been fighting for a while!", false, false, false, true));
        subPathList8.Add(monkeySpeaking("That\'s why we are voting today on who should leave, we have the deciding vote.", false, false, true, true));
        subPathLists.Add(subPathList8);

        //sub list 9
        List<Dat> subPathList9 = new List<Dat>();
        subPathList9.Add(monkeySpeaking("The sharks are not only mean to us", false, false, false, true));
        subPathList9.Add(monkeySpeaking("They a(p)pe-ar to have troubles with all species", false, false, false, true));
        subPathList9.Add(monkeySpeaking("Everyone would like them to leave!", false, false, true, true));
        subPathLists.Add(subPathList9);

        //sub list 10
        List<Dat> subPathList10 = new List<Dat>();
        subPathList10.Add(monkeySpeaking("It should be clear by now that everyone would be better off if the sharks left!", false, false, false, true));
        subPathList10.Add(monkeySpeaking("Since we\'ve run out of time, please make your decision now.", false, false, false, true));
        subPathList10.Add(monkeySpeaking("You agree with me right?", false, false, true, true));
        subPathLists.Add(subPathList10);

        //sub list 11
        List<Dat> subPathList11 = new List<Dat>();
        subPathList11.Add(narratorSpeaking("You guys are running out of water, right? What happens when it\'s completely gone?", true, true, false, false));
        subPathList11.Add(sharkSpeaking("We\'ll... uh, adapt! We always do!", false, false, false, true));
        subPathList11.Add(narratorSpeaking("Adapt to what, though? Dry land? This planet\'s only going to get worse for you.", true, true, false, false));
        subPathList11.Add(sharkSpeaking("uh, maybe you are right, newcomer.", false, false, false, true));
        subPathList11.Add(sharkSpeaking("I\'ve heard you are looking for screws, since we will be leaving anyway. Might as well give it to you.", false, true, false, true, true));
        subPathLists.Add(subPathList11);

        //sub list 12
        List<Dat> subPathList12 = new List<Dat>();
        subPathList12.Add(narratorSpeaking("You monkeys are always on the move, always exploring, right? Isn\'t staying here kind of boring?", true, true, false, false));
        subPathList12.Add(monkeySpeaking("We do love a good adventure… and that is why we came here", false, false, false, true));
        subPathList12.Add(narratorSpeaking("Then why not make the next leap? There are plenty of fis.. planets in the galaxy.", true, true, false, false));
        subPathList12.Add(narratorSpeaking("You don\'t have to stay stuck here in the dust.", true, true, false, false));
        subPathList12.Add(sharkSpeaking("uh, maybe you are right, newcomer.", false, false, false, true));
        subPathList12.Add(sharkSpeaking("I\'ve heard you are looking for screws, since we will be leaving anyway. Might as well give it to you.", false, true, false, true, true));
        subPathLists.Add(subPathList12);
    }

    public Dat queryData(int input = -1) {
        if(useInput){
            subDialogueRoundCounter = 0;
            if(input == 0){
                if(subDialoguePath == 0){
                    subDialoguePath = 1;
                } else if(subDialoguePath == 1){
                    subDialoguePath = 2;
                } else if(subDialoguePath == 2 || subDialoguePath == 4){
                    subDialoguePath = 3;
                } else if(subDialoguePath == 6 || subDialoguePath == 9){
                    subDialoguePath = 5;
                } else if(subDialoguePath == 8){
                    subDialoguePath = 4;   
                } else {
                    subDialoguePath = 11;
                }
            } else if(input == 1){
                if(subDialoguePath == 0){
                    subDialoguePath = 8;
                } else if(subDialoguePath == 1){
                    subDialoguePath = 6;
                } else if(subDialoguePath == 2 || subDialoguePath == 4){
                    subDialoguePath = 7;
                } else if(subDialoguePath == 6 || subDialoguePath == 9){
                    subDialoguePath = 10;
                } else if(subDialoguePath == 8){
                    subDialoguePath = 9;   
                } else {
                    subDialoguePath = 12;
                }
            }
            useInput = false;
        }
        Dat res = null;
        if(subDialogueRoundCounter == 0){
            res = datList[roundCounter];
            roundCounter++;
        } else {
            res = subPathLists[subDialoguePath-1][subDialogueRoundCounter];
            subDialogueRoundCounter++;
        }
        if(res.RequireChoice){
            useInput = true;
        }
        return res;
    }

    Dat catSpeaking(string text, bool enter, bool leave, bool requireChoice) {
        return new Dat(text,"Me-cat-nic",true, enter, leave, false, false, false, false, false, false, requireChoice);
    }

    Dat sharkSpeaking(string text, bool enter, bool leave, bool requireChoice, bool showMonkey, bool finalMessage = false) {
        return new Dat(text, "Blahaj",true, false, false, true, enter, leave, showMonkey, false, false, requireChoice, finalMessage);
    }

    Dat monkeySpeaking(string text, bool enter, bool leave, bool requireChoice, bool showShark, bool finalMessage = false) {
        return new Dat(text, "Ham",true, false, false, showShark, false, false, false, enter, leave, requireChoice, finalMessage);
    }

    Dat narratorSpeaking(string text, bool showCat, bool showShark, bool showMonkey, bool requireChoice) {
        return new Dat(text, "John",false, showCat, false, false, showShark, false, false, showMonkey, false, requireChoice);
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
    public bool FinalMessage { get; set; }

    // Optional: constructor to initialize values
    public Dat(string text, string characterSpeaking, bool showCat, bool catInScreen, bool catOutScreen, 
               bool showShark, bool sharkInScreen, bool sharkOutScreen, 
               bool showMonkey, bool monkeyInScreen, bool monkeyOutScreen, 
               bool requireChoice, bool finalMessage = false)
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
        FinalMessage = finalMessage;
    }

    // Default constructor (optional)
    public Dat() { }
}
