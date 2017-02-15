import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.Scanner;

/**
 * Created by Skador on 2/1/2017.
 */
public class FileWriteDemo {
  public static void main(String[] args) throws IOException {
    String filename, friendName;
    int numFriends;

    Scanner keyboard = new Scanner(System.in);

    System.out.println("How many friends do you have? ");
    numFriends = keyboard.nextInt();

    keyboard.nextLine();

    System.out.println("Enter the filename: ");
    filename = keyboard.nextLine();

    FileWriter fwriter = new FileWriter("MyFriends.txt", true);
    PrintWriter outputFile = new PrintWriter(fwriter);
    //PrintWriter outputFile = new PrintWriter(filename);

    for (int i = 1; i <= numFriends; i++){
      System.out.println("Enter the name of friend number " + i + ":");
      friendName = keyboard.nextLine();

      outputFile.println(friendName);
    }

    outputFile.close();
    System.out.println("Data written to the file.");
  }
}
