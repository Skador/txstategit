/**
 * Created by Skador on 2/8/2017.
 */
public class CellPhone {
  private String manufact, model;
  private double retailPrice;

  public CellPhone(String man, String mod, double price){
    manufact = man;
    model = mod;
    retailPrice = price;
  }

  public String getManufact() {
    return manufact;
  }

  public void setManufact(String man) {
    manufact = man;
  }

  public String getModel() {
    return model;
  }

  public void setModel(String mod) {
    model = mod;
  }

  public double getRetailPrice() {
    return retailPrice;
  }

  public void setRetailPrice(double price) {
    retailPrice = price;
  }
}
