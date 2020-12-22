using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NPC : MonoBehaviour
{
    [Header("NPC資料")]
    public NPCData data;
    [Header("對話框")]
    public GameObject conversation;
    [Header("對話內容")]
    public Text textContent;
    [Header("對話者名稱")]
    public Text dodo;
    [Header("間隔時間")]
    public float time=0.001f;



    public bool PlayerinArea;

    public enum NPCState 
    {
        FirstDialoug,Mission,Finish

    }
    public NPCState state = NPCState.FirstDialoug;
    /*協同
    private void Start()
    {
        StartCoroutine(Test());
    }
    
    private IEnumerator Test()
    {
        print("嗨");
        yield return new WaitForSeconds(2f);
        print("2s");

    }
    */
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "小明")
        {
            PlayerinArea = true;
            StartCoroutine(Dialoug());
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "小明")
        {
            PlayerinArea = false;
            stopDialoug();

        }
    }
    private void stopDialoug()
    {
        conversation.SetActive(false);
        StopAllCoroutines();
    }
    private IEnumerator Dialoug()
    {
        conversation.SetActive(true);
        textContent.text = "";
        dodo.text = name;

        string dialougString = data.dialougA;

        switch (state)
        {
            case NPCState.FirstDialoug:
                dialougString = data.dialougA;
                break;
            case NPCState.Mission:
                dialougString = data.dialougB;
                break;
            case NPCState.Finish:
                dialougString = data.dialougC;
                break;

        }
        //print(data.dialougA);
        for (int i = 0; i < dialougString.Length; i++)
        {
            textContent.text += dialougString[i] + "";
            //print(data.dialougA[i]);
            yield return new WaitForSeconds(time);
        }
    }
}
