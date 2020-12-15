using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    [Header("NPC資料")]
    public NPCData data;
    [Header("對話框")]
    public GameObject conversation;
    [Header("對話內容")]
    public Text textContent;

    public bool PlayerinArea;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "小明")
        {
            PlayerinArea = true;
            Dialoug();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "小明")
        {
            PlayerinArea = false;
        }
    }
    private void Dialoug()
    {
        //print(data.dialougA);
        for (int i = 0; i < data.dialougA.Length; i++)
        {
            print(data.dialougA[i]);
        }
    }
}
