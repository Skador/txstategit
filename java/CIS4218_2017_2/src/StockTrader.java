import java.util.Scanner;

/**
 * Created by Skador on 3/8/2017.
 */
public class StockTrader {
  public static void main(String[] args) {
    int sharesToBuy;

    Stock xyzCompany = new Stock("XYZ", 9.62);

    Scanner keyboard = new Scanner(System.in);

    System.out.printf("XYZ stock is currently $%,.2f.\n", xyzCompany.getSharePrice());

    System.out.print("How many shares do you want to buy? ");
    sharesToBuy = keyboard.nextInt();
    keyboard.nextLine();

    StockPurchase buy = new StockPurchase(xyzCompany, sharesToBuy);

    System.out.printf("Cost of the stock: $%,.2f.", buy.getCost());
  }
}
