import java.util.Scanner;

/**
 * Created by Michelle Leipnik and Cody Kern on 3/19/2017.
 */
public class TestStudent {

  public static void main(String[] args) {
    String name, gender, race, id, university, country;
    Scanner keyboard = new Scanner(System.in);

    System.out.println("Testing Person Class:");
    System.out.println("");

    System.out.println("Test 1 Person Empty Constructor");
    Person myPer = new Person();
    System.out.println("");

    System.out.println("Test 2 Person Full Constructor");
    Person myPerson2 = new Person("Bob", "Male", "White");
    System.out.println("Name: " + myPerson2.getName());
    System.out.println("Gender: " + myPerson2.getGender());
    System.out.println("Race: " + myPerson2.getRace());
    System.out.println("");

    System.out.println("Test 3 Person information Updates");
    System.out.println("Changing name from Bob to Mary");
    myPerson2.setName("Mary");
    System.out.println("Changing gender from Male to Female");
    myPerson2.setGender("Female");
    System.out.println("Changing race from White to Asian");
    myPerson2.setRace("Asian");
    System.out.println("");
    System.out.println("Display Person Information Changes:");
    System.out.println("Name: " + myPerson2.getName());
    System.out.println("Gender: " + myPerson2.getGender());
    System.out.println("Race: " + myPerson2.getRace());
    System.out.println("");

    System.out.println("Test 4 Person Walk function");
    myPerson2.walk();

    System.out.println("Testing Student Class");
    System.out.println("");

    System.out.println("Test 5 Student Empty Constructor");
    Student myStud = new Student();
    System.out.println("");

    System.out.println("Test 6 Student Full Constructor");
    System.out.println("Please fill in the required information to test.");
    System.out.print("Name: ");
    name = keyboard.nextLine();
    System.out.print("Gender: ");
    gender = keyboard.nextLine();
    System.out.print("Race: ");
    race = keyboard.nextLine();
    System.out.print("ID: ");
    id = keyboard.nextLine();
    System.out.print("University: ");
    university = keyboard.nextLine();
    System.out.print("Country: ");
    country = keyboard.nextLine();
    System.out.println("");

    Student myStudent2 = new Student(name, gender, race, id, university, country);

    System.out.println("Displaying information received");
    System.out.println("Name: " + myStudent2.getName());
    System.out.println("Gender: " + myStudent2.getGender());
    System.out.println("Race: " + myStudent2.getRace());
    System.out.println("ID: " + myStudent2.getId());
    System.out.println("University: " + myStudent2.getUniversity());
    System.out.println("Country: " + myStudent2.getCountry());
    System.out.println("");

    System.out.println("Test 7 Student Information Updates");
    System.out.println("Please update the following information.");
    System.out.print("Name: ");
    myStudent2.setName(keyboard.nextLine());
    System.out.print("Gender: ");
    myStudent2.setGender(keyboard.nextLine());
    System.out.print("Race: ");
    myStudent2.setRace(keyboard.nextLine());
    System.out.print("ID: ");
    myStudent2.setId(keyboard.nextLine());
    System.out.print("University: ");
    myStudent2.setUniversity(keyboard.nextLine());
    System.out.print("Country: ");
    myStudent2.setCountry(keyboard.nextLine());
    System.out.println("");
    System.out.println("Displaying Updated Student information");
    System.out.println("Name: " + myStudent2.getName());
    System.out.println("Gender: " + myStudent2.getGender());
    System.out.println("Race: " + myStudent2.getRace());
    System.out.println("ID: " + myStudent2.getId());
    System.out.println("University: " + myStudent2.getUniversity());
    System.out.println("Country: " + myStudent2.getCountry());
    System.out.println("");

    System.out.println("Test 8 Student Walk function");
    myStudent2.walk();
    System.out.println("");

    System.out.println("Test 9 Student takeCourses function");
    myStudent2.takeCourses();
    System.out.println("");

    System.out.println("Test 10 Student driveCar Interface function");
    System.out.print("Please enter the brand of car you drive: ");
    System.out.println(myStudent2.driveCar(keyboard.nextLine()));
    System.out.println("");

    System.out.println("This ends all tests.");
    }

}
