import java.io.File;
import java.io.IOException;
import java.util.Scanner;

/**
 * Created by Skador on 2/1/2017.
 */
public class FileReadDemo {
  public static void main(String[] args) throws IOException {
    Scanner keyboard = new Scanner(System.in);

    System.out.println("Enter the filename: ");
    String filename = keyboard.nextLine();

    File file = new File(filename);
    Scanner inputFile = new Scanner(file);

    while (inputFile.hasNext()){
      String friendName = inputFile.nextLine();

      System.out.println(friendName);
    }

    inputFile.close();
  }
}
