import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

/**
 * Created by Skador on 4/3/2017.
 */
public class KiloConverter extends JFrame{
  
  private JPanel panel;             //Reference a panel
  private JLabel messageLabel;      //Reference a label
  private JTextField kiloTextField; //Reference a text field
  private JButton calcButton;       //Reference a button
  private final int WINDOW_WIDTH = 310;
  private final int WINDOW_HEIGHT = 100;
  
  public KiloConverter(){
    setTitle("KiloConverter");                      //Set title
    setSize(WINDOW_WIDTH, WINDOW_HEIGHT);           //Set size
    setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE); //Set Default Close Operation
    
    buildPanel();
    add(panel);
    setVisible(true);
    
    
  }

  private void buildPanel() {
    messageLabel = new JLabel("Enter a distance in kilometers");
    kiloTextField = new JTextField(10);
    calcButton = new JButton("Calculate");

    calcButton.addActionListener(new CalcButtonListener());

    panel = new JPanel();

    panel.add(messageLabel);
    panel.add(kiloTextField);
    panel.add(calcButton);
  }

  public static void main(String[] args) {
    new KiloConverter();
  }

  private class CalcButtonListener implements ActionListener {

    public void actionPerformed(ActionEvent e){
      final double CONVERSION = 0.6214;
      String input;
      double miles;

      input = kiloTextField.getText();

      miles = Double.parseDouble(input) * CONVERSION;

      JOptionPane.showMessageDialog(null, input + " kilometers is " + miles + " miles.");
    }

  }
}
