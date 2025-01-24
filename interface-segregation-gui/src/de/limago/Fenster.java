package de.limago;


import java.awt.*;
import java.awt.event.*;

public class Fenster extends Frame  {


    public Fenster() {

        setSize(300, 300);
        Button button = new Button("Drück mich");
        button.addActionListener(e -> ausgabe());
        add(button);
        addWindowListener(new MyWindowListener());


    }


    public static void main(String[] args) {

        new Fenster().setVisible(true);
    }

    private void ausgabe() {
        System.out.println("Button wurde gedrückt");
    }

    private void beenden() {
        dispose();
    }

    /*class MyActionListener implements ActionListener {

        @Override
        public void actionPerformed(final ActionEvent e) {
            ausgabe();
        }
    }*/

    class MyWindowListener extends WindowAdapter {

        @Override
        public void windowClosing(final WindowEvent e) {
            beenden();
        }
    }
}