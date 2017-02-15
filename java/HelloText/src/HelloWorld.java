import java.util.Scanner;

/**
 * Created by Skador on 1/18/2017.
 */
public class HelloWorld {

  public static void main(String[] args) {

    String name;
    Scanner keyboard = new Scanner(System.in);

    System.out.println("What is you age? ");
    int age = keyboard.nextInt();
    System.out.println(age);

    keyboard.nextLine();

    System.out.println("Please enter your name");
    name = keyboard.nextLine();
    System.out.println("Welcome to the Java class " + name + "!");

    int res = PassArg.showSum(4,8);
    System.out.println(res);

    /**
     Playing with a bunch of basic shtuff

    System.out.println("Hello World!!!");

    System.out.println("Hello\n World!!!");

    int value;
    value = 5;
    System.out.println(value);

    float number;
    number = 23.5F;
    System.out.println(number);

    double number2;
    number2 = 23.5;
    System.out.println(number2);

    boolean bool;
    bool = true;
    System.out.println(bool);

    double value2 = value + number2;
    System.out.println(value2);
*/


  }
}
