/**
 * Created by Skador on 2/27/2017.
 */
public class PhoneBookEntry {

  private String pName;
  private String pNumber;


  public PhoneBookEntry() {
    pName = "";
    pNumber = "";
  }

  public PhoneBookEntry(String name, String number) {
    pName = name;
    pNumber = number;
  }

  public String getpName() {
    return pName;
  }

  public void setpName(String name) {
    pName = name;
  }

  public String getpNumber() {
    return pNumber;
  }

  public void setpNumber(String number) {
    pNumber = number;
  }
}
