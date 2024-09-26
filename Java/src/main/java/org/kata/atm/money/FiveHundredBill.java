package org.kata.atm.money;

public class FiveHundredBill extends Bill {

    public FiveHundredBill() {
        value = 500;
    }

    @Override
    public boolean equals(Object obj) {
        return this.getClass() == obj.getClass() &&
                this.value == ((FiveHundredBill) obj).value;
    }
}
