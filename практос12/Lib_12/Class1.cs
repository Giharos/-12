using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_12
{
    public class Koordinat
    {
        //Поля класса
        private int _aFirstNumber;
        private int _aSecondNumber;
        //Конструктор
        public Koordinat(int aFirstNumber, int aSecondNumber)
        {
            _aFirstNumber = aFirstNumber;
            _aSecondNumber = aSecondNumber;
        }
        //Св-ва 1-го числа
        public int FirstNumber
        {
            //Возвращаем значение
            get
            {
                return _aFirstNumber;
            }
            //Устанавливаем значение
            set
            {
                _aFirstNumber = value;
            }
        }
        //Св-ва 2-го числа
        public int SecondNumber
        {
            //Возвращаем значение
            get
            {
                return _aSecondNumber;
            }
            //Устанавливаем значение
            set
            {
                _aSecondNumber = value;
            }
        }
        public double Rasstoyanie(Koordinat tochki, Koordinat tochki2)
        {
            double result = Math.Sqrt((tochki2.FirstNumber - tochki.FirstNumber) ^ 2 + (tochki2.SecondNumber + tochki.SecondNumber) ^ 2);
            return result;
        }
    }
    public class Chislo
    {
        //Поля класса
        private int _aFirstNumber;

        public Chislo(int aFirstNumber)
        {
            _aFirstNumber = aFirstNumber;
        }

        //Св-ва 1-го числа
        public int FirstNumber
        {
            //Возвращаем значение
            get
            {
                return _aFirstNumber;
            }
            //Устанавливаем значение
            set
            {
                _aFirstNumber = value;
            }
        }
        public int GetMultiplay()
        {
            int rez = _aFirstNumber /= 100;
            return rez;
        }
    }
}

