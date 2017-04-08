import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.Scanner;

/**
 * Created by Cody Michael Kern on 2/22/2017.
 */
public class ReadWrite {
    public static void main(String[] args) throws IOException {
        String firstName, lastName, answer, fileWrite, fileRead, lineRead;
        char ans;
        int monthlySalary, monthsOfPayment;
        double yearlySal;
        Scanner keyboard = new Scanner(System.in);

        System.out.println("Do you want to create a file and add data? (y/n)");
        answer = keyboard.nextLine();
        answer = answer.toLowerCase();
        ans = answer.charAt(0);
        while(ans == 'y'){
            System.out.println("What is the name of the file? (Please enter FileName.txt)");
            fileWrite = keyboard.nextLine();
            System.out.println("Please type the last name");
            lastName = keyboard.nextLine();
            System.out.println("Please type the first name");
            firstName = keyboard.nextLine();
            System.out.println("Please type the monthly salary");
            monthlySalary = keyboard.nextInt();
            keyboard.nextLine();
            System.out.println("Please type the number of months of payments");
            monthsOfPayment = keyboard.nextInt();
            keyboard.nextLine();
            yearlySal = YearlySalary(monthlySalary, monthsOfPayment);

            File ofile = new File("./" + fileWrite);
            FileWriter fWriter = new FileWriter(ofile, true);
            PrintWriter outputFile = new PrintWriter(fWriter);

            outputFile.println(lastName + "\t" + firstName + "\t" + monthlySalary + "\t" + monthsOfPayment + "\t" +
                    yearlySal);
            outputFile.close();

            System.out.println("Do you want to create a file or add data? (y/n)");
            answer = keyboard.nextLine();
            answer = answer.toLowerCase();
            ans = answer.charAt(0);
        }

        System.out.println("Do you want to read data from a file? (y/n)");
        answer = keyboard.nextLine();
        answer = answer.toLowerCase();
        ans = answer.charAt(0);

        System.out.println("What is the name of the file? (Please enter FileName.txt)");
        fileRead = keyboard.nextLine();

        while( ans == 'y'){
            try{
                File ifile = new File("./" + fileRead);
                Scanner inputFile = new Scanner(ifile);
                while (inputFile.hasNext()){
                    lineRead = inputFile.nextLine();
                    System.out.println(lineRead);
                }
                inputFile.close();
            }catch(IOException e) {
                //System.err.println("Caught IOException: " + fileRead + " (The system cannot find the file specified)" + e);
                System.out.println(e);
                //"Caught IOException: " + fileRead + " (The system cannot find the file specified)");
            }

            System.out.println("Do you want to keep reading data from the file? (y/n)");
            answer = keyboard.nextLine();
            answer = answer.toLowerCase();
            ans = answer.charAt(0);
            if(ans == 'y'){
                System.out.println("What is the name of the file? (Please enter FileName.txt)");
                fileRead = keyboard.nextLine();
            }
        }


    }

    private static double YearlySalary(int monthlySalary, int monthsOfPayment){
        double yearlySalary;

        yearlySalary = monthlySalary * monthsOfPayment;

        return yearlySalary;
    }
}
