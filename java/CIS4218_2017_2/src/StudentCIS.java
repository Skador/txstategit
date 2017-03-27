/**
 * Created by Skador on 3/20/2017.
 */
public class StudentCIS extends Student implements Employee{

  public StudentCIS(String name, String idNumber, int yearAdmitted) {
    super(name, idNumber, yearAdmitted);
  }

  @Override
  public int getRemainingHours() {
    return 0;
  }

  @Override
  public void displayJob() {
    System.out.println("Student job = CIS");
  }
}
