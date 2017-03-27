/**
 * Created by Skador on 3/20/2017.
 */
public class TestCube {
  public static void main(String[] args) {
    Cube myCube = new Cube(4,4,4);

    System.out.println("Length = " + myCube.getLength());
    System.out.println("Width = " + myCube.getWidth());
    System.out.println("Height = " + myCube.getHeight());
    System.out.println("Area = " + myCube.getArea());
    System.out.println("Surface Area = " + myCube.getSurfaceArea());
    System.out.println("Volume = " + myCube.getVolume());
    //System.out.println("Length = " + myCube.getLength());

    Rectangle myCube2 = new Cube(3,4,5);
    System.out.println(myCube2.getArea());
  }
}
