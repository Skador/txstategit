/**
 * Created by Skador on 3/29/2017.
 */
public class NegativeStartingBalanceException extends Exception {
  public NegativeStartingBalanceException() {
    super("Error: You have entered a negative starting balance");
  }

  public NegativeStartingBalanceException(double s){
    super("Error: You have entered a negative balance of " + s);
  }


}
