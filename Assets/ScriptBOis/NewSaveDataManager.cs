using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;


public class NewSaveDataManager : MonoBehaviour
{

    public void newGame()
    {
        Data data = new Data();

        data.Name = "이선동";
        data.Stage1_1 = true;
        data.Stage1_2 = true;
        data.Stage1_3 = true;
        data.Stage1_4 = true;
        data.Stage2_1 = true;
        data.Stage2_2 = true;
        data.Stage2_3 = true;
        data.Stage2_4 = true;
        data.Creature_Mush = true;
        data.Creature_ConRabbit = true;
        data.Creature_Fran = false;
        data.Creature_Nymph = false;
        data.Creature_Manticore = false;
        data.Creature_Temp_1 = false;
        data.Creature_Mobidic = false;
        data.Creature_TangGreece = false;
        data.Creature_Temp_2 = false;
        data.Gene_Between_1 = true;
        data.Gene_Between_2 = false;
        data.Gene_Between_3 = false;
        data.Gene_Between_4 = false;
        data.Gene_Between_5 = false;
        data.Gene_Between_6 = false;
        data.Gene_Between_7 = false;
        data.Gene_Between_8 = false;
        data.ResearchPoint = 10;            //새로운 세이브 파일 포인트 잠시 10으로 늘릴게요! by 윤종우


        File.WriteAllText(Application.dataPath + "/SaveData.json", JsonUtility.ToJson(data));
        Debug.Log("세이브 데이터 생성");
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
