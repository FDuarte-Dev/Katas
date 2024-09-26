package org.kata.atm.money;

public class TenBill extends Bill {
    public TenBill() {
        value = 10;
    }

    @Override
    public boolean equals(Object obj) {
        return this.getClass() == obj.getClass() &&
                this.value == ((TenBill) obj).value;
    }
}
