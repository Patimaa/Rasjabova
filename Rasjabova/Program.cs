using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rasjabova
{
    public class Employee
    {
        //Поля ФИО и зарплаты
        private string fio { get; set; }
        private decimal salary { get; set; }

        //Свойства
        public string FIO
        {
            get
            {
                return fio;
            }
            set
            {
                fio = value;
            }
        }
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }
        //Конструкторы
        public Employee()
        {

        }
        public Employee(string f, decimal s)
        {
            fio = f;
            salary = s;
        }
        public void Show()
        {
            Console.WriteLine($"Сотрудник: ФИО {fio}, заработная плата: {salary}$");
        }
        class Program
        {
            static void Main(string[] args)
            {
                //Создание нового экземпляра объекта класса Employee
                Employee Rab = new Employee("Раджабова Патима Омаровна", 25000);

                //Вызов метода Show
                Rab.Show();
                Console.ReadKey();
            }
        }
    }
}
