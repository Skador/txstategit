/**
 * Created by Skador on 2/6/2017.
 */
public class PassArg {
  public static void main(String[] args) {
    int a = 5 ,b = 2;
    double c = 3.4, d = 8.2;
    String e = "Nico", f = "Tama";

    int resultInt = showSum(a, b);
    double resultDouble = showSum(c, d);
    String resultString = showSum(e, f);

    System.out.println(resultInt);
    System.out.println(resultDouble);
    System.out.println(resultString);
  }

  public static int showSum(int a, int b) {
    int c;
    c = a + b;
    return c;
  }

  private static double showSum(double a, double b) {
    double c;
    c = a + b;
    return c;
  }

  private static String showSum(String a, String b) {
    String c;
    c = a + b;
    return c;
  }

  private static boolean isValid(int number) {
    boolean status;
    if(number >= 1 && number <=100)
      status = true;
    else
      status = false;
    return status;
  }

  private static String showSum(String a, String b) {
    String c;
    c = a + b;
    return c;
  }
}
