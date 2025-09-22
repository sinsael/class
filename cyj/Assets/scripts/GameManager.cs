using UnityEngine;
using UnityEngine.UI;



public class GameManager : MonoBehaviour
{
    public GameObject mainImage;        // 이미지를 담아두는 GameObject 변수
    public Sprite gameOverSpr;          // Game Over 이미지
    public Sprite gameClearSpr;         // Game Clear 이미지
    public GameObject panel;            // 패널
    public GameObject restartButton;    // Restart 버튼
    public GameObject nextButton;       // Next 버튼

    Image titleImage;                   // 이미지를 표시하는 Image 컴포넌트

    private void Start()
    {
        // 이미지 숨기기
        Invoke("InactiveImage", 1.0f); // 1초 후 InactiveImage 함수 호출
        // 버튼(패널)을 숨기기
        panel.SetActive(false);
    }

    private void InactiveImage()
    {
        mainImage.SetActive(false);
    }

    private void Update()
    {
        if (PlayerController.gameState == "gameclear")
        {
            // 게임 클리어
            mainImage.SetActive(true); // 이미지 표시
            panel.SetActive(true); // 버튼(패널) 표시
            // Restart 버튼을 비활성화
            Button bt = restartButton.GetComponent<Button>();   // Button 컴포넌트 가져오기
            bt.interactable = false;    // 버튼 비활성화
            mainImage.GetComponent<Image>().sprite = gameClearSpr; // 게임 클리어 이미지 설정
            PlayerController.gameState = "gameend"; // 게임 종료
        }
        else if (PlayerController.gameState == "gameover")
        {
            // 게임 오버
            mainImage.SetActive(true);
            panel.SetActive(true);
            // Next버튼을 비활성화
            Button bt = nextButton.GetComponent<Button>();   // Button 컴포넌트 가져오기
            bt.interactable = false;    // 버튼 비활성화
            mainImage.GetComponent<Image>().sprite = gameOverSpr; // 게임 오버 이미지 설정
            PlayerController.gameState = "gameend"; // 게임 종료
        }
        else if (PlayerController.gameState == "playing")
        {
            // 게임 중
        }
    }


}
