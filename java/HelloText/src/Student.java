/**
 * Created by Skador on 1/25/2017.
 */
public class Student {

  private String firstName, lastName;
  private int studId;

  public Student(String firstName, String lastName, int studId) {
    this.firstName = firstName;
    this.lastName = lastName;
    this.studId = studId;
  }

  public Student(String firstName, String lastName) {
    this.firstName = firstName;
    this.lastName = lastName;
  }

  public Student(String lastName, int studId) {
    this.lastName = lastName;
    this.studId = studId;
  }

  public Student() {
  }

  public String getFirstName() {
    return firstName;
  }

  public void setFirstName(String firstName) {
    this.firstName = firstName;
  }

  public String getLastName() {
    return lastName;
  }

  public void setLastName(String lastName) {
    this.lastName = lastName;
  }

  public int getStudId() {
    return studId;
  }

  public void setStudId(int studId) {
    this.studId = studId;
  }
}
