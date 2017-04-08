import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

/**
 * Created by Skador on 4/5/2017.
 */
public class OrderCalculator extends JFrame {
  private JPanel panel1;
  private JButton calculateButton;
  private JButton exitButton;
  private JRadioButton whiteRadioButton;
  private JRadioButton wholeWheatRadioButton;
  private JCheckBox creamCheeseCheckBox;
  private JCheckBox butterCheckBox;
  private JCheckBox peachJellyCheckBox;
  private JCheckBox blueberryJamCheckBox;
  private JRadioButton noneRadioButton;
  private JRadioButton regularCoffeeRadioButton;
  private JRadioButton decafCoffeeRadioButton;
  private JRadioButton cappuccinoRadioButton;

  public final double WHITE_BAGEL = 1.25;
  public final double WHEAT_BAGEL = 1.50;
  public final double CREAM_CHEESE = 0.50;
  public final double BUTTER = 0.25;
  public final double PEACH_JELLY = 0.75;
  public final double BLUEBERRY_JAM = 0.75;
  public final double NO_COFFEE = 0.0;
  public final double REGULAR_COFFEE = 1.25;
  public final double DECAF_COFFEE = 1.25;
  public final double CAPPUCCINO = 2.00;

  public OrderCalculator(){
    setTitle("Order Calculator");
    getContentPane().add(panel1);
    pack();
    setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    setVisible(true);


    calculateButton.addActionListener(new ActionListener() {
      @Override
      public void actionPerformed(ActionEvent e) {
        double totalCost = getBagelCost() + getToppingsCost() + getCoffeeCost();
        JOptionPane.showMessageDialog(null, String.format("The total cost is: $%,.2f", totalCost));
      }
    });
    exitButton.addActionListener(new ActionListener() {
      @Override
      public void actionPerformed(ActionEvent e) {
        System.exit(0);
      }
    });
  }

  public static void main(String[] args) {
    new OrderCalculator();
  }

  public double getBagelCost(){
    double bagelCost = 0.0;
    if(whiteRadioButton.isSelected())
      bagelCost = WHITE_BAGEL;
    else
      bagelCost = WHEAT_BAGEL;

    return bagelCost;
  }

  public double getToppingsCost(){
    double toppingCost = 0.0;
    if(creamCheeseCheckBox.isSelected())
      toppingCost += CREAM_CHEESE;
    if(butterCheckBox.isSelected())
      toppingCost += BUTTER;
    if(peachJellyCheckBox.isSelected())
      toppingCost += PEACH_JELLY;
    if(blueberryJamCheckBox.isSelected())
      toppingCost += BLUEBERRY_JAM;

    return toppingCost;
  }

  public double getCoffeeCost(){
    double coffeeCost = 0.0;
    if(noneRadioButton.isSelected())
      coffeeCost = NO_COFFEE;
    else if(regularCoffeeRadioButton.isSelected())
      coffeeCost = REGULAR_COFFEE;
    else if(decafCoffeeRadioButton.isSelected())
      coffeeCost = DECAF_COFFEE;
    else if(cappuccinoRadioButton.isSelected())
      coffeeCost = CAPPUCCINO;

    return coffeeCost;
  }


}


