using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание базы данных из 20 сотрудников
            Repository repository = new Repository(20);

            // Печать в консоль всех сотрудников
            repository.Print("База данных");

 
            Repository repository1 = new Repository(40);
            repository1.Print("База данных до преобразования");
            repository1.DeleteWorkerByName("Агата");
            repository1.DeleteWorkerByLastName("Ершова");
            repository1.DeleteWorkerByAge(45);
            repository1.DeleteWorkerBySalary(50000);
            repository1.Print("База данных после преобразования");

            Repository repository2 = new Repository(50);
            repository2.Print("База данных до преобразования");
            repository2.DeleteWorkerBySalary(30000);
            repository2.Print("База данных после преобразования");
            Console.ReadKey();

            #region Домашнее задание

            // Уровень сложности: просто
            // Задание 1. Переделать программу так, чтобы до первой волны увольнени в отделе было не более 20 сотрудников

            // Уровень сложности: средняя сложность
            // * Задание 2. Создать отдел из 40 сотрудников и реализовать несколько увольнений, по результатам
            //              которых в отделе болжно остаться не более 30 работников

            // Уровень сложности: сложно
            // ** Задание 3. Создать отдел из 50 сотрудников и реализовать увольнение работников
            //               чья зарплата превышает 30000руб



            #endregion

        }
    }
}
