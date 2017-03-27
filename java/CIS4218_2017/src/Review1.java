import java.util.ArrayList;

/**
 * Created by Skador on 2/20/2017.
 */
public class Review1 {
  public static void main(String[] args) {

    int[] numbers = new int[3];

    ArrayList<String> nameList = new ArrayList<String>();

    BankAccount myAccount = CreateAccount(55);
    System.out.println("CreateAccount");
    System.out.println(myAccount.getBalance());

    BankAccount[] myAcc = CreateArrayAcc(33, 44, 55);

    System.out.println("\nCreateArrayAcc");
    for(int i = 0; i < myAcc.length; i++){
      System.out.println(myAcc[i].getBalance());
    }

    nameList.add("John");
    nameList.add("Bill");
    nameList.add("Carl");

    System.out.println("\nArrayList Array");
    for(int i = 0; i < nameList.size(); i++){
      System.out.println(nameList.get(i));
    }

    ArrayList<BankAccount> myAccountList = new ArrayList<BankAccount>();

    myAccountList.add(new BankAccount(101));
    myAccountList.add(new BankAccount("51"));

    myAccountList.get(0).setBalance(77.32);

    System.out.println("\nMyAccountList");
    for(int i = 0; i <myAccountList.size(); i++){
      System.out.println(myAccountList.get(i).getBalance());
    }

    BankAccount[] myAccounts = new BankAccount[2];

    //An old way to handle everything
    //myAccounts[0] = new BankAccount(100);
    //myAccounts[1] = new BankAccount("50");

    //A cleaner way to handle the accounts
    for(int i = 0; i < myAccounts.length; i++){
      myAccounts[i] = new BankAccount();
    }

    myAccounts[0].setBalance(100.0);
    myAccounts[1].setBalance("50");

    System.out.println("\nMyaccounts");
    for(int i = 0; i < myAccounts.length; i++){
      System.out.println(myAccounts[i].getBalance());
    }

  }

  public static BankAccount CreateAccount(double startBalance){
    return new BankAccount(startBalance);
  }

  public static BankAccount[] CreateArrayAcc(int a, int b, int c){
    BankAccount[] myBA = new  BankAccount[3];
    myBA[0] = new BankAccount(a);
    myBA[1] = new BankAccount(b);
    myBA[2] = new BankAccount(c);
    return myBA;
  }

}
