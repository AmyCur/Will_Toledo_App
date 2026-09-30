using TMPro;
using UnityEngine;
public class ChangeQuote : MonoBehaviour
{
    public string[] quotes = {
        "Woke up, had a boner, dragged a comb across my boner",
        "Everybodys dead!",
        "Holy Shit",
        "Holy crap, thats not supposed to be here",
        "beetlebop",
        "Do you have something against dogs?",
        "I feel so haunted",
    };

    public TMP_Text text;
    int quoteIndex;
    int randomNum;

    public void SetQuote()
    {
        do
        {
            randomNum = Random.Range(0, quotes.Length);
        } while (quoteIndex == randomNum);

        quoteIndex = randomNum;
        text.text = quotes[quoteIndex];
    }


    void Start(){
        SetQuote();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            SetQuote();
        }

        if (Input.touchCount > 0)
        {
            SetQuote();
        }
    }
}
