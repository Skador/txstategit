package src;

import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.Statement;

/**
 * Created by Skador on 4/26/2017.
 */
public class UpdateItems extends JFrame{
  private JPanel panel1;
  private JTextField textField1;
  private JTextField textField2;
  private JButton updateButton;

  public UpdateItems(String[] coffeeID){
    setTitle("Adding new items to the database");
    setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
    getContentPane().add(panel1);

    pack();
    setVisible(true);


    updateButton.addActionListener(new ActionListener() {
      @Override
      public void actionPerformed(ActionEvent e) {
        try {
          Class.forName("com.mysql.jdbc.Driver").newInstance();
          Connection myConn = DriverManager.getConnection("jdbc:mysql://datastore.ro:3306/CIS3374", "cis3374", "cis3374");
          Statement sqlStmt = myConn.createStatement();
          String sqlUpdate = "UPDATE Coffee SET Description = '" + textField1.getText() +"', Price = '" + Double.parseDouble(textField2.getText()) + "' WHERE CoffeeID = '" + coffeeID[0] + "'";
          JOptionPane.showMessageDialog(null, sqlUpdate);
          int row = sqlStmt.executeUpdate(sqlUpdate);
          JOptionPane.showMessageDialog(null, "Updated " + row + " row(s)");

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

