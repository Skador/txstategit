/**
 * Created by Skador on 2/8/2017.
 */
public class TestCellPhone {
  public static void main(String[] args) {
    CellPhone nokia = new CellPhone("nokia", "X324", 432.34);

    System.out.println("Manu: " + nokia.getManufact() + "" +
        " Model: " + nokia.getModel() + " Price: " + nokia.getRetailPrice());
  }
}
