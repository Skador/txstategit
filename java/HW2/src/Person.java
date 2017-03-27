/**
 * Created by Michelle Leipnik and Cody Kern on 3/19/2017.
 */
public class Person {
  private String gender, name;
  private String race;

  public Person() {
    System.out.println("I am a person");
  }

  public Person(String pName, String pGender, String pRace) {
    name = pName;
    gender = pGender;
    race = pRace;
  }

  public String getGender() {
    return gender;
  }

  public void setGender(String pGender) {
    gender = pGender;
  }

  public String getRace() {
    return race;
  }

  public void setRace(String pRace) {
    race = pRace;
  }

  public String getName() {
    return name;
  }

  public void setName(String pName) {
    name = pName;
  }

  public void walk(){
    System.out.println("I walk");
  }

}
