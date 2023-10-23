using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PromptGenerator : MonoBehaviour
{
    public List<string> prompts;
    private TextMeshProUGUI promptText;
    void Start()
    {
        promptText = GameObject.Find("Prompt Text").GetComponent<TextMeshProUGUI>();
        promptText.text = prompts[Random.Range(0, prompts.Count)];
    }
    
    void Update()
    {
        
    }

    public void GeneratePrompt()
    {
        string currentPrompt = promptText.text;
        for (int i = 0; i < 1;)
        {
            string newPrompt = prompts[Random.Range(0, prompts.Count)];
            if (newPrompt != currentPrompt)
            {
                promptText.text = newPrompt;
                i++;
            }
        }
    }
}
