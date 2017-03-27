/**
 * Created by Skador on 3/1/2017.
 */
public class Countable {
  public static int instCount = 0;

  public Countable(){
    instCount++;
  }

  public int getCounts(){
    return instCount;
  }
}
