import java.util.Scanner;

/**
 * Created by Skador on 1/25/2017.
 */
public class SwitchDemo {
  public static void main(String[] args) {
    int number;
    double mySalary = 2300.75;
    double myWorkingHours = 123.768;
    int number1 = 5, number2 = 2;
    double result;
    final double INTEREST_RATE=0.069; //Constant!!!

    Student stud1 = new Student();
    stud1.setFirstName("John");
    stud1.setLastName("Cena");
    stud1.setStudId(1231241232);

    System.out.println("Student " + stud1.getFirstName() + " " + stud1.getLastName() + "'s ID is " + stud1.getStudId());
/**
    Account blar = new Account(2);
    System.out.println(blar.getVar1());




    Scanner keyboard = new Scanner(System.in);
    System.out.println("enter 1, 2, or 3");
    number = keyboard.nextInt();

    switch(number){
      case 1:
        System.out.println("You entered 1");
        break;
      case 2:
        System.out.println("You entered 2");
        break;
      case 3:
        System.out.println("You entered 3");
        break;
      default:
        System.out.println("You entered something else than 1, 2, or 3");
    }
    System.out.printf("Your Salary is %4.2f dollars a month for %3.3f hours.\n", mySalary, myWorkingHours);

    result = (double)number1/number2;
    System.out.println(result);

    System.out.println((int)myWorkingHours);
    System.out.println(Math.round(myWorkingHours));
    System.out.println(INTEREST_RATE*mySalary);
 */
  }
}
