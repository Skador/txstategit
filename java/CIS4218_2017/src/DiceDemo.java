/**
 * Created by Skador on 2/13/2017.
 */
public class DiceDemo {
  public static void main(String[] args) {
    final int DIE1_SIDES = 6;
    final int DIE2_SIDES = 12;
    final int DIE3_SIDES = 20;
    final int MAX_ROLLS = 5;

    Die die1 = new Die(DIE1_SIDES);
    Die die2 = new Die(DIE2_SIDES);
    Die die3 = new Die(DIE3_SIDES);

    System.out.println("This simulates the rolling of a " + DIE1_SIDES + " sided die, " +
        "a " + DIE2_SIDES + " sided die, and a " + DIE3_SIDES + " sided die.");

    System.out.println("Initial value of the dice: ");
    System.out.println(die1.getValue() + " " + die2.getValue() + " " + die3.getValue());

    System.out.println("Rolling the dice " + MAX_ROLLS + " times.");

    for (int x = 0; x < MAX_ROLLS; x++){
      die1.roll();
      die2.roll();
      die3.roll();

      System.out.println(die1.getValue() + " " + die2.getValue() + " " + die3.getValue());
    }
  }
}
