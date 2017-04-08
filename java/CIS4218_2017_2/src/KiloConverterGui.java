import javafx.embed.swing.JFXPanel;

import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

/**
 * Created by Skador on 4/3/2017.
 */
public class KiloConverterGui extends JFrame{
  private JPanel panel1;
  private JTextField kiloTextField;
  private JButton calcButton;
  private JLabel kiloLabel;

  public KiloConverterGui(){
    setTitle("KiloConverterGui");
    setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    getContentPane().add(panel1);
    pack();
    setVisible(true);

    calcButton.addActionListener(new ActionListener() {
      @Override
      public void actionPerformed(ActionEvent e) {
        double miles = Double.parseDouble(kiloTextField.getText());
        miles = miles*0.6214;
        JOptionPane.showMessageDialog(null, miles);
      }
    });
  }

  public static void main(String[] args) {
    new KiloConverterGui();
  }


}

