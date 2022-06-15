package org.kata.marsRover;

public enum Direction {
    N,
    W,
    S,
    E;

    static
    public final Direction[] values = values();

    public Direction right() {
        return values[(ordinal() - 1  + values.length) % values.length];
    }

    public Direction left() {
        return values[(ordinal() + 1) % values.length];
    }
}
