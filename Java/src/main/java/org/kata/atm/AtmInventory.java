package org.kata.atm;

import java.util.Dictionary;
import java.util.Hashtable;

public class AtmInventory {
    private final Dictionary<Integer, Integer> moneyUnits;

    public AtmInventory() {
        this.moneyUnits = new Hashtable<>();
        this.moneyUnits.put(500, 2);
        this.moneyUnits.put(200, 3);
        this.moneyUnits.put(100, 5);
        this.moneyUnits.put(50, 12);
        this.moneyUnits.put(20, 20);
        this.moneyUnits.put(10, 50);
        this.moneyUnits.put(5, 100);
        this.moneyUnits.put(2, 250);
        this.moneyUnits.put(1, 500);
    }

    public int getInventoryForValue(int unitValue){
        return moneyUnits.get(unitValue);
    }

    public void decreaseInventory(int unitValue) {
        moneyUnits.put(unitValue, this.getInventoryForValue(unitValue) - 1);
    }
}
