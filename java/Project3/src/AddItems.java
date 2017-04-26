package src;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.*;

/**
 * Created by Skador on 4/12/2017.
 */
public class AddItems extends JFrame {
  private JPanel panel1;
  private JTextField textField1;
  private JTextField textField2;
  private JButton insertButton;

  public AddItems(){
    setTitle("Adding new items to the database");
    setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
    getContentPane().add(panel1);

    pack();
    setVisible(true);


    insertButton.addActionListener(new ActionListener() {
      @Override
      public void actionPerformed(ActionEvent e) {
        try {
          Class.forName("com.mysql.jdbc.Driver").newInstance();
          Connection myConn = DriverManager.getConnection("jdbc:mysql://datastore.ro:3306/CIS3374", "cis3374", "cis3374");
          Statement sqlStmt = myConn.createStatement();
          String sqlInsert = "insert into Coffee (Description, Price) values ('"+ textField1.getText() + "', '" + Double.parseDouble(textField2.getText()) + "')";
          int row = sqlStmt.executeUpdate(sqlInsert);
          JOptionPane.showMessageDialog(null, "Added " + row + " row(s)");

          myConn.close();
          dispose();


        } catch (InstantiationException e1) {
          e1.printStackTrace();
        } catch (IllegalAccessException e1) {
          e1.printStackTrace();
        } catch (ClassNotFoundException e1) {
          e1.printStackTrace();
        } catch (SQLException e1) {
          e1.printStackTrace();
        }
      }
    });
  }
}
