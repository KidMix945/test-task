using static TestTask.Enumeration;

namespace TestTask
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public List<Money> MoneyList { get; set; }

        public Person(string name, int age, Gender gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
            MoneyList = new List<Money>();
        }

        public void AddMoney(Money money)
        {
            Money existingMoney = MoneyList.FirstOrDefault(m => m.Currency == money.Currency);
            if (existingMoney != null)
            {
                existingMoney.Amount += money.Amount;
            }
            else
            {
                MoneyList.Add(money);
            }
        }

        public void SpendMoney(Money money)
        {
            foreach (var m in MoneyList)
            {
                if (m.Currency == money.Currency)
                {
                    if (m.Amount >= money.Amount)
                    {
                        m.Amount -= money.Amount;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно средств");
                    }
                }
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}\nAge: {Age}\nGender: {Gender}\nMoney:");

            foreach (var money in MoneyList)
            {
                if (money.Currency == Currency.RUB)
                {
                    Console.WriteLine($"{money.Amount} RUB");
                }
                if (money.Currency == Currency.USD)
                {
                    Console.WriteLine($"{money.Amount} USD");
                }
                if (money.Currency == Currency.EUR)
                {
                    Console.WriteLine($"{money.Amount} EUR");
                }
            }
            Console.WriteLine();
        }
    }
}
