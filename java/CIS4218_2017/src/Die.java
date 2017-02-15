import java.util.Random;

/**
 * Created by Skador on 2/13/2017.
 */
public class Die {
  private int sides, value;

  public Die(int numsides){
    sides = numsides;
    roll();
  }

  public void roll(){
    Random rand = new Random();

    value = rand.nextInt(sides) + 1;
  }

  public int getSides() {
    return sides;
  }

  public int getValue() {
    return value;
  }
}
