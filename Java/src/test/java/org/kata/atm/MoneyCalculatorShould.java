package org.kata.atm;

import org.junit.Before;
import org.junit.Test;
import org.junit.jupiter.api.Assertions;
import org.kata.atm.money.*;

import java.rmi.UnexpectedException;
import java.util.ArrayList;

public class MoneyCalculatorShould {
    private MoneyCalculator calculator;
    private AtmInventory inventory;

    @Before
    public void initialize(){
        calculator = new MoneyCalculator();
        inventory = new AtmInventory();
    }

    @Test
    public void CalculateMoneyForFiveHundred() throws UnexpectedException {
        // Arrange
        int quantity = 500;

        // Act
        var result = calculator.calculate(quantity, inventory);

        // Assert
        Assertions.assertEquals(1, result.size());
        Assertions.assertEquals(FiveHundredBill.class, result.get(0).getClass());
    }

    @Test
    public void CalculateMoneyForTwoHundred() throws UnexpectedException {
        // Arrange
        int quantity = 200;

        // Act
        var result = calculator.calculate(quantity, inventory);

        // Assert
        Assertions.assertEquals(1, result.size());
        Assertions.assertEquals(TwoHundredBill.class, result.get(0).getClass());
    }

    @Test
    public void CalculateMoneyForOneHundred() throws UnexpectedException {
        // Arrange
        int quantity = 100;

        // Act
        var result = calculator.calculate(quantity, inventory);

        // Assert
        Assertions.assertEquals(1, result.size());
        Assertions.assertEquals(OneHundredBill.class, result.get(0).getClass());
    }

    @Test
    public void CalculateMoneyForFifty() throws UnexpectedException {
        // Arrange
        int quantity = 50;

        // Act
        var result = calculator.calculate(quantity, inventory);

        // Assert
        Assertions.assertEquals(1, result.size());
        Assertions.assertEquals(FiftyBill.class, result.get(0).getClass());
    }

    @Test
    public void CalculateMoneyForTwenty() throws UnexpectedException {
        // Arrange
        int quantity = 20;

        // Act
        var result = calculator.calculate(quantity, inventory);

        // Assert
        Assertions.assertEquals(1, result.size());
        Assertions.assertEquals(TwentyBill.class, result.get(0).getClass());
    }

    @Test
    public void CalculateMoneyForTen() throws UnexpectedException {
        // Arrange
        int quantity = 10;

        // Act
        var result = calculator.calculate(quantity, inventory);

        // Assert
        Assertions.assertEquals(1, result.size());
        Assertions.assertEquals(TenBill.class, result.get(0).getClass());
    }

    @Test
    public void CalculateMoneyForFive() throws UnexpectedException {
        // Arrange
        int quantity = 5;

        // Act
        var result = calculator.calculate(quantity, inventory);

        // Assert
        Assertions.assertEquals(1, result.size());
        Assertions.assertEquals(FiveBill.class, result.get(0).getClass());
    }

    @Test
    public void CalculateMoneyForTwo() throws UnexpectedException {
        // Arrange
        int quantity = 2;

        // Act
        var result = calculator.calculate(quantity, inventory);

        // Assert
        Assertions.assertEquals(1, result.size());
        Assertions.assertEquals(TwoCoin.class, result.get(0).getClass());
    }

    @Test
    public void CalculateMoneyForOne() throws UnexpectedException {
        // Arrange
        int quantity = 1;

        // Act
        var result = calculator.calculate(quantity, inventory);

        // Assert
        Assertions.assertEquals(1, result.size());
        Assertions.assertEquals(OneCoin.class, result.get(0).getClass());
    }

    @Test
    public void CalculateMoneyForCompositeQuantities() throws UnexpectedException {
        // Arrange
        int quantity = 434;
        ArrayList<Money> expected = new ArrayList<>();
        expected.add(new TwoHundredBill());
        expected.add(new TwoHundredBill());
        expected.add(new TwentyBill());
        expected.add(new TenBill());
        expected.add(new TwoCoin());
        expected.add(new TwoCoin());

        // Act
        var result = calculator.calculate(quantity, inventory);

        // Assert
        Assertions.assertIterableEquals(expected, result);
    }

    @Test
    public void CalculateMoneyForCompositeQuantitiesWithLimitedInventory() throws UnexpectedException {
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

        // Act
        var result = calculator.calculate(quantity, inventory);

        // Assert
        Assertions.assertIterableEquals(expected, result);
    }
}
