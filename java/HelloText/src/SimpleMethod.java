/**
 * Created by Skador on 2/6/2017.
 */
public class SimpleMethod {
  public static void main(String[] args) {
    System.out.println("Hello from the other side 'main method'");
    displayMessage();
    System.out.println("Back in the main method");
  }

  public static void displayMessage() {
    displayMessage2();
    System.out.println("Hello from the inside 'The displayMessage method'");
  }
  public static void displayMessage2() {
    System.out.println("Hello from the INSIDEAALGKSGUPA 'The displayMessage method'");
  }

}
