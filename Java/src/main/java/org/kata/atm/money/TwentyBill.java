package org.kata.atm.money;

public class TwentyBill extends Bill {
    public TwentyBill() {
        value = 20;
    }

    @Override
    public boolean equals(Object obj) {
        return this.getClass() == obj.getClass() &&
                this.value == ((TwentyBill) obj).value;
    }
}
