/**
 * Created by Skador on 2/8/2017.
 */
public class TestRectangle {
  public static void main(String[] args) {
    Rectangle mLivingRoom = new Rectangle();

    String name = new String("John");

    mLivingRoom.setLength(5.6);
    mLivingRoom.setWidth(4.2);

    System.out.println("Has an area of: " + mLivingRoom.getArea() + ". " +
        "The length is: " + mLivingRoom.getLength() + " and a width of " +
        "" + mLivingRoom.getWidth());
    Rectangle myRoom = new Rectangle(6.0, 5.0);

    System.out.println("Has an area of: " + myRoom.getArea() + ". " +
        "The length is: " + myRoom.getLength() + " and a width of " +
        "" + myRoom.getWidth());
  }
}
