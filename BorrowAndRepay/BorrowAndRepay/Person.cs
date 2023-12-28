using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BorrowAndRepay
{
    class Person
    {
        public String name;
        public int money;

        public Person(string name, int money)
        {
            this.name = name;
            this.money = money;
        }

        public void borrow(Person person, int money)
        {   
            if (person.money >= money)
            {
                person.money -= money;
                this.money += money;
            }
        }

        public void repay(Person person, int money)
        {
            if (this.money >= money)
            {
                this.money -= money;
                person.money += money;
            }
        }


    }
}
