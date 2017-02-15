import javax.swing.*;
import java.util.Scanner;

/**
 * Created by Skador on 1/23/2017.
 */
public class Division {

  public static void main(String[] args){
    String number1, number2;
    double num1, num2;
    double quotient;

    number1 = JOptionPane.showInputDialog("What is your first number? ");
    num1 = Double.parseDouble(number1);
    number2 = JOptionPane.showInputDialog("What is your second number? ");
    num2 = Double.parseDouble(number2);
    if (num2 == 0) {
      JOptionPane.showMessageDialog(null, "Division by zero is not possible.");
      JOptionPane.showMessageDialog(null, "Please run the program again and enter " +
          "a number other than zero");
    } else {
      quotient = num1 / num2;
      JOptionPane.showMessageDialog(null, "The result is " + quotient);
    }
    System.exit(0);
  }
}
