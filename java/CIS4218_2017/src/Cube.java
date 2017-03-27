/**
 * Created by Skador on 3/20/2017.
 */
public class Cube extends Rectangle {
  private double height;

  public Cube(double pLength, double pWidth, double pHeight){
    // User super() to get the superclass' parameters.
    super(pLength, pWidth);
    height = pHeight;
  }
  // Cube myCube = new Cube (2, 2, 2);

  public double getHeight() {
    return height;
  }

  public void setHeight(double pHeight) {
    height = pHeight;
  }

  public double getSurfaceArea(){
    //return getArea() * 6;
    return (getArea() * 4) + (getLength() * height * 2);
  }

 // public double getArea(){
 //   return (super.getArea() *4) + (getLength() * height * 2);
 // }

  public double getVolume(){
    return getHeight()*getLength()*getWidth();
  }
}


