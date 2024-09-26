package org.kata.atm;

import org.kata.atm.money.*;

import java.rmi.UnexpectedException;
import java.util.ArrayList;
import java.util.List;

public class MoneyCalculator {
    private int[] unitValues = new int[]{500, 200, 100, 50, 20, 10, 5, 2, 1};

    public List<Money> calculate(int quantity, AtmInventory inventory) throws UnexpectedException {
        List<Money> money = new ArrayList<Money>();

        while(quantity > 0){
            var unitValue = getHighestPossibleValue(quantity, inventory);
            money = addValueUnitToMoney(unitValue, money);
            quantity = decreaseValueUnitToQuantity(unitValue, quantity);
            inventory.decreaseInventory(unitValue);
        }

        return money;
    }

    private int getHighestPossibleValue(int quantity, AtmInventory inventory) {
        for (int unitValue : unitValues) {
            if (unitValue <= quantity && inventory.getInventoryForValue(unitValue) > 0) {
                return unitValue;
            }
        }
        return 1;
    }

    private List<Money> addValueUnitToMoney(int unitValue, List<Money> money) throws UnexpectedException {
        Money unitMoney;
        switch (unitValue) {
            case 500 -> unitMoney = new FiveHundredBill();
            case 200 -> unitMoney = new TwoHundredBill();
            case 100 -> unitMoney = new OneHundredBill();
            case 50 -> unitMoney = new FiftyBill();
            case 20 -> unitMoney = new TwentyBill();
            case 10 -> unitMoney = new TenBill();
            case 5 -> unitMoney = new FiveBill();
            case 2 -> unitMoney = new TwoCoin();
            case 1 -> unitMoney = new OneCoin();
            default -> throw new UnexpectedException("Invalid quantity");
        }

        money.add(unitMoney);
        return money;
    }

    private static int decreaseValueUnitToQuantity(int unitValue, int quantity) {
        return quantity - unitValue;
    }
}
