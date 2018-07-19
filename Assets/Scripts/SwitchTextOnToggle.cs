using UnityEngine;
using UnityEngine.UI;

public class SwitchTextOnToggle : MonoBehaviour
{
    Toggle m_Toggle;
    public Text ToggleText, Question1, Question2, Question3, Question4;
    string[] EnglishQuestions = { 
        "What benefits does this toothpaste have?", 
        "Is there a different brand?", 
        "What flavor is this toothpaste?", 
        "Is there an issue with the way the brand is called?" };
    string[] ChineseQuestions = {
        "这个牙膏有什么功效？",
        "有其他的品牌吗？",
        "这是什么味道的？",
        "这个品牌名称有没有问题？" };
        

    void Start()
    {
        //Fetch the Toggle GameObject
        m_Toggle = GetComponent<Toggle>();
        //Add listener for when the state of the Toggle changes, to take action
        m_Toggle.onValueChanged.AddListener(delegate {
            ToggleValueChanged(m_Toggle);
        });

        //Initialise the Text to say the first state of the Toggle
        if (!m_Toggle.isOn)
        {
            ToggleText.text = "EN";
            Question1.text = EnglishQuestions[0];
            Question2.text = EnglishQuestions[1];
            Question3.text = EnglishQuestions[2];
            Question4.text = EnglishQuestions[3];
        }

        if (m_Toggle.isOn)
        {
            ToggleText.text = "文";
            Question1.text = ChineseQuestions[0];
            Question2.text = ChineseQuestions[1];
            Question3.text = ChineseQuestions[2];
            Question4.text = ChineseQuestions[3];
        }
    }

    //Output the new state of the Toggle into Text
    void ToggleValueChanged(Toggle change)
    {
        if (!m_Toggle.isOn)
        {
            ToggleText.text = "EN";
            Question1.text = EnglishQuestions[0];
            Question2.text = EnglishQuestions[1];
            Question3.text = EnglishQuestions[2];
            Question4.text = EnglishQuestions[3];
        }

        if (m_Toggle.isOn)
        {
            ToggleText.text = "文";
            Question1.text = ChineseQuestions[0];
            Question2.text = ChineseQuestions[1];
            Question3.text = ChineseQuestions[2];
            Question4.text = ChineseQuestions[3];
        }
    }
}