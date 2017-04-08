import javax.swing.*;

/**
 * Created by Skador on 4/3/2017.
 */
public class MyFirstForm extends JFrame {
  public MyFirstForm(){
    final int WINDOW_WIDTH = 350;
    final int WINDOW_HEIGHT = 250;

    setTitle("My First Window Form");
    setSize(WINDOW_WIDTH, WINDOW_HEIGHT);
    setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    setVisible(true);

  }

  public static void main(String[] args) {
    //MyFirstForm mff = new MyFirstForm() redundant.
    new MyFirstForm();
  }

}
