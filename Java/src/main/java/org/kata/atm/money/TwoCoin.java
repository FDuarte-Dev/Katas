package org.kata.atm.money;

public class TwoCoin extends Coin {
    public TwoCoin() {
        value = 2;
    }

    @Override
    public boolean equals(Object obj) {
        return this.getClass() == obj.getClass() &&
                this.value == ((TwoCoin) obj).value;
    }
}
