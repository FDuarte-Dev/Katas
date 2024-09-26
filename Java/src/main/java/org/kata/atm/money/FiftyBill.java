package org.kata.atm.money;

public class FiftyBill extends Bill {
    public FiftyBill() {
        value = 50;
    }

    @Override
    public boolean equals(Object obj) {
        return this.getClass() == obj.getClass() &&
                this.value == ((FiftyBill) obj).value;
    }
}
