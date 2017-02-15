/**
 * Created by Skador on 2/8/2017.
 */
public class Rectangle {
  private double length, width;

  public Rectangle() {
    length = 1.0;
    width = 1.0;
  }

  public Rectangle(double len, double w) {
    length = len;
    width = w;
  }

  public double getLength() {
    return length;
  }

  public void setLength(double len) {
    length = len;
  }

  public double getWidth() {
    return width;
  }

  public void setWidth(double w) {
    width = w;
  }

  public double getArea() {
    return width * length;
  }
}
