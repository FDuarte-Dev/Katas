package org.kata.atm.money;

public class OneCoin extends Coin {
    public OneCoin() {
        value = 1;
    }

    @Override
    public boolean equals(Object obj) {
        return this.getClass() == obj.getClass() &&
                this.value == ((OneCoin) obj).value;
    }
}
