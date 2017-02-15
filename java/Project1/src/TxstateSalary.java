import java.io.*;
import java.util.Scanner;

/**
 * Created by Skador on 2/15/2017.
 */
public class TxstateSalary {
  public static void main(String[] args) throws IOException {
    String firstName, lastName, fullName;
    int monthlySalary, monthsOfPayment;
    Scanner keyboard = new Scanner(System.in);

    System.out.println("Welcome to the Texas State Yearly Salary Calculator");

    System.out.println("First, we'll need your name.");
    System.out.print("Please enter your first name: ");
    firstName = keyboard.nextLine();
    System.out.print("Please enter your last name: ");
    lastName = keyboard.nextLine();

    fullName = firstName + " " + lastName;

    System.out.println("Now, we'll need your monthly information.");

    System.out.print("Please enter your monthly salary: ");
    monthlySalary = keyboard.nextInt();
    keyboard.nextLine();
    System.out.print("Please enter the number of payment months: ");
    monthsOfPayment = keyboard.nextInt();
    keyboard.nextLine();
    System.out.println("");
    System.out.println("Your yearly salary is: " + YearlySalary(fullName, monthlySalary, monthsOfPayment));

  }

  public static double YearlySalary(String fullName, int monthlySal, int monthsOfPay) throws IOException{
    double yearlySalary;
    File filename = new File("../yearlySalary.txt");
    FileWriter fwriter = new FileWriter(filename, true);
    PrintWriter outputFile = new PrintWriter(fwriter);

    yearlySalary = monthlySal*monthsOfPay;

    if(filename.length() == 0){
      outputFile.println("Consumer Name\tMonthly Salary\tMonths of Pay\tYearly Salary");
    }
    outputFile.println(fullName + "\t" + monthlySal  + "\t" + monthsOfPay + "\t" + yearlySalary);
    outputFile.close();

    return yearlySalary;
  }
}