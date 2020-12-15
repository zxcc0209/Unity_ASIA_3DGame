using UnityEngine;

public class NPC : MonoBehaviour
{
    [Header("NPC資料")]
    public NPCData data;

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
        print(data.dialougA);
    }
}
