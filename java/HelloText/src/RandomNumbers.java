import java.util.Random;

/**
 * Created by Skador on 2/1/2017.
 */
public class RandomNumbers {
  public static void main(String[] args) {
    int number1, number2;

    Random randNumbers = new Random();
    number1 = randNumbers.nextInt(10);
    number2 = randNumbers.nextInt(10);

    System.out.println(number1 + " " + number2);

  }
}
