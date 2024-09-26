package org.kata.atm.integration;

import org.junit.Test;
import org.junit.jupiter.api.Assertions;
import org.kata.atm.Atm;
import org.kata.atm.AtmInventory;
import org.kata.atm.MoneyCalculator;
import org.kata.atm.money.*;

import java.rmi.UnexpectedException;
import java.util.ArrayList;

public class AtmIT {
    @Test
    public void WithdrawGivenValue() throws UnexpectedException {
        // Arrange
        var inventory = new AtmInventory();
        var calculator = new MoneyCalculator();
        var atm = new Atm(calculator, inventory);
        ArrayList<Money> expected = new ArrayList<>();
        expected.add(new TwoHundredBill());
        expected.add(new TwoHundredBill());
        expected.add(new TwentyBill());
        expected.add(new TenBill());
        expected.add(new TwoCoin());
        expected.add(new TwoCoin());

        // Act
        var result = atm.withdraw(434);

        // Assert
        Assertions.assertIterableEquals(expected, result);
    }

    @Test
    public void WithdrawWithLimitedInventory() throws UnexpectedException {
        // Arrange
        var inventory = new AtmInventory();
        var calculator = new MoneyCalculator();
        var atm = new Atm(calculator, inventory);
        ArrayList<Money> expected = new ArrayList<>();
        expected.add(new FiveHundredBill());
        expected.add(new FiveHundredBill());
        expected.add(new TwoHundredBill());
        expected.add(new TwoHundredBill());
        expected.add(new TwoHundredBill());
        expected.add(new OneHundredBill());
        expected.add(new TwentyBill());
        expected.add(new FiveBill());

        // Act
        var result = atm.withdraw(1725);

        // Assert
        Assertions.assertIterableEquals(expected, result);
    }
}
