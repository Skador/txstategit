import java.util.ArrayList;

/**
 * Created by Skador on 2/27/2017.
 */
public class PhoneBookEntryTest {
  public static void main(String[] args) {
    int count = 0;

    ArrayList<PhoneBookEntry> phoneBook = new ArrayList<PhoneBookEntry>();

    phoneBook.add(new PhoneBookEntry("Cody", "1234567890"));
    phoneBook.add(new PhoneBookEntry("Steve", "5231231234"));
    phoneBook.add(new PhoneBookEntry("Tim", "1987654321"));
    phoneBook.add(new PhoneBookEntry("Paul", "5456781231"));
    phoneBook.add(new PhoneBookEntry("Michelle", "1234567890"));

    for(int i = 0; phoneBook.size() > i; i++){
      count += 1;
      System.out.println("Entry: " + count + " " + phoneBook.get(i).getpName() + " " + phoneBook.get(i).getpNumber());
    }

  }
}
