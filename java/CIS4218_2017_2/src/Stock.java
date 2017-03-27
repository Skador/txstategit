/**
 * Created by Skador on 3/8/2017.
 */
public class Stock {
  private String symbol;
  private double sharePrice;

  public Stock(Stock objectStock){
    symbol = objectStock.symbol;
    sharePrice = objectStock.sharePrice;
  }


  public Stock(String sym, double shrPrice) {
    symbol = sym;
    sharePrice = shrPrice;
  }

  public String getSymbol() {
    return symbol;
  }

  public double getSharePrice() {
    return sharePrice;
  }

  @Override
  public String toString() {
    String str = "Trading symbol: " + symbol +
        "\nShare price: " + sharePrice;

    return str;
  }
}
