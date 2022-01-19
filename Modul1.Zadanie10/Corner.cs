using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1.Zadanie10
{
    class Corner
    {
        // переменные внутри класса, закрытые
        private double gradus;  
        private double min;      
        private double sec;
        // ствойства, открытые
        public double Gradus   
        {
            // действие при получении свойства, возврат в значение поля
            get 
            {
                return gradus; 
            }
            // действие при установки свойства
            set 
            {
                gradus = value % 360;
            }
        }
        public double Min
        {
            get
            {
                return min;
            }
            set
            {
                // в градусы накапливаем если больше 60 мин, а затем остаток от деления - в минуты
                Gradus += value / 60; 
                min = value % 60;  
            }
        }
        public double Sec
        {
            get
            {
                return sec;
            }
            set
            {
               // накапливаем в свойства Min, остаток от деления - в секунды
                Min += value / 60; 
                sec = value % 60;
            }
        }
        // конструктор с типом double, открытый. Помещены значения мер угла
        public Corner(double gradus, double min, double sec) 
        {
            this.Gradus = gradus;  
            this.Min = min;        
            this.Sec = sec;        
        }
        // метод перевода мер угла градусы в радианы
        public double ToRadians()  
        {
            // возврат значения в радианы
            return (gradus + (min + sec / 60) / 60) * Math.PI / 180;  
        }
    }
}

