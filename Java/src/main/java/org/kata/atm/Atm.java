package org.kata.atm;

import org.kata.atm.money.Money;

import java.rmi.UnexpectedException;
import java.util.List;

public class Atm {
    AtmInventory inventory;
    MoneyCalculator calculator;

    public Atm(MoneyCalculator calculator, AtmInventory inventory) {
        this.calculator = calculator;
        this.inventory = inventory;
    }

    public List<Money> withdraw(int quantity) throws UnexpectedException {
        return calculator.calculate(quantity, inventory);
    }
}
