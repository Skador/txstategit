/**
 * Created by Skador on 3/8/2017.
 */
public class EnumDemo {
  enum Day {Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday}

  public static void main(String[] args) {
    Day workDay = Day.Wednesday;

    System.out.println(workDay);

    System.out.println("The ordinal value for " + Day.Sunday + " is " + Day.Sunday.ordinal());

    System.out.println("The ordinal value for " + Day.Saturday + " is " + Day.Saturday.ordinal());

    if(Day.Friday.compareTo(Day.Monday) > 0 )
      System.out.println(Day.Friday + " is greater than " + Day.Monday);
    else
      System.out.println(Day.Friday + " is NOT greater than " + Day.Monday);

    CarType myCar = CarType.Ferrari;
  }
}
