using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextChangerRoom2 : MonoBehaviour
{
    public GameObject dano1;
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    public void Dano1()
    {

        switch (text1.text)
        {
            case "Задача 1":
                text1.text = "Задача 1+";
                text2.text = "Три кубика из железа, меди и свинца имеют одинаковые размеры. Какой из них самый тяжелый? Плотность железа - 7874 кг/м^3, меди - 8940 кг/м^3, свинца - 11340 кг/м^3";
                dano1.SetActive(true);
                break;
            case "Задача 1+":
                text1.text = "Задача 1";
                dano1.SetActive(false);
                break;

            case "Задача 2":
                text1.text = "Задача 2+";
                text2.text = "Жидкость объемом 125 л имеет массу 100 кг. Определите ее плотность. (1 м^3 = 1000 л)";
                dano1.SetActive(true);
                break;
            case "Задача 2+":
                text1.text = "Задача 2";
                dano1.SetActive(false);
                break;

            case "Задача 3":
                text1.text = "Задача 3+";
                text2.text = "Слиток олова размером 30 см х 10 см х 10 см имеет массу 21,9 кг. Какова плотность олова? ";
                dano1.SetActive(true);
                break;
            case "Задача 3+":
                text1.text = "Задача 3";
                dano1.SetActive(false);
                break;

            case "Задача 4":
                text1.text = "Задача 4+";
                text2.text = "Полый медный куб с длиной ребра а = 6 см имеет массу m = 810 г. Какова толщина стенок куба? Плотность меди - 8940 кг/м. Выразите в см";
                dano1.SetActive(true);
                break;
            case "Задача 4+":
                text1.text = "Задача 4";
                dano1.SetActive(false);
                break;

            case "Задача 5*":
                text1.text = "Задача 5+";
                text2.text = "Масса пробирки с водой составляет 50 г. Масса этой же пробирки, заполненной водой, но с куском металла в ней массой 12 г составляет 60,5 г. Определите плотность металла, помещенного в пробирку.";
                dano1.SetActive(true);
                break;
            case "Задача 5+":
                text1.text = "Задача 5*";
                dano1.SetActive(false);
                break;

            case "Задача 6":
                text1.text = "Задача 6+";
                text2.text = "Сколько рейсов должен сделать самосвал грузоподъемностью 5 т, чтобы перевезти 100 м3 гранита? Плотность гранита 2600 кг/м3.";
                dano1.SetActive(true);
                break;
            case "Задача 6+":
                text1.text = "Задача 6";
                dano1.SetActive(false);
                break;

            case "Задача 7":
                text1.text = "Задача 7+";
                text2.text = "В течение двух часов поезд двигался со скоростью 110 км/ч, затем сделал остановку на 10 мин. Оставшуюся часть пути он шел со скоростью 90 км/ч. Какова средняя скорость поезда на всем пути, если он прошел 400 км?(округлите до целых в м/с) ";
                dano1.SetActive(true);
                break;
            case "Задача 7+":
                text1.text = "Задача 7";
                dano1.SetActive(false);
                break;

            case "Задача 8":
                text1.text = "Задача 8+";
                text2.text = "Расстояние между двумя пристанями 144 км. Сколько времени потребуется пароходу для совершения рейса между пристанями туда и обратно, если скорость парохода в стоячей воде 18 км/ч, а скорость течения 3м/с? ";
                dano1.SetActive(true);
                break;
            case "Задача 8+":
                text1.text = "Задача 8";
                dano1.SetActive(false);
                break;

            case "Задача 9":
                text1.text = "Задача 9+";
                text2.text = "Самолет, летящий со скоростью 300 км/ч, в безветренную погоду пролетел расстояние между аэродромами А и В за 2,2 ч. Обратный полет из-за встречного ветра он совершил за 2,4 ч. Определите скорость ветра.(выразите в км/ч) ";
                dano1.SetActive(true);
                break;
            case "Задача 9+":
                text1.text = "Задача 9";
                dano1.SetActive(false);
                break;

            case "Задача 10":
                text1.text = "Задача 10+";
                text2.text = "Длина конвейера 20 м. За какое время вещь, поставленная у начала конвейера, придет к его концу, если скорость движения конвейера 10 см/с? ";
                dano1.SetActive(true);
                break;
            case "Задача 10+":
                text1.text = "Задача 10";
                dano1.SetActive(false);
                break;
        }
    }
}
