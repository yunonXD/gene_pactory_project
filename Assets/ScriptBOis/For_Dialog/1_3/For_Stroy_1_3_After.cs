using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class For_Stroy_1_3_After : MonoBehaviour
{
    public GameObject ScreenLock;       //버튼 못누르게 락 걸기

    private int CountClick = 0;
    public Text _index;                 //대화 내용
    public Text _name;                  //이름
    public GameObject Secretary;        //비서 스프라이트
    public GameObject NPC_1;            //NPC1
    public GameObject SelectQ;          //선택창
    public Button SelectQ_B_1;          //선택창에 있는 상호작용 버튼
    public Button SelectQ_B_2;          //선택창에 있는 상호작용 버튼
    public GameObject FadeBoi;          //페이드 인 아웃 시킬 검은 화면
    public GameObject UI_Dialoue;

    private Animator animator;
    private bool Alpha_Secretary = false;
    private bool Alpha_NPC_1 = false;
    private float Timer = 0;

    bool select1 = false;
    bool select2 = false;

    private void Awake()
    {
        animator = FadeBoi.GetComponent<Animator>();
    }


    void Start()
    {
        SelectQ_B_1.onClick.AddListener(SelectQ_1);
        SelectQ_B_2.onClick.AddListener(SelectQ_2);

    }


    void Update()
    {
    }

    public void SelectQ_1()          //선택지 창에서 눌렀는지 아닌지 확인하는부분.
    {
        select1 = true;
        Debug.Log(select1);
    }

    public void SelectQ_2()          //선택지 창에서 눌렀는지 아닌지 확인하는부분.
    {
        select2 = true;
        Debug.Log(select2);
    }


    //제목 거점 수호 전

    //.setDelay(?);

    public void ForStory_3_1()
    {
        CountClick += 1;
        Debug.Log(CountClick);

        switch (CountClick)
        {
            case 1:
                _name.text = "";
                _index.DOText("장시간의 전투 끝에 바포니스니르가 쓰러졌다.", 1);
                break;


            case 2:
                _name.text = "";
                _index.DOText("", 1);
                _index.DOText("전투 능력을 상실한 바포니스니르가 포박당하고, 전투는 종료됐다.", 1);
                break;

            case 3:
                Secretary.gameObject.SetActive(true);
                NPC_1.gameObject.SetActive(true);

                Change_Alpha_Secretary(Alpha_Secretary == true);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == false);

                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("포박된 시점에서 너에게 더 이상 승산은 없다. 포기해라.", 1);
                break;

            case 4:
                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);

                _name.text = "바포니스니르";
                _index.DOText("", 1);
                _index.DOText("최악이군요, 설마 제가 이런 잔챙이한테 당하다니…", 1);
                break;

            case 5:
                Change_Alpha_Secretary(Alpha_Secretary == true);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == false);
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("이번 습격의 목적은 모르겠지만, 무의미한 저항보다는 얌전히 투항하는 것이 편할 것이다. ", 1);
                break;

            case 6:
                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);
                _name.text = "바포니스니르";
                _index.DOText("", 1);
                _index.DOText("무의미? 전투에서는 당신들을 통솔하는 자의 도움을 받아 이겼지만 상황 파악을 할 줄 모르는군요.", 1);
                break;

            case 7:
                _name.text = "바포니스니르";
                _index.DOText("", 1);
                _index.DOText("어차피 저는 이미 목적을 달성했습니다.", 1);
                break;


            case 8:
                Change_Alpha_Secretary(Alpha_Secretary == true);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == false);
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("목적을 이미 달성했다고?", 1);
                break;

            case 9:
                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);

                NPC_1.gameObject.SetActive(true);
                _name.text = "바포니스니르";
                _index.DOText("", 1);
                _index.DOText("당신들의 수준으로는 저희를 막는 것은 불가능합니다.", 1);
                break;

            case 10:

                _name.text = "바포니스니르";
                _index.DOText("", 1);
                _index.DOText("지금 이 순간만큼은 당신들이 이겼다고 생각하겠지만, 당신들의 멸망은 필연적입니다.", 1);
                break;

            case 11:
                Change_Alpha_Secretary(Alpha_Secretary == true);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == false);
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("...", 1);
                break;

            case 12:
                Change_Alpha_Secretary(Alpha_Secretary == false);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == true);
                _name.text = "바포니스니르";
                _index.DOText("", 1);
                _index.DOText("제가 아무런 준비도 없이 이곳에 공격을 왔을 것으로 생각했습니까?", 1);
                break;


            case 13:
                Change_Alpha_Secretary(Alpha_Secretary == true);
                Change_Alpha_SNPC_1(Alpha_NPC_1 == false);
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("뭐라고?", 1);
                break;

            case 14:

                _name.text = "바포니스니르";
                _index.DOText("", 1);
                _index.DOText("저의 역할은 그저 당신들의 시선을 돌리기 위한 미끼 역할일 뿐입니다.", 1);
                break;


            //점차 어두워지는 파트

            case 15:
                animator.SetBool("FadeIn", false);
                animator.SetBool("FadeOff", true);

                break;

            case 16:


                NPC_1.gameObject.SetActive(false);
                Secretary.gameObject.SetActive(false);

                _name.text = "바포니스니르";
                _index.DOText("", 1);
                _index.DOText("이것으로 제가 할 일은 완수했습니다. 다음은 당신에게 맡기겠습니다.", 1);
                break;


            case 17:
                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("그동안 고생했어, 다음은 나한테 맡겨줘 바포니스니르.", 1);
                break;

            case 18:
                _name.text = "바포니스니르";
                _index.DOText("", 1);
                _index.DOText("그럼, 최후의 발버둥을 쳐주겠습니다 ETI…", 1);
                break;

            case 19:
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("네 녀석 설마?!", 1);
                break;

            case 20:
                _name.text = "마리아";
                _index.DOText("", 1);
                _index.DOText("전원, 그 자리에서 대피해라! 놈이 자폭을 하려고 한다!", 1);
                break;

            




            case 21:
                //[통신이 꺼질 때 들리는 효과음] 컷신 텍스트가 출력과 동시에 들리도록 설정
                //페이드 인
                animator.SetBool("FadeIn", true);
                animator.SetBool("FadeOff", false);
                _name.text = "";
                _index.DOText("", 1);
                _index.DOText("...통신 중단", 1);
                break;

            case 22:
                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("...그 녀석도 참 고집이 세단 말이야, 뭐 그 녀석 답기는 하지만 말이야.", 1);
                break;

            case 23:
                _name.text = "???";
                _index.DOText("", 1);
                _index.DOText("적어도, 앞으로 나를 방해할 친구는 없겠네…", 1);
                break;


            case 24:
                UI_Dialoue.gameObject.SetActive(false);
                animator.SetBool("FadeIn", false);
                animator.SetBool("FadeOff", true);

                _name.text = "";
                _index.DOText("", 1);


                Timer += Time.deltaTime;
                if(Timer > 3)
                {
                    //씬 체인지
                }


                break;






            default:
                //_index.DOText("", 1);
                _index.text = "대화 마무리. 여기서 창 종료 여기서 씬 변경.";
                break;


        }
    }




    public void InputCountNum()
    {
        CountClick += 1;

        Debug.Log(CountClick);
    }

    private void Change_Alpha_Secretary(bool Alpha_Secretary)
    {


        if(Alpha_Secretary == true)
        {
            Secretary.GetComponent<Image>().color = new Color(0.6f, 0.6f, 0.6f);
        }

        if(Alpha_Secretary == false)
        {
            Secretary.GetComponent<Image>().color = new Color(1, 1, 1);
        }


        //if (Alpha_Secretary == true) {      //알파 온
        //    Color color_Secretary = Secretary_image.color;
        //    for (float i = 1.0f; i >= 0.6f; i -= 0.01f)
        //    {
        //        color_Secretary.r = i;
        //        Secretary_image.color = color_Secretary;
        //    }
        //}

        //else if(Alpha_Secretary == false){  //알파 오프
        //    Color color_Secretary = Secretary_image.color;
        //    for (float i = 0.6f; i >= 1.0f; i += 0.01f)
        //    {
        //        color_Secretary.a = i;
        //        Secretary_image.color = color_Secretary;
        //    }
        //}
    }

    private void Change_Alpha_SNPC_1(bool Alpha_NPC_1)
    {
        if(Alpha_NPC_1 == true)
        {
            NPC_1.GetComponent<Image>().color = new Color(0.6f, 0.6f, 0.6f);
        }

        if(Alpha_NPC_1 == false)
        {
            NPC_1.GetComponent<Image>().color = new Color(1, 1, 1);
        }
    }





}
