package org.kata.atm.money;

public class OneHundredBill extends Bill {
    public OneHundredBill() {
        value = 100;
    }

    @Override
    public boolean equals(Object obj) {
        return this.getClass() == obj.getClass() &&
                this.value == ((OneHundredBill) obj).value;
    }
}
