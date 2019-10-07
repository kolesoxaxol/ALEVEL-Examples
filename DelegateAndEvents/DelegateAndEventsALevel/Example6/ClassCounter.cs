using System;
using System.Collections.Generic;
using System.Text;

namespace Example6
{
    class ClassCounter  //Это класс - в котором производится счет.
    {

        //Синтаксис по сигнатуре метода, на который мы создаем делегат: 
        //delegate <выходной тип> ИмяДелегата(<тип входных параметров>);
        //Мы создаем на void Message(). Он должен запуститься, когда условие выполнится.

        public delegate void MethodContainer();
        //Событие OnCount c типом делегата MethodContainer.
        public event MethodContainer onCount;


        public void Count()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == 71)
                {
                    onCount();
                }
            }
            //Здесь будет производиться счет
        }
    }
}
