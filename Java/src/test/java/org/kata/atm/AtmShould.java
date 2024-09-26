package org.kata.atm;

import org.junit.Before;
import org.junit.Test;
import org.junit.jupiter.api.Assertions;
import org.junit.runner.RunWith;
import org.kata.atm.money.*;
import org.mockito.Mock;
import org.mockito.junit.MockitoJUnitRunner;

import java.rmi.UnexpectedException;
import java.util.ArrayList;

import static org.mockito.Mockito.when;

@RunWith(MockitoJUnitRunner.class)
public class AtmShould {
    @Mock
    MoneyCalculator calculator;

    @Mock
    AtmInventory inventory;

    private Atm atm;

    @Before
    public void initializa(){
        atm = new Atm(calculator, inventory);
    }

    @Test
    public void ReturnListOfMoneys() throws UnexpectedException {
        // Arrange
        int quantity = 0;

        // Act
        var result = atm.withdraw(quantity);

        // Assert
        Assertions.assertEquals(0, result.size());
    }

    @Test
    public void ReturnWithdrawnMoney() throws UnexpectedException {
        // Arrange
        int quantity = 434;
        ArrayList<Money> expected = new ArrayList<>();
        expected.add(new TwoHundredBill());
        expected.add(new TwoHundredBill());
        expected.add(new TwentyBill());
        expected.add(new TenBill());
        expected.add(new TwoCoin());
        expected.add(new TwoCoin());
        when(calculator.calculate(quantity, inventory)).thenReturn(expected);

        // Act
        var result = atm.withdraw(quantity);

        // Assert
        Assertions.assertIterableEquals(expected, result);
    }

    @Test
    public void ReturnWithdrawnMoneyWithLimitedInventory() throws UnexpectedException {
        // Arrange
        int quantity = 1725;
        ArrayList<Money> expected = new ArrayList<>();
        expected.add(new FiveHundredBill());
        expected.add(new FiveHundredBill());
        expected.add(new TwoHundredBill());
        expected.add(new TwoHundredBill());
        expected.add(new TwoHundredBill());
        expected.add(new OneHundredBill());
        expected.add(new TwentyBill());
        expected.add(new FiveBill());
        when(calculator.calculate(quantity, inventory)).thenReturn(expected);

        // Act
        var result = atm.withdraw(quantity);

        // Assert
        Assertions.assertIterableEquals(expected, result);
    }
}
