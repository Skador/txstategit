import java.util.Scanner;

/**
 * Created by Skador on 3/1/2017.
 */
public class KilometersMilesTest {
  public static void main(String[] args) {

    double miles;
    double kilom;

    Scanner keyboard = new Scanner(System.in);
    System.out.println("Please enter the distance in miles");
    kilom = keyboard.nextDouble();
    keyboard.nextLine();
    System.out.println("The converted distance is " + Metric.milesToKilometers(kilom));
    System.out.println("Please enter the distance in kilometers");
    miles = Metric.kilometersToMiles(keyboard.nextDouble());
    System.out.println("The converted distance is " + miles);


  }
}
