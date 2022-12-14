using System;
namespace Talal{
    ////////////task (1)
    public class Person{
    public  String Name ;
    public  int Age;
        public Person(String name ,int age){
            Name=name;
            Age=age;
        }
    
        public virtual void print(){
            
            Console.WriteLine("My name is "+ Name+ ",My age is "+Age);

        }


    }
    public class Student : Person{
        int Year;
        float Gpa;
        public Student(String name,int age , int year, float gpa) : base(name,age){
            Year= year;
            Gpa=gpa;

        }

        public override void print()
        {
            Console.WriteLine("My name is "+ Name+ ",My age is "+Age+",My gpa is "+Gpa);
        }
    }
    ////////////////////// task (2)
    public class Staff : Person{
        double Salary ;
        int JoinYear;
        public Staff(String name , int age ,double salary,int joinyear): base (name , age){
            Salary=salary;
            JoinYear=joinyear;

        }
        public override void print()
        {
        Console.WriteLine("My name is "+ Name+ ",My age is "+Age+", and my salary is "+Salary );
        }
    }
        public class Database {
        private  int CountIndex = 0;
        public int Size;
        
        public Person[] People ;
        public Database(int size){
            Size=size;
        People =new Person[size];

        }
        public void AddStudent(Student student){

            People[CountIndex++]= student; ////first element in array  will take value from object student 

        }
        public void AddStaff(Staff staff){

            People[CountIndex++]= staff; ////first element in array  will take value from object staff

        }
        public void AddPerson(Person person){

            People[CountIndex++]= person;

        }
        public void print_everthing(){
            for (int i=0;i< CountIndex ;i++){
                People[i].print();
            }

        }
    }
	class task{
	public static void Main(String []arge){
        Console.WriteLine("Enter the number of People :  ");
        int size = int.Parse(Console.ReadLine());
        var data_b= new Database(size);
                ////Take Values from User ::
        while(true){
            Console.Write("student ---(1) |||| Staff ---(2) |||| Person---(3)|||| Print everything ---(4)  ::::::::");
            int option = int.Parse(Console.ReadLine());
            switch(option) {
                case 1: 
                Console.WriteLine("Enter the Name :  ");
                String N1 = Console.ReadLine();
                Console.WriteLine("Enter the Age :  ");
                int A1 = int.Parse( Console.ReadLine());
                Console.WriteLine("Enter the Year :  ");
                int Y1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Gpa :  ");
                float G1 = float.Parse(Console.ReadLine());
                var student = new Student(N1,A1,Y1,G1);
                data_b.AddStudent(student);
                //student.print();
                break;
                case 2: 
                Console.WriteLine("Enter the Name :  ");
                String N2 = Console.ReadLine();
                Console.WriteLine("Enter the Age :  ");
                int A2 = int.Parse( Console.ReadLine());
                Console.WriteLine("Enter the Salary :  ");
                double S2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the JoinYear :  ");
                int J2 = int.Parse(Console.ReadLine());
                var staff = new Staff(N2,A2,S2,J2);
                data_b.AddStaff(staff);
                //staff.print();
                break;
                case 3:
                Console.WriteLine("Enter the Name :  ");
                String N3 = Console.ReadLine();
                Console.WriteLine("Enter the Age :  ");
                int A3 = int.Parse( Console.ReadLine());
                var person =new Person(N3,A3);
                data_b.AddPerson(person);

                break;
                case 4:
                data_b.print_everthing();
                break;
                default:
                Console.WriteLine("Error input !!!!!!!!!");
                break;

            }
        }

	}
	}
}