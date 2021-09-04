using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public static QuestManager Instance;
    
    public QuestObject[] quests;
    public bool[] questCompleted;
    

    private void Start()
    {
        Instance = this;
        questCompleted = new bool[quests.Length];
    }
}
