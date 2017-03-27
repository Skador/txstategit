/**
 * Created by Skador on 3/1/2017.
 */
public class StaticDemo {
  public static void main(String[] args) {
    int objCount;

    Countable obj1 = new Countable();
    System.out.println(obj1.getCounts());
    System.out.println("---------------------------");

    Countable obj2 = new Countable();
    System.out.println(obj1.getCounts());
    System.out.println(obj2.getCounts());
    System.out.println("---------------------------");

    Countable obj3 = new Countable();
    System.out.println(obj1.getCounts());
    System.out.println(obj2.getCounts());
    System.out.println(obj3.getCounts());
    System.out.println("---------------------------");

  }
}
