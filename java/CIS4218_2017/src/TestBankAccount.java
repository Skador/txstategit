import java.util.Scanner;

/**
 * Created by Skador on 2/15/2017.
 */
public class TestBankAccount {
  public static void main(String[] args) {
    BankAccount mAccount1 = new BankAccount();
    System.out.println(mAccount1.getBalance());

    BankAccount mAccount2 = new BankAccount(10.0);
    System.out.println(mAccount2.getBalance());

    String amount = "20";

    BankAccount mAccount3 = new BankAccount(amount);
    System.out.println(mAccount3.getBalance());

    BankAccount mAccount4 = new BankAccount(4);
    System.out.println(mAccount4.getBalance());

  }
}
