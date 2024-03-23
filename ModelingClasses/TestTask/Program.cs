using static TestTask.Enumeration;
using TestTask;

Person tom = new Person("Tom", 30, Gender.Male);
Person max = new Person("Max", 35, Gender.Male);
Person anne = new Person("Anne", 32, Gender.Female);


tom.AddMoney(new Money(1000, Currency.USD));
tom.AddMoney(new Money(1000, Currency.USD));
tom.AddMoney(new Money(3000, Currency.RUB));
tom.AddMoney(new Money(4000, Currency.EUR));

tom.SpendMoney(new Money(500, Currency.USD));
tom.SpendMoney(new Money(2000, Currency.RUB));
tom.SpendMoney(new Money(2000, Currency.EUR));

tom.PrintInfo();


max.AddMoney(new Money(1000, Currency.USD));
max.AddMoney(new Money(3000, Currency.RUB));
max.AddMoney(new Money(12000, Currency.EUR));

max.SpendMoney(new Money(200, Currency.USD));
max.SpendMoney(new Money(1800, Currency.RUB));
max.SpendMoney(new Money(100, Currency.EUR));
max.SpendMoney(new Money(5000, Currency.EUR));

max.PrintInfo();


anne.AddMoney(new Money(1000, Currency.USD));
anne.AddMoney(new Money(3000, Currency.RUB));
anne.AddMoney(new Money(4000, Currency.EUR));


anne.SpendMoney(new Money(500, Currency.USD));
anne.SpendMoney(new Money(1000, Currency.RUB));
anne.SpendMoney(new Money(1000, Currency.EUR));

anne.PrintInfo();