import org.omg.PortableInterceptor.DISCARDING;

/**
 * Created by Skador on 2/13/2017.
 */
public class DieArgument {
  public static void main(String[] args) {
    final int SIX_SIDES = 6;
    final int TWENTY_SIDES = 20;

    Die sixDie = new Die(SIX_SIDES);
    Die twentySides = new Die(TWENTY_SIDES);

    rollDie(sixDie);
    rollDie(twentySides);

  }

  public static void rollDie(Die myDie) {
    System.out.println("Rolling a " + myDie.getSides() + " sided die.");
    myDie.roll();

    System.out.println("The die's value: " + myDie.getValue());
  }
}
