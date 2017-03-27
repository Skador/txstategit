/**
 * Created by Michelle Leipnik and Cody Kern on 3/19/2017.
 */
public class Student extends Person implements Driver {
  private String university, id;
  private String country;

  public Student() {
    System.out.println("I am a student");
  }

  public Student(String pName, String pGender, String pRace, String pId, String pUniversity, String pCountry) {
    super(pName, pGender, pRace);
    id = pId;
    university = pUniversity;
    country = pCountry;
  }

  public String getUniversity() {
    return university;
  }

  public void setUniversity(String pUniversity) {
    university = pUniversity;
  }

  public String getCountry() {
    return country;
  }

  public void setCountry(String pCountry) {
    country = pCountry;
  }

  public String getId() {
    return id;
  }

  public void setId(String pId) {
    id = pId;
  }

  @Override
  public void walk(){
    System.out.println("I am a student who walks");
  }

  @Override
  public String driveCar(String pCar){
    return "I drive a " + pCar;
  }

  public void takeCourses(){
    System.out.println("I am taking 3 courses this semester");
  }
}
