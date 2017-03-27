/**
 * Created by Skador on 3/20/2017.
 */
public abstract class Student {
  private String name, idNumber;
  private int yearAdmitted;

  public Student(String name, String idNumber, int yearAdmitted) {
    this.name = name;
    this.idNumber = idNumber;
    this.yearAdmitted = yearAdmitted;
  }

  @Override
  public String toString() {
    return "Student{" +
        "name='" + name + '\'' +
        ", idNumber='" + idNumber + '\'' +
        ", yearAdmitted=" + yearAdmitted +
        '}';
  }

  public abstract int getRemainingHours();

}
