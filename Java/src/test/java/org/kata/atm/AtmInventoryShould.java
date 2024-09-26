package org.kata.atm;

import org.junit.Test;
import org.junit.jupiter.api.Assertions;

public class AtmInventoryShould {
    @Test
    public void DecreaseInventoryForGivenUnit(){
        // Arrange
        var inventory = new AtmInventory();
        var unitValue = 500;

        // Act
        inventory.decreaseInventory(unitValue);

        // Assert
        Assertions.assertEquals(1, inventory.getInventoryForValue(unitValue));
    }
}
