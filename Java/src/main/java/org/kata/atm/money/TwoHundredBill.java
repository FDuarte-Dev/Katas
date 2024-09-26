package org.kata.atm.money;

public class TwoHundredBill extends Bill {
    public TwoHundredBill() {
        value = 200;
    }

    @Override
    public boolean equals(Object obj) {
        return this.getClass() == obj.getClass() &&
                this.value == ((TwoHundredBill) obj).value;
    }
}
