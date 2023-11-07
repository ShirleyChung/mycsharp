// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var john = new Person("John");
john.sayHi();

john.jump();

public class Person  {

    private Thread? act_ = null; 
    string myName_;

    public Person (string name) {
        myName_ = name;
        act_ = new Thread(new ThreadStart(run));
    }
    public void sayHi() {
        Console.WriteLine("Hi! I am {0}", myName_);
    }

    public void jump() {
        act_?.Start();
        act_?.Join();
    }

    private void run() {
        int count = 10;
        while(count-- > 0) {
            Console.WriteLine("I am Jumping!");
            Thread.Sleep(1000);
        }
    }
}
