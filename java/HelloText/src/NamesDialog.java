import javax.swing.*;

/**
 * Created by Skador on 1/23/2017.
 */
public class NamesDialog {

  public static void main(String[] args){
/**
    String firstName;
    int result;

    firstName = JOptionPane.showInputDialog("What is your first name? ");
    JOptionPane.showMessageDialog(null, "Your name is " + firstName);

    firstName = JOptionPane.showInputDialog("What is your age? ");
    result = Integer.parseInt(firstName);
    result = result * 2;
    JOptionPane.showMessageDialog(null, "Double your age is " + result);
 */
    String number1, number2;
    int num2;
    double num1,result;

    number1 = JOptionPane.showInputDialog("What is your first number? ");
    num1 = Double.parseDouble(number1);
    number2 = JOptionPane.showInputDialog("What is your second number? ");
    num2 = Integer.parseInt(number2);
    result = num1 / num2;
    JOptionPane.showMessageDialog(null, "The result is " + result);

    System.exit(0);
  }
}
