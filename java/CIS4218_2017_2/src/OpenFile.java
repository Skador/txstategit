import javax.swing.*;
import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

/**
 * Created by Skador on 3/29/2017.
 */
public class OpenFile {
  public static void main(String[] args) {
    File file;
    Scanner inputFile;
    String fileName;

    fileName = JOptionPane.showInputDialog("Enter " + "the name of a file:");

    try {
      file = new File(fileName);
      inputFile = new Scanner(file);
      JOptionPane.showMessageDialog(null, "the file was found.");
    }

    catch(FileNotFoundException e){
      JOptionPane.showMessageDialog(null, "File not found.");
    }
    catch (IllegalArgumentException e1){

    }
    catch (Exception e2){

    }

    JOptionPane.showMessageDialog(null, "Done.");
    System.exit(0);

  }
}
