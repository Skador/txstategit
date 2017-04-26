import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyEvent;

/**
 * Created by Skador on 4/10/2017.
 */
public class Menu extends JFrame {

  private JLabel messageLabel;
  private final int LABEL_WIDTH=400;
  private final int LABEL_HEIGHT=200;
  private JMenuBar menuBar;
  private JMenuItem exitItem;
  private JMenu fileMenu, textMenu;
  private JRadioButtonMenuItem redItem, blackItem, blueItem;

  public Menu(){
    setTitle("Example Menu");
    setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    messageLabel = new JLabel("Use the text menu to change the colour", SwingConstants.CENTER);
    messageLabel.setPreferredSize(new Dimension(LABEL_WIDTH, LABEL_HEIGHT));
    getContentPane().add(messageLabel);
    buildMenuBar();
    pack();
    setVisible(true);

  }

  private void buildMenuBar(){

    menuBar = new JMenuBar();

    buildFileMenu();
    buildTextMenu();
    menuBar.add(fileMenu);
    menuBar.add(textMenu);

    setJMenuBar(menuBar);
  }

  private void buildTextMenu(){
    redItem = new JRadioButtonMenuItem("Red");
    redItem.setMnemonic(KeyEvent.VK_R);
    redItem.addActionListener(new ColourListener());

    blueItem = new JRadioButtonMenuItem("Blue");
    blueItem.setMnemonic(KeyEvent.VK_C);
    blueItem.addActionListener(new ColourListener());

    blackItem = new JRadioButtonMenuItem("Black");
    blackItem.setMnemonic(KeyEvent.VK_B);
    blackItem.addActionListener(new ColourListener());

    ButtonGroup group = new ButtonGroup();
    group.add(redItem);
    group.add(blackItem);
    group.add(blueItem);

    textMenu = new JMenu("Text");
    textMenu.setMnemonic(KeyEvent.VK_T);
    textMenu.add(redItem);
    textMenu.add(blackItem);
    textMenu.add(blueItem);

  }

  private void buildFileMenu(){
    exitItem = new JMenuItem("Exit");
    exitItem.setMnemonic(KeyEvent.VK_X);
    exitItem.addActionListener(new ExitListener());

    fileMenu = new JMenu("File");
    fileMenu.setMnemonic(KeyEvent.VK_F);
    fileMenu.add(exitItem);
  }

  public static void main(String[] args) {
    new Menu();
  }

  private class ExitListener implements ActionListener{
    @Override
    public void actionPerformed(ActionEvent actionEvent){
      System.exit(0);
    }
  }

  private class ColourListener implements ActionListener {
    @Override
    public void actionPerformed(ActionEvent actionEvent){
      if(redItem.isSelected()){
        messageLabel.setForeground(Color.red);
      }
      else if(blackItem.isSelected()){
        messageLabel.setForeground(Color.black);
      }
      else if(blueItem.isSelected()){
        messageLabel.setForeground(Color.blue);
      }
    }
  }
}
