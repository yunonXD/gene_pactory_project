using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class For_Tutorial_Yeeter : MonoBehaviour
{
    private int Clicker_Check = 0;      // 獄動 適遣 判呪稽 毒舘 敗. 獣娃 蒸嬢辞 戚係惟 幻級嬢醤敗.
    private bool ISON = false;                  //情喰獄動 喚携澗走 焼観走 溌昔背醤敗.

    public GameObject For_Story;        //什塘軒但

    public GameObject Clicker;          //鉢檎 適遣馬檎 収切 臣虞亜澗 朝錘斗
    public Text dialog;                 //努什闘 窒径遂 陥戚嬢稽益

    public GameObject BlackScreen1;     //unknown聖 是廃 亜顕厳
    public GameObject Arrow_1;          //unknown聖 亜軒迭 鉢詞妊
    public Toggle BigIcon7_ForCheck;    //unknow 塘越

    public GameObject BlackScreen2;     //Open聖 是廃 亜顕厳

    public Toggle BigIcon7_Toggle;
    public GameObject Arrow_2;          //gene 亜軒迭 鉢詞妊
    public Toggle unlocked_7_Intel; //昔土

    public GameObject Arrow_3;          //intel 聖 亜軒迭

    public Toggle BigIcon7_Intel_Sus;

    public GameObject Arrow_4;          //big intel 聖 亜軒迭

    public GameObject Arrow_5;          //exit聖 亜軒迭

    public GameObject Screen_For;


    public GameObject BlackScreen3;     //EXIT聖 是廃 亜顕厳


    //績獣遂 什滴験闘. 戚闇 紫遂拝 森舛戚 蒸製.


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // 人 詞陥詞陥 戚杏 戚係惟 幻級嬢左革 せせせせせせせせせせせせ 耕帖畏革 遭促
        switch (Clicker_Check)
        {
            case 0:
                {
                    dialog.text = "胡煽, 爽嬢遭 匂昔闘研 戚遂背 叔蝿端研 背榎背左亀系 杯獣陥.";
                }
                break;

            case 1:
                {
                    dialog.text = "胡煽 笛 走亀研 適遣.";
                    BlackScreen1.gameObject.SetActive(true);
                    Arrow_1.gameObject.SetActive(true);
                    Clicker.gameObject.SetActive(false);

                    if (BigIcon7_ForCheck.isOn)
                    {
                        Clicker.gameObject.SetActive(true);
                        
                    }

                }
                break;


            case 2:
                {

                    BlackScreen1.gameObject.SetActive(false);
                    Arrow_1.gameObject.SetActive(false);
                    dialog.text = "淫軒切還精 政穿切 走亀拭辞 叔蝿端研 幻級嬢 鎧澗 依戚 亜管杯艦陥.";

                }
                break;

            case 3:
                {

                    dialog.text = "笛 走亀拭辞澗 叔蝿端研 背榎拝 呪 赤柔艦陥.";

                }
                break;

            case 4:
                {

                    dialog.text = "拙精 走亀澗 陥製 舘域稽 戚嬢走奄 是背 琶推杯艦陥." +
                        " 戚 採歳精 背榎拝 凶亜 鞠檎 切室備 竺誤球軒畏柔艦陥. ";

                }
                break;
            case 5:
                {
                    Clicker.gameObject.SetActive(false);
                    dialog.text = "識澱廃 走亀研 背榎馬奄 是背, OPEN 獄動聖 適遣背詐獣陥. ";
                    BlackScreen2.gameObject.SetActive(true);


                    if (ISON == true)
                    {

                        Debug.Log("叔楳喫");
                        For_Story.gameObject.SetActive(false);
                        BlackScreen2.gameObject.SetActive(false);
                        Clicker_Check += 1;
                    }


                }
                break;
            case 6:
                {
                    StartCoroutine("WaitForUnilockAnime");
 
                }
                break;

            case 7:
                {
                    StopCoroutine("WaitForUnilockAnime");
                    Clicker.gameObject.SetActive(false);
                    Debug.Log("適軒朕 拙疑馬澗走 溌昔掻 : " + Clicker_Check);
                    dialog.text = "叔蝿端 獄動聖 適遣馬檎 叔蝿端 舛左研 陥獣 瑳 呪 赤柔艦陥.";
                    BlackScreen2.gameObject.SetActive(true);
                    Arrow_2.gameObject.SetActive(true);

                    if (BigIcon7_Toggle.isOn)
                    {
                        Arrow_2.gameObject.SetActive(false);
                        Arrow_3.gameObject.SetActive(true);

                        if (unlocked_7_Intel.isOn)
                        {
                            Arrow_3.gameObject.SetActive(false);
                            Arrow_4.gameObject.SetActive(true);
                            if (BigIcon7_Intel_Sus.isOn)
                            {
                                Arrow_4.gameObject.SetActive(false);
                                    Clicker_Check = 8;
                            }
                        }
                    }

                }
                break;



            case 8:
                {
                    StartCoroutine("ScreanWait");


                }
                break;





            case 9:
                {
                    StopCoroutine("ScreanWait");
                    Clicker.gameObject.SetActive(false);
                    BlackScreen2.gameObject.SetActive(false);
                    BlackScreen3.gameObject.SetActive(true);
                    Debug.Log("適軒朕 拙疑馬澗走 溌昔掻 : " + Clicker_Check);
                    dialog.text = "持誤端研 塙究梅生艦 穿燈 汎恵生稽 角嬢亜畏柔艦陥.";
                    Arrow_5.gameObject.SetActive(true);

                }
                break;







        }




    }


    public void UnlockButton_Checker()
    {
        ISON = true;
    }


    IEnumerator WaitForUnilockAnime()
    {
        yield return new WaitForSeconds(9.0f);
        For_Story.gameObject.SetActive(true);
        Clicker.gameObject.SetActive(true);
    }

    IEnumerator ScreanWait()
    {
        yield return new WaitForSeconds(4.0f);
        Clicker.gameObject.SetActive(true);

    }


    public void Clicker_Count_Num()
    {
        Clicker_Check += 1;
        Debug.Log("適軒朕 拙疑馬澗走 溌昔掻 : " + Clicker_Check);
    }






}
