import java.util.Scanner;

/**
 * Created by Skador on 2/1/2017.
 */
public class squares {
  public static void main(String[] args) {
    int number, total = 0;
    System.out.println("Please enter a number");
    Scanner keyboard = new Scanner(System.in);
    number = keyboard.nextInt();

    System.out.println("Number Squared Total");
    System.out.println("---------------------------");
    for (int x = 1; x <= number; x++){
      total+=x;
      System.out.println( x + "\t\t" + x * x + "\t\t" + total);
    }
  }
}
