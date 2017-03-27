/**
 * Created by Skador on 3/6/2017.
 */
public class Instructor {
  private String lastName, firstName, officeNumber;

  public Instructor(String lName, String fName, String office) {
    lastName = lName;
    firstName = fName;
    officeNumber = office;
  }

  public Instructor(Instructor object2) {
    lastName = object2.lastName;
    firstName = object2.firstName;
    officeNumber = object2.officeNumber;
  }

  public void set(String lName, String fName, String office) {
    lastName = lName;
    firstName = fName;
    officeNumber = office;
  }

  public String toString(){
    String str = " Last Name: " + lastName +
        "\n First Name: " + firstName+
        "\n Office Number: " + officeNumber;
    return str;
  }
}