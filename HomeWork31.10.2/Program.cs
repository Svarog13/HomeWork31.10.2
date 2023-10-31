using System;

class Program
{
    static void Main(string[] args)
    {
        Worker worker = new Worker("John Doe", "Regular employee", 50000);
        President president = new President("Jane Smith", "Company president", 200000);
        Security security = new Security("Tom Security", "Security staff", 35000);
        Manager manager = new Manager("Alice Manager", "Department manager", 80000);
        Engineer engineer = new Engineer("Bob Engineer", "Software engineer", 75000);

        worker.Print();
        System.Console.WriteLine();

        president.Print();
        System.Console.WriteLine();

        security.Print();
        System.Console.WriteLine();

        manager.Print();
        System.Console.WriteLine();

        engineer.Print();
    }
}

class Worker
{
    private string name;
    private string discription;
    private int salary;

    public Worker(string name, string discription, int salary)
    {
        this.name = name;
        this.discription = discription;
        this.salary = salary;
    }

    public virtual void Print()
    {
        System.Console.WriteLine($"Worker has name: {name}");
        System.Console.WriteLine($"Worker has discription: {discription}");
        System.Console.WriteLine($"Worker has salary: {salary:C}");
    }
}

class President : Worker
{
    public President(string name, string discription, int salary) : base(name, discription, salary) { }
}

class Security : Worker
{
    public Security(string name, string discription, int salary) : base(name, discription, salary) { }

}

class Manager : Worker
{
    public Manager(string name, string discription, int salary) : base(name, discription, salary) { }

}

class Engineer : Worker
{
    public Engineer(string name, string discription, int salary) : base(name, discription, salary) { }

}