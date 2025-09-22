using UnityEngine;
using UnityEngine.UI;



public class GameManager : MonoBehaviour
{
    public GameObject mainImage;        // �̹����� ��Ƶδ� GameObject ����
    public Sprite gameOverSpr;          // Game Over �̹���
    public Sprite gameClearSpr;         // Game Clear �̹���
    public GameObject panel;            // �г�
    public GameObject restartButton;    // Restart ��ư
    public GameObject nextButton;       // Next ��ư

    Image titleImage;                   // �̹����� ǥ���ϴ� Image ������Ʈ

    private void Start()
    {
        // �̹��� �����
        Invoke("InactiveImage", 1.0f); // 1�� �� InactiveImage �Լ� ȣ��
        // ��ư(�г�)�� �����
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
            // ���� Ŭ����
            mainImage.SetActive(true); // �̹��� ǥ��
            panel.SetActive(true); // ��ư(�г�) ǥ��
            // Restart ��ư�� ��Ȱ��ȭ
            Button bt = restartButton.GetComponent<Button>();   // Button ������Ʈ ��������
            bt.interactable = false;    // ��ư ��Ȱ��ȭ
            mainImage.GetComponent<Image>().sprite = gameClearSpr; // ���� Ŭ���� �̹��� ����
            PlayerController.gameState = "gameend"; // ���� ����
        }
        else if (PlayerController.gameState == "gameover")
        {
            // ���� ����
            mainImage.SetActive(true);
            panel.SetActive(true);
            // Next��ư�� ��Ȱ��ȭ
            Button bt = nextButton.GetComponent<Button>();   // Button ������Ʈ ��������
            bt.interactable = false;    // ��ư ��Ȱ��ȭ
            mainImage.GetComponent<Image>().sprite = gameOverSpr; // ���� ���� �̹��� ����
            PlayerController.gameState = "gameend"; // ���� ����
        }
        else if (PlayerController.gameState == "playing")
        {
            // ���� ��
        }
    }


}
