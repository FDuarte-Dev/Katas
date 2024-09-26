package org.kata.atm.money;

public class FiveBill extends Bill {
    public FiveBill() {
        value = 5;
    }

    @Override
    public boolean equals(Object obj) {
        return this.getClass() == obj.getClass() &&
                this.value == ((FiveBill) obj).value;
    }
}
