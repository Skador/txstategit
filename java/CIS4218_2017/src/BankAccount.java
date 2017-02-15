/**
 * Created by Skador on 2/15/2017.
 */
public class BankAccount {
  private double balance;

  public BankAccount() {
    balance = 0.0;
  }

  public BankAccount(double startBalance) {
    balance = startBalance;
  }

  public BankAccount(String startBalance) {
    balance = Double.parseDouble(startBalance);
  }

  public void deposit(double amount) {
    balance += amount;
  }

  public void withdrawl(double amount) {
    balance -= amount;
  }

  public void withdrawl(String str) {
    balance -= Double.parseDouble(str);
  }

  public void setBalance(double b) {
    balance = b;
  }

  public void setBalance(String b) {
    balance = Double.parseDouble(b);
  }

  public double getBalance() {
    return balance;
  }
}
