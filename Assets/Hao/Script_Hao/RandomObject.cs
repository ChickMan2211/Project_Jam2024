using UnityEngine;
using System.Collections;

public class RandomObject : MonoBehaviour
{

    // Khai báo một mảng gameobject để lưu trữ 6 object khác nhau
    public GameObject[] objects;

    // Khai báo ba điểm "targetpoint" để thay đổi object
    public Transform point1;
    public Transform point2;
    public Transform point3;

    // Khai báo một biến để lưu trữ object hiện tại ở mỗi điểm
    private GameObject currentObject1;
    private GameObject currentObject2;
    private GameObject currentObject3;

    // Hàm này được gọi khi bắt đầu chạy game
    void Start()
    {
        int randomIndex1 = Random.Range(0, objects.Length);
        int randomIndex2 = Random.Range(0, objects.Length);
        int randomIndex3 = Random.Range(0, objects.Length);
        // Gán object đầu tiên trong mảng cho mỗi điểm
        currentObject1 = Instantiate(objects[randomIndex1], point1.position, point1.rotation) as GameObject;
        currentObject2 = Instantiate(objects[randomIndex2], point2.position, point2.rotation) as GameObject;
        currentObject3 = Instantiate(objects[randomIndex3], point3.position, point3.rotation) as GameObject;
    }

    // Hàm này được gọi mỗi khung hình
    void Update()
    {
        // Kiểm tra nếu nhấn phím 1
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            // Hủy object hiện tại ở điểm 1
            Destroy(currentObject1);
            // Chọn một object ngẫu nhiên trong mảng
            int randomIndex = Random.Range(0, objects.Length);
            // Tạo object mới ở điểm 1
            currentObject1 = Instantiate(objects[randomIndex], point1.position, point1.rotation) as GameObject;
        }

        // Làm tương tự với phím 2 và 3
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Destroy(currentObject2);
            int randomIndex = Random.Range(0, objects.Length);
            currentObject2 = Instantiate(objects[randomIndex], point2.position, point2.rotation) as GameObject;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Destroy(currentObject3);
            int randomIndex = Random.Range(0, objects.Length);
            currentObject3 = Instantiate(objects[randomIndex], point3.position, point3.rotation) as GameObject;
        }
    }
}
