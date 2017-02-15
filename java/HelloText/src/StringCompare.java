/**
 * Created by Skador on 1/23/2017.
 */
public class StringCompare {
  public static void main(String[] args){

    String name1="Mark", name2="Mark", name3="Mary";
    if(name1.equals(name2)){
      System.out.println(name1 + " and " + name2 + " are identical!!!");
    } else{
      System.out.println(name1 + " and " + name2 + " are not identical... :(");
    }

    if(name1.equals(name3)){
      System.out.println(name1 + " and " + name3 + " are identical!!!");
    } else{
      System.out.println(name1 + " and " + name3 + " are not identical... :(");
    }

    if(name1.compareTo(name3) > 0){
      System.out.println(name1 + " is bigger than " + name3 +"!!!");
    } else{
      System.out.println(name3 + " is bigger than " + name1 +"...");
    }

  }
}
